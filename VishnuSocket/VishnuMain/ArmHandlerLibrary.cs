﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VishnuMain
{
    static class ArmHandlerLibrary
    {
        public static bool Running = false;
        public static double[] RestLocation = { 0.0, 150.0, 200.0, 0.0 };
        public static double[] OriginLocation = { 220.0, 120.0, 200.0, 0.0 }; //CPU0 location
        public static double[] SocketLocation = { 20.0, -250.0, 200.0, 0.0 }; //Socket center point
        private static double centerToCenterL = 0.0; //Distance between left and right CPU
        private static double centerToCenterW = 0.0; //Distance between top and bottom CPU
        private static double centerToCenterZ = 0.0; //Distance between trays
        public static int CPUindex = 0; //Which CPU we're on

        
        
        public static void ArmHandlerLibraryMainSequence()
        {   //Start at Origin, find next CPU, Take picture
            //Pick Up requested CPU, Move to Calibration Image
            //Find Socket, put CPU in socket, wait until done
            //Once done, tell tray if good or bad, wait for position
            //Place CPU in position, wait for next either next CPU or done signal

            double[] Loc = { 0.0, 0.0, 0.0, 0.0 };
            FetchInformation();
            TrayManagerLibrary trayHandler = new TrayManagerLibrary(); //should be background worker
            bool done = false;
            int CPU;

            ArduinoMotionLibrary.ArdPosition("REDEF", 0, RestLocation[0], RestLocation[1], RestLocation[2], RestLocation[3]); //Say we're resting, eventually calibrate
            ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1], OriginLocation[2], OriginLocation[3]); //Move to CPU 0 spot to start

            while (!done)
            { //Main Loop
                CPU = trayHandler.GetCPUPosition();
                if (CPU == -1)
                {
                    Running = false;
                    done = true;
                }
                if (!Running)
                {
                    //Return to Origin
                    return;
                }
                Loc[0] = ((CPU % trayHandler.trayDimensions[0]) * centerToCenterL) + OriginLocation[0]; //Move x CPU's over
                if (CPU >= trayHandler.trayDimensions[0])
                {
                    Loc[1] = centerToCenterW + OriginLocation[1];
                } //Adding the y offset to the tray
                else
                {
                    Loc[1] = OriginLocation[1];
                }
                Loc[2] = ((trayHandler.emptyTrayCount-1 + trayHandler.goodTrayCount + trayHandler.badTrayCount) * centerToCenterZ) + OriginLocation[2];
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, Loc[0], Loc[1], Loc[2], Loc[3]); //Move to CPU
                //Verify we're above a CPU
                while(!CameraTestCPU())  
                {
                    //Keep Navigating to next CPU and testing
                }
                //ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, -20, 0); //Descend Z
                ArduinoMotionLibrary.ArdPosition("GRAB", 0, 0, 0, 0, 0); //Grab CPU
                //ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 20, 0); //Raise back up
                //Move to Calibration image, verify it's there in the right spot
                CameraTestImg();
                ArduinoMotionLibrary.ArdPosition("MOVE", 0, SocketLocation[0], SocketLocation[1], SocketLocation[2], SocketLocation[3]);
                ArduinoMotionLibrary.ArdPosition("SHIFT", 0, 0, 0, 0, 0); //Descend into socket
                ArduinoMotionLibrary.ArdPosition("RELEASE", 0, 0, 0, 0, 0); //Release CPU
                //Release CPU
                //Wait for test
                //Tell Tray to present good or bad

                //Runing Template detection code

                ArduinoMotionLibrary.ArdPosition("MOVE", 0, OriginLocation[0], OriginLocation[1], OriginLocation[2], OriginLocation[3]); //Demo done, return to origin
            }
            return;
        }

        private static void FetchInformation()
        {//Get information from settings later
            centerToCenterL = SettingsLibrary.TrayCenter2CenterCol;
            centerToCenterZ = SettingsLibrary.TrayHeight;
            centerToCenterW = SettingsLibrary.TrayCenter2CenterRow;
            return;
        }

        public static bool CameraTestImg()
        {
            //value from templateDetection
            double[] template_xy = { 1000, 1000 };
            string[] fileloc = { "../../../../Common/TempImg/CIRCLE_TEMP.jpg" };
            double xShift = 1000;
            double yShift = 1000;
            CvFunctions imgFx = new CvFunctions();

            while (Math.Abs(xShift) > 4 || Math.Abs(yShift) > 4)
            {
                if (xShift < 100 && yShift < 100)
                {
                    ArduinoMotionLibrary.ArdPosition("SHIFT", 0, Math.Round(xShift, 0), Math.Round(yShift, 0), 0, 0);
                    template_xy[0] = 1000;
                    template_xy[1] = 1000;
                }
                imgFx.TemplateDetection(fileloc, imgFx.SnapPicture(3), template_xy);
                xShift = -1 * template_xy[0] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                    + template_xy[1] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                yShift = template_xy[0] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                    - template_xy[1] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                xShift = xShift * (150 / ArduinoMotionLibrary.ArmCoordinates[2]);
                yShift = yShift * (150 / ArduinoMotionLibrary.ArmCoordinates[2]);
                //Shift by the template_xy 

            }
            return true;
        }

        //mark tray
        public static bool CameraTestCPU()
        {
            return true;
        }

        //take a pic, bool is true if top, false when bottom
        public static void CameraTakePicture(bool isTop)
        {

        }

        public static bool SendDoneMSG()
        {
            return false;
        }

        private static void PlaceCPUInSocket()
        {

        }

        public static bool CPUPassedTest()
        {
            return false;
        }

    }
}
