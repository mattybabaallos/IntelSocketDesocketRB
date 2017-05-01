int Calibrate(){ //TBD Later
  return 1;
}

void CommandProcess(){//Parse command
  if(stringComplete){
    int i = 0;
    int len = inputString.length();
    char inputChars[50];
    for(i=0;i<=len;++i){
      inputChars[i]=inputString[i];
    }
    inputChars[i+1]='\n';
    char* command = strtok(inputChars, ":"); //break up input string
    char pieces[5][10];
    i = 0;
    
    while(command != NULL){ //iterate through sections
      if(i < 5){
        strcpy(pieces[i++], command);
        command = strtok(NULL, ":"); //This moves to next chunk
      }
    }    
    boolean Shift = false; //Shifting, not moving to coordinates
    boolean Redef = false;
    if(inputString.startsWith("SHIFT")){ //Move from where we are
      inputString = inputString.substring(6);
      if(DEBUG){
        Serial.println("Command is SHIFT");
      }
      Shift = true;
    }
    else if(inputString.startsWith("MOVE")){ //Move to coordinates
      inputString = inputString.substring(5);
      if(DEBUG){
        Serial.println("Command is MOVE");
      }
    }
    else if(inputString.startsWith("REDEF")){ //Reorient coordinates
      inputString = inputString.substring(6);
      Redef = true;
      if(DEBUG){
        Serial.println("Command is REDEF");
      }
    }
    else if(inputString.startsWith("RELAY")){//Send coordinates
      RelayCoordinates();
      inputString = "";
      stringComplete = false;
      return;
    }
    else if(inputString.startsWith("DEBUG")){//send debug messages
      if(DEBUG){
        DEBUG = false;
      }
      else{
        DEBUG = true;
        Serial.println("Debug on");
      }
      inputString = "";
      stringComplete = false;
      return;
    }
    else if(inputString.startsWith("QUERY")){//Send boot message
      Serial.println("MAINROBOTARM");
      inputString = "";
      stringComplete = false;
      return;
    }
    else{
      Serial.println("ERROR:NOVALIDCMD");//Command didn't make sense
      Serial.println(inputString); //what we received
      inputString = "";
      stringComplete = false;
      return;
    }
    inputString = "";
    stringComplete = false;
    
    xposNew = atoi(pieces[1]);//Assign actual values
    yposNew = atoi(pieces[2]);
    zposNew = atoi(pieces[3]);
    angleNew = atof(pieces[4]);

    if(Shift){
      xposNew += xpos;
      yposNew += ypos;
      zposNew += zpos;      
      angleNew += angle;
    }

    if(Redef){
      xpos = xposNew;
      ypos = yposNew;
      zpos = zposNew;      
      angle = angleNew;
    }

    if(DEBUG){
      Serial.println("New Coordinates:");
      Serial.println(xposNew);
      Serial.println(yposNew);
      Serial.println(zposNew);
      Serial.println(angleNew);
      Serial.println("Old Coordinates:");
      Serial.println(xpos);
      Serial.println(ypos);
      Serial.println(zpos);
      Serial.println(angle);
      delay(100);
    }

    if(xposNew < 0 && xposNew > -0.01){
      xposNew = 0;
    }
    if(yposNew < 0 && yposNew > -0.01){
      yposNew = 0;
    }
    if(angleNew < 0 && angleNew > -0.01){
      angleNew = 0;
    }

    if(xposNew >= 0 && yposNew >= 0 && zposNew >= 0 && angleNew >=0 && xposNew < 1000 && yposNew < 1000 && zposNew < 1000 && angleNew < 360){
       Serial.println("NAVIGATING");
       MapCoordinates(false);
       Navigate();
       Serial.println("DONE");
       RelayCoordinates();
    }
    else{
      Serial.println("ERROR:EOB");
    }
  }
  else{
    Serial.println("ERROR");
    return;
  }
}

void MapCoordinates(boolean cartesian){ //Converts cart -> cyl and back
  if(!cartesian){// If we call it with false, we convert cyl. coor.
    double x = double(xposNew);
    double y = double(yposNew);
    thetaNew = atan2(x,y)*57.2958;
    radiusNew = sqrt(pow(xposNew,2)+pow(yposNew,2));
    x = double(xpos);
    y = double(ypos);
    theta = atan2(x,y)*57.2958;
    radius = sqrt(pow(xpos,2)+pow(ypos,2));
  }
  else{ //Convert to cart. coor
    xpos = radius * (sin(theta/(180.0/PI)));
    ypos = radius * (cos(theta/(180.0/PI)));
  }

  if(DEBUG){
    Serial.println("Mapped coordinates: ");
    Serial.print("Theta: ");Serial.println(theta, 4);
    Serial.print("Radius: ");Serial.println(radius, 2);
    Serial.print("New theta: ");Serial.println(thetaNew,4);
    Serial.print("New radius: ");Serial.println(radiusNew, 2);
  }
  return;
}

void RelayCoordinates(){ //Send back coordinates
  MapCoordinates(true); //Round them off, if need be 
  float xTmp = round(xpos); //round the real values if error
  float yTmp = round(ypos); //is an issue later
  float zTmp = round(zpos);
  Serial.print("COOR:");
  Serial.print(xTmp);Serial.print(':');
  Serial.print(yTmp);Serial.print(':');
  Serial.print(zTmp);Serial.print(':');
  Serial.println(angle,1);
  return;
}

void Navigate(){ //Moves to new positions
  
  boolean radDirection;
  boolean thetaDirection;
  boolean angleDirection;
  
  if(radiusNew != radius){ //These determine direction
    if(radiusNew > radius){
      digitalWrite(Dir[RADMOTOR], HIGH);
      deltaRadius =  radiusNew - radius;
      radDirection = OUT;
    }
    else{
      digitalWrite(Dir[RADMOTOR], LOW);
      deltaRadius = radius - radiusNew;
      radDirection = IN;
    }
  }
  float delayFactor = 0;
  if(thetaNew != theta){
    if(thetaNew > theta){
      delayFactor = thetaNew/theta;
      digitalWrite(Dir[THETAMOTOR], HIGH);
      deltaTheta = thetaNew - theta;
      thetaDirection = RIGHT;
    }
    else{
      delayFactor = theta/thetaNew;
      digitalWrite(Dir[THETAMOTOR], LOW);
      deltaTheta = theta - thetaNew;
      thetaDirection = LEFT;
    }
  }
  if(zposNew != zpos){
    if(zposNew > zpos)
      deltaZ = zposNew - zpos;
    else
      deltaZ = zpos - zposNew;
  }
  if(angleNew != angle){
    if(angleNew > angle){
      digitalWrite(Dir[ANGLEMOTOR], HIGH);
      deltaAngle = angleNew - angle;
    }
    else{
      digitalWrite(Dir[ANGLEMOTOR], LOW);
      deltaAngle = angle - angleNew;
    }
  }  
  
  if(DEBUG){
    Serial.println("\nDeltas are:");
    Serial.print("Theta: ");Serial.println(deltaTheta,2);
    Serial.print("Radius: ");Serial.println(deltaRadius,2);
    Serial.print("Z: ");Serial.println(deltaZ,2);
    Serial.print("Angle: ");Serial.println(deltaAngle,2);
  
  }
  
  //Do z chunk first if going up
  if(zposNew > zpos){
    digitalWrite(Dir[ZMOTOR], HIGH);
    if(DEBUG){
      Serial.print("Moving Up: ");Serial.println(digitalRead(Dir[ZMOTOR]));
    }
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        serialEvent();
        digitalWrite(Step[ZMOTOR], LOW);
        delayMicroseconds(500);
        digitalWrite(Step[ZMOTOR], HIGH);
        delayMicroseconds(500);
      }
      ++zpos;

      if(DEBUG){
        Serial.print("Z position: ");Serial.println(zpos);
      }
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }

  if(DEBUG){ //Move laterally
    Serial.println("Moving over");
  }

  boolean doneRad = false;
  boolean doneTheta = false;
  boolean doneAngle = false;

  int thetaOriginal = theta;
  int whereWereGoing = thetaOriginal + deltaTheta;
  while(!doneTheta){
    serialEvent();
    if(deltaTheta > .4){  //Theta Section
      digitalWrite(Enable[THETAMOTOR], LOW);
      digitalWrite(Step[THETAMOTOR], LOW);
      delay(3);
      digitalWrite(Step[THETAMOTOR], HIGH);
      double x = ((theta-thetaOriginal)*2*PI)/(whereWereGoing - thetaOriginal);
      double tDelay = 12.5*cos(x)+12.5;
      /*if(thetaDirection == RIGHT){
        if(theta > ((thetaNew + thetaOriginal)/2))
          addDelay = abs(map(theta, thetaOriginal, ((thetaNew + thetaOriginal)/2), 25, 0));
        else
          addDelay = map(theta, ((thetaNew + thetaOriginal)/2), thetaOriginal, 0, 25);
      }
      if(thetaDirection == LEFT){
        if(theta < ((thetaNew + thetaOriginal)/2))
          addDelay = abs(map(theta, thetaOriginal, ((thetaNew + thetaOriginal)/2), 25, 0));
        else
          addDelay = map(theta, ((thetaNew + thetaOriginal)/2), thetaOriginal, 0, 25);
      }*/
      int addDelay = (5*tDelay) + 18;
      if(DEBUG){
        Serial.print("addDelay: ");Serial.println(addDelay);
      }
      delay(tDelay);
      deltaTheta -= 1/float(THETA);
      if(thetaDirection == LEFT){
        theta -= 1/float(THETA);
      }
      else
        theta += 1/float(THETA);
    }
    if(deltaTheta <= .4){
      doneTheta = true;
      delay(300);
      digitalWrite(Enable[THETAMOTOR], HIGH);
    }  
  }
  while(!doneRad){  //Radius Section
    serialEvent();
    if(deltaRadius > 0.01){
      digitalWrite(Enable[RADMOTOR], LOW);
      digitalWrite(Step[RADMOTOR], LOW);
      delayMicroseconds(500);
      digitalWrite(Step[RADMOTOR], HIGH);
      delayMicroseconds(500);
      deltaRadius -= 1/float(RAD);
      if(radDirection == IN){
        radius -= 1/float(RAD);
      }
      else
        radius += 1/float(RAD);
      if(DEBUG){
        //Serial.print("Radius position: ");Serial.println(radius);
      }
    }
    if(deltaRadius <= 0.01){
      doneRad = true;
      digitalWrite(Enable[RADMOTOR], HIGH);
    }
  }
  while(!doneAngle){ //Angle Section
    serialEvent();
    if(deltaAngle > 0){
      digitalWrite(Enable[ANGLEMOTOR], LOW);
      digitalWrite(Step[ANGLEMOTOR], LOW);
      delay(3);
      digitalWrite(Step[ANGLEMOTOR], HIGH);
      delay(5);
      deltaAngle -= 1.8;
      if(angleDirection == LEFT){
        angle -=1.8;
      }
      else
        angle += 1.8;
      if(DEBUG){
        Serial.print("Angle position: ");Serial.println(angle);
      }
    }
    if(deltaAngle <= 0){
      doneAngle = true;
      digitalWrite(Enable[ANGLEMOTOR], HIGH);
    }
  }

  if(zpos > zposNew){ //Z going down, do last
    digitalWrite(Dir[ZMOTOR], LOW);
    if(DEBUG){
      Serial.print("Moving down: ");Serial.print(digitalRead(Dir[ZMOTOR]));
    }
    digitalWrite(Enable[ZMOTOR], LOW);
    for(int i=0;i<deltaZ;++i){
      for(int j=0;j<Z;++j){
        serialEvent();
        digitalWrite(Step[ZMOTOR], LOW);
        delayMicroseconds(500);
        digitalWrite(Step[ZMOTOR], HIGH);
        delayMicroseconds(500);
      }
      --zpos;
      if(DEBUG){
        Serial.print("Z position: ");Serial.println(zpos);
      }
    }
    digitalWrite(Enable[ZMOTOR], HIGH);
  }
  return;
}

void EmergencyStop(){ //Resets movement information
  thetaNew = 0;
  radiusNew = 0;
  deltaZ = 0;
  deltaTheta = 0;
  deltaRadius = 0;
  deltaAngle = 0;
  return;
}

void serialEvent(){ //Catch chars coming in
  while (Serial.available()) 
  {
    while (Serial.available()){
      char inChar = (char)Serial.read();
      if (inChar >= 'A' && inChar <= 'Z' || inChar >= '0' && inChar <= ':' || inChar == '\r' || inChar == '-'){ 
        inputString += inChar;
        if (inChar == '\r'){
          stringComplete = true;
          Serial.flush();
          if(DEBUG){
            Serial.println("Command received");
            Serial.println(inputString);
          }
          if(inputString.startsWith("STOP")){ //Emergency Brake
            EmergencyStop();
            Serial.println("STOPPING");
            inputString = "";
            stringComplete = false;
            RelayCoordinates();
            return;
          }
          CommandProcess();
        } 
      }
    }
  }
}
