﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace VishnuMain
{
    static class ArduinoMotionLibrary
    {
        //SerialPort object declaration
        //public static SerialPort ArdPort = new SerialPort();
        public static List<SerialPort> ArdPorts = new List<SerialPort>();
        public static byte[] Arduinos = { 2, 2 };      //0 is Main Arm, 1 is Tray handler
        public static double[] ArmCoordinates = { 0.0, 0.0, 0.0, 0.0, 0.0 }; //X,Y,Z, end eff., theta
        public static double TrayZ = 0.0;
        public static int TrayPresented = 0;
        private static int CorrectionDepth = 0;

        public static void ArduinoMotionLibraryBoot()
        {
            ArdPorts.Add(new SerialPort());
            ArdPorts.Add(new SerialPort());

            for (int i = 0; i< 2; i++)
            {
                ArdPorts[i] = new SerialPort();
                ArdPorts[i].BaudRate = 115200;
                ArdPorts[i].ReadTimeout = 3000;
            }

            int status = findAvailiblePorts();
            if (status == 0)
            {
                Error(status);
            }
            else
            {
                OpenPorts();
            }

            ArdPosition("RELAY", 0, 0, 0, 0, 0);
        }

        private static int findAvailiblePorts()
        {
            string[] portList = SerialPort.GetPortNames();

            int i = 0;
            foreach (string line in portList)
            {
                ArdPorts[i].PortName = portList[i];
                ++i;
            }
            if (ArdPorts[0].PortName == null)
            {
                return 0; //This is bad!
            }
            else if (ArdPorts[0].PortName == null ^ ArdPorts[1].PortName == null)
            {
                return 1; //This is bad! missing one connector
            }
            else if (ArdPorts[0].PortName != null && ArdPorts[1].PortName != null)
            {
                return 2; //This is good! both connected
            }
            else
                return 0;
        }

        private static void OpenPorts() //Find the connected Arduinos
        {
            int numArduinos = 2;
            //try to see if any are connected
            try
            {
                ArdPorts[0].Open();
            }
            catch (System.IO.IOException e)
            {//If there's an exception on the first one we have a problem
                //MessageBox.Show(e.Message);
                Error(0);
                return;
            }
            catch (System.UnauthorizedAccessException e)
            {
                //MessageBox.Show(e.Message);
                Error(0);
                return;
            }

            //we have at least one connected, see if both are connected
            try
            {
                ArdPorts[1].Open();
            }
            catch (System.IO.IOException e)
            {//If there's an exception on the second one we just have one connected
                //MessageBox.Show(e.Message);
                numArduinos = 1;
            }
            catch (System.UnauthorizedAccessException e)
            {
                //MessageBox.Show(e.Message);
                numArduinos = 1;
            }

            string data = null;
            bool checkedYet = false;
            while (checkedYet == false)
            { 
                //Assign arduinos to ports
                
                ArdPorts[0].WriteLine("QUERY\r");
                Task.Delay(30);

                try
                {
                    data = ArdPorts[0].ReadLine();
                }
                catch (TimeoutException e)
                {
                    //MessageBox.Show(e.Message);
                    numArduinos = 0;
                    return;
                }
                
                if (data == "TRAYHANDLER\r")
                {
                    Arduinos[1] = 0;
                    checkedYet = true;
                }
                else if (data == "MAINROBOTARM\r")
                {
                    Arduinos[0] = 0;
                    checkedYet = true;
                }
                else if (data != null)
                {                                               //Sometimes there's junk in the buffer and we need to try again
                    checkedYet = true;
                }
                else
                {                                               //If we try twice and nothing happens, we're dead in the water
                    Error(4);
                    return;
                }
            }

            if (numArduinos == 2)
            {//If we have two arduinos and they both work, we're in business
                checkedYet = false;
                data = null;
                while (checkedYet == false)
                {
                    ArdPorts[1].WriteLine("QUERY\r");
                    Task.Delay(30);
                    data = ArdPorts[1].ReadLine();
                    if (data == "TRAYHANDLER\r")
                    {
                        Arduinos[1] = 1;
                        checkedYet = true;
                    }
                    else if (data == "MAINROBOTARM\r")
                    {
                        Arduinos[0] = 1;
                        checkedYet = true;
                    }
                    else if (data != null)
                    {
                        checkedYet = true;
                    }
                    else
                    {
                        Error(4);
                        return;
                    }
                }
            }
            return;
        }

        //positional commands.  send command type (shift, move, redef, the port number 0 or 1, and the four coords.
        public static int ArdPosition(string command, int portID, double Xval, double Yval, double Zval, double thetaVal)
        {//Inputs a command and values, and a desired arduino (0 or 1)
            bool problem = false; //Did we encounter a problem during the operation?
            if (Arduinos[portID] == 2)
            {
                return -1; //Not connected
            }

            if (ArdPorts[portID].BytesToRead > 0)
                {
                        ArdPorts[portID].DiscardInBuffer();
                }

            string inputLine = null;
            if (portID == 0) //Going to CPU Main arm
            {
                inputLine = command + ":" + Xval + ":" + Yval + ":" + Zval + ":" + thetaVal + "\r";
            }
            else if (portID == 1) //Going to Tray handler, Yval is tray position
            {
                inputLine = command + ":" + Xval + ":" + Yval + "\r";
            }
            else
            {
                return -1;
            }

            ArdPorts[portID].WriteLine(inputLine);
            Task.Delay(30); //Waiting for navigation message
            string data = ArdPorts[portID].ReadLine();

            bool done = false;
            while (!done)
            {
                Task.Delay(50);
                if (ArdPorts[portID].BytesToRead > 0 && !(data.StartsWith("COOR")))
                {
                    data = ArdPorts[portID].ReadLine();
                }
                if (data == "DONE\r" || data.StartsWith("COOR"))
                {
                    Task.Delay(50);
                    if (ArdPorts[portID].BytesToRead > 0 && data == "DONE\r")
                    {
                        data = ArdPorts[portID].ReadLine();
                    }
                    //Check COOR
                    if (data.StartsWith("COOR"))
                    {
                        string[] pieces = data.Split(':');
                        if (portID == 0)
                        {
                            double[] OldValues = { ArmCoordinates[0], ArmCoordinates[1], ArmCoordinates[2], ArmCoordinates[3]};
                            try
                            {
                                ArmCoordinates[0] = double.Parse(pieces[1]);
                                ArmCoordinates[1] = double.Parse(pieces[2]);
                                ArmCoordinates[2] = double.Parse(pieces[3]);
                                ArmCoordinates[3] = double.Parse(pieces[4]);
                                ArmCoordinates[4] = double.Parse(pieces[5]);
                            }
                            catch(Exception e)
                            { //If there's junk data, nan throws an error and we're done for
                                ArdPosition("REDEF", 0, -82, 170, 100, 90);
                                return -2;
                            }

                            if(ArmCoordinates[0] > 600 || ArmCoordinates[0] < -600 || ArmCoordinates[1] > 600 || ArmCoordinates[1] < -600 || 
                                ArmCoordinates[2] > 600 || ArmCoordinates[2] < -600 || ArmCoordinates[3] > 200 || ArmCoordinates[0] < -200)
                            {//We were out of bounds somehow, that's a big problem
                                ArdPosition("REDEF", 0, -82, 170, 100, 90);
                                return -2;
                            }

                            if (command == "MOVE")
                            {//If the command was an actual move command
                                double[] error = { ArmCoordinates[0] - Xval, ArmCoordinates[1] - Yval, ArmCoordinates[2] - Zval, ArmCoordinates[3] - thetaVal };
                                if (error[0] > 20 || error[0] < -20 || error[1] > 20 || error[1] < -20 || error[2] > 20 || error[3] < -20 || error[3] > 20 || error[3] < -20)
                                {//If there is significant error we might have had a power loss, tell it where it is and carry on
                                    ArdPosition("REDEF", 0, Xval, Yval, Zval, thetaVal);
                                    problem = true;
                                }
                                if (error[0] > 2 || error[0] < -2 || error[1] > 2 || error[0] < -2 && CorrectionDepth < 5)
                                {//This function will work recursively to correct any detected math error
                                    ++CorrectionDepth;
                                    ArdPosition("SHIFT", 0, error[0], error[1], error[2], error[3]);
                                }
                            }
                            if (command == "SHIFT")
                            {//If the command was an actual move command
                                double[] error = { ArmCoordinates[0] - OldValues[0] - Xval, ArmCoordinates[1] - OldValues[1]  - Yval,
                                    ArmCoordinates[2] - OldValues[2] - Zval, ArmCoordinates[3] - OldValues[3] - thetaVal };
                                if (error[0] > 20 || error[0] < -20 || error[1] > 20 || error[1] < -20 || error[2] > 20 || error[3] < -20 || error[3] > 20 || error[3] < -20)
                                {//If there is significant error we might have had a power loss, tell it where it is and carry on
                                    ArdPosition("REDEF", 0, Xval, Yval, Zval, thetaVal);
                                    problem = true;
                                }
                                if (error[0] > 2 || error[0] < -2 || error[1] > 2 || error[0] < -2 && CorrectionDepth < 5)
                                {//This function will work recursively to correct any detected math error
                                    ++CorrectionDepth;
                                    ArdPosition("SHIFT", 0, error[0], error[1], error[2], error[3]);
                                }
                            }

                        }
                        else if (portID == 1)
                        {
                            TrayZ = double.Parse(pieces[2]);
                            TrayPresented = int.Parse(pieces[1]);
                        }
                    }
                    else
                        return -1;
                    done = true;
                }
                else if (data.StartsWith("ERROR"))
                {
                    string[] pieces = data.Split(':');
                    if (portID == 0)
                    {
                        if(pieces[1] == "CRASH\r") //Radius will crash
                        {

                        }
                        if (pieces[1] == "EOB\r") //Exceeds operation boundary
                        {

                        }
                    }
                    else if (portID == 1)
                    {
                        if (pieces[1] == "CRASH\r") //Radius will crash
                        {

                        }
                        if (pieces[1] == "EOB\r") //Exceeds operation boundary
                        {

                        }
                    }
                    return -2;//Command didn't work
                }
            }
            Task.Delay(500);
            --CorrectionDepth; //Rising up out of recursion
            if (CorrectionDepth < 0)
                CorrectionDepth = 0;

            if (problem)
            {//Command required a redefine, you may not be where you need to or may be mapped wrong
                return -1;
            }

            return 0;
        }

        //Send STOP command to Arduino.  
        public static int StopMotor()
        {

            string inputLine = "STOP\r";

            Task.Delay(30); //Waiting for navigation message
            for (int portID = 0; portID < 2; ++portID)
            {
                if (Arduinos[portID] != 2)
                {
                    ArdPorts[portID].WriteLine(inputLine);
                    string data = ArdPorts[portID].ReadLine();
                    if (data != "STOPPING\r")
                    {
                        Task.Delay(15); //Should probably have an error counter
                    }
                    bool done = false;
                    while (!done)
                    {
                        Task.Delay(50);
                        if (ArdPorts[portID].BytesToRead > 0)
                        {
                            data = ArdPorts[portID].ReadLine();
                        }
                        Task.Delay(50);
                        if (ArdPorts[portID].BytesToRead > 0)
                        {
                            data = ArdPorts[portID].ReadLine();
                        }
                        //Check COOR
                        if (data.StartsWith("COOR"))
                        {
                            string[] pieces = data.Split(':');
                            if (portID == 0)
                            {
                                ArmCoordinates[0] = double.Parse(pieces[1]);        //save x
                                ArmCoordinates[1] = double.Parse(pieces[2]);        //save y
                                ArmCoordinates[2] = double.Parse(pieces[3]);        //save z
                                ArmCoordinates[3] = double.Parse(pieces[4]);        //save theta
                            }
                            else if (portID == 1)
                            {
                                TrayZ = double.Parse(pieces[1]);
                                TrayPresented = int.Parse(pieces[2]);
                            }
                        }
                        else
                            return -1;
                        done = true;
                    }
                }
            }

            return 0;
        }

        public static void Error(int status)
        { //Error 0, nothing connected, 
            return;
        }

    }
}
