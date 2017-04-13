/*
   Main Program code for Intel CPU Grabber robot
   Arduino control portion, only works on MEGA
   The program receives commands and navigates
   using A4988 Stepper motor Drivers
*/

//Millimeter to step mappings

//power settings: .5 A , 12v 
//Motor Mappings
#define Z 100
#define TRAYMOTOR 0
#define ZMOTOR 2
#define RIGHT true
#define LEFT false
#define OUT true
#define IN false

boolean DEBUG = false; 

//Current position
byte traypos = 0;
int zpos = 0;

//Desired Positions
byte trayposNew = 0;
int zposNew = 0;

//Pin Mappings to Stepper Drivers based on shield
// z motor:   pins 2,5,6
//theta motor:  pins 8,12,13
const byte Enable[6] = {A0, 8, A3, 2, A7, 26};
const byte Step[6] = {A1, 12, A5, 5, 50, 28};
const byte Dir[6] = {A2, 13, A6, 6, 52, 30};

String inputString = "";
boolean CommandReceived = false;
boolean stringComplete = false;

void setup() {
  Serial.begin(115200);

  //Setup for pinouts
  for (int i = 0; i < 6; ++i) {
    pinMode(Enable[i], OUTPUT);
    digitalWrite(Enable[i], HIGH);
    pinMode(Step[i], OUTPUT);
    digitalWrite(Step[i], LOW);
    pinMode(Dir[i], OUTPUT);
    digitalWrite(Dir[i], LOW);
  }
  delay(250);
  Serial.println("TRAYHANDLER");
}

void loop() {
  delay(100);
}
