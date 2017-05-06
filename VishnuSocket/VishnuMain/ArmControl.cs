﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;

namespace VishnuMain
{
    public partial class ArmControl : UserControl
    {        
        delegate void SetTextCallback(string text);
        int portID = 0;
        int ZcoordinateValue;
        int RotationVal;
        int XcoordinateValue;
        int YcoordinateValue;
        int TrayChoiceValue;

        //camerafeed properties
        private bool videoFeed;
        
        Bitmap DrawArea;
       

        public ArmControl()
        {
            InitializeComponent();
            BootMessages();
            findPorts.Enabled = true;
            cameraBox.Paint += new System.Windows.Forms.PaintEventHandler(this.cameraBox_Paint);
            
        }

        public Capture StartCapture()
        {
            if (CvFunctions.camera_feed == null)
            {
                CvFunctions.CvFunctionsCamera();
                CvFunctions.camera_feed.ImageGrabbed += armFeed_Refresher;
                return CvFunctions.camera_feed;
            }
            else
            {
                CvFunctions.camera_feed.ImageGrabbed += armFeed_Refresher;
                return CvFunctions.camera_feed;
            }

        }

        private void armFeed_Refresher(object sender, EventArgs arg)
        {
            //Image<Bgr, Byte> sourceimage = CvFunctions.camera_feed.QueryFrame().ToImage<Bgr, byte>();
            //sourceimage.Draw(new Cross2DF(new PointF(markx, marky), CvFunctions.FrameWidth / 2, CvFunctions.FrameHeight / 2), new Bgr(Color.Red), 1);
            Mat frame = new Mat();
            CvFunctions.camera_feed.Retrieve(frame);

            cameraBox.Image = frame.Bitmap;
            //cameraBox.Dispose();
            
        }

        private void BootMessages()
        {
            if(ArduinoMotionLibrary.Arduinos[0] != 2)
            {
                portListBox.AppendText("Main Robot Arm Connected" + Environment.NewLine);
                coordControl.Enabled = true;
            }
            else if (ArduinoMotionLibrary.Arduinos[0] == 2)
            {
                portListBox.AppendText("Main Robot Arm is disconnected." + Environment.NewLine
                    + "Have you checked your arduino connection or device manager?" + Environment.NewLine);
                coordControl.Enabled = false;
            }
            //default 2 means not connected. 
            if (ArduinoMotionLibrary.Arduinos[1] != 2)
            {
                portListBox.AppendText("Tray Handler Connected");
                trayGroupBox.Enabled = true;
            }
            else if (ArduinoMotionLibrary.Arduinos[1] == 2)
            {
                portListBox.AppendText("Tray Handler Arm is disconnected." + Environment.NewLine 
                    + "Have You checked your arduino connection or device manager?" + Environment.NewLine);
                trayGroupBox.Enabled = false;
            }

        }

        private void openPort_Click(object sender, EventArgs e)
        { 
            portListBox.AppendText(portID + " opened.");
            MessageBox.Show("COM PORT not found, Have you checked Arduino Connection?" + Environment.NewLine);
        }
      
        //ALL coordinate values assignment functions
        private void moveXval_ValueChanged(object sender, EventArgs e)
        {
            XcoordinateValue = (int)moveXval.Value;
        }

        private void moveZval_ValueChanged(object sender, EventArgs e)
        {
            ZcoordinateValue = (int)moveZval.Value;
        }

        private void moveYval_ValueChanged(object sender, EventArgs e)
        {
            YcoordinateValue = (int)moveYval.Value;
        }

        private void RotationDegrees_ValueChanged(object sender, EventArgs e)
        {
            RotationVal = (int)RotationDegrees.Value;
        }


        //Run motor functions
        private void stopButton_Click(object sender, EventArgs e)
        {

            ArduinoMotionLibrary.StopMotor();

        }

        private void redefineButton_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("REDEF", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("MOVE", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void ShiftButton_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArdPosition("SHIFT", portID, XcoordinateValue, YcoordinateValue, ZcoordinateValue, RotationVal);
        }

        private void traySelectorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrayChoiceValue = traySelectorBox.SelectedIndex;
        }

        private void findPorts_Click(object sender, EventArgs e)
        {
            ArduinoMotionLibrary.ArduinoMotionLibraryBoot();
            BootMessages();
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            if (CvFunctions.camera_feed != null)
            {
                if (videoFeed)
                {
                    captureButton.Text = "Start Capture";
                    CvFunctions.camera_feed.Pause();
                }
                else
                {

                    captureButton.Text = "Stop";
                    CvFunctions.camera_feed.Start();
                }
                videoFeed = !videoFeed;
            }

            else
            {
                CvFunctions.camera_feed = StartCapture();
                CvFunctions.camera_feed.Start();
            }
        }

        private void cameraBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            e.Graphics.DrawLine(new Pen(Color.Red), 0, 240, 640, 240);
            e.Graphics.DrawLine(new Pen(Color.Red), 320, 0, 320, 480);
            e.Dispose();
        }
    }
}
