/*
   Main Program code for Intel CPU Grabber robot
   Arduino control portion, only works on MEGA
   The program receives commands and navigates
   using A4988 Stepper motor Drivers
*/

//Millimeter to step mappings
# define RAD 100
# define THETA 2 //to one degree
# define Z 100

//power settings: .5 A , 12v 
//Motor Mappings
#define RADMOTOR 0
#define THETAMOTOR 2
#define ZMOTOR 4
#define ANGLEMOTOR 3
#define RIGHT true
#define LEFT false
#define OUT true
#define IN false
//Grabber solenoid and Servo pins
#define GRABBER 26
#define SERVO 8


boolean DEBUG = false; 

//Current position
double xpos = 0;
double ypos = 150;
int zpos = 200;
double angle = 0; //Angle for end effector

double theta = 0; //angle of robot
double radius = 150; //extension of arm

double thetaNew = 0;
double radiusNew = 0;
double deltaZ = 0;
double deltaTheta = 0;
double deltaRadius = 0;
double deltaAngle = 0;

//Desired Positions
double xposNew = 0;
double yposNew = 0;
int zposNew = 0;
double angleNew = 0;

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
  pinMode(GRABBER, OUTPUT);
  digitalWrite(GRABBER, LOW);
  Serial.println("MAINROBOTARM");
}

void loop() {
  delay(100);
}
