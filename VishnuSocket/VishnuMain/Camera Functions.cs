﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using DataMatrix.net;
using Emgu.CV.UI;

namespace VishnuMain
{
    public class CvFunctions
    {
        Mat color_frame = new Mat();
        Mat gray_frame = new Mat();
        Mat binary_frame = new Mat();
        Mat[] rgb_frame;

        /*METHODS BELOW*/

        ///<summary>
        /// Returns image, various modes: 0.color 1.grayscale 2.redbinary 3.binary
        ///</summary>
        public Mat SnapPicture(int mode, Capture camera_feed)
        {
            camera_feed.Retrieve(color_frame);
            camera_feed.Retrieve(color_frame);
            camera_feed.Retrieve(color_frame);
            

            switch (mode)
            {

                case 1: //case for just grayscale img
                    CvInvoke.CvtColor(color_frame, gray_frame, ColorConversion.Bgr2Gray);
                    return gray_frame;

                case 2://case for barcode scanning
                    rgb_frame = color_frame.Split();
                    CvInvoke.Threshold(rgb_frame[2], binary_frame, 150, 255, ThresholdType.Binary);
                    return binary_frame;

                case 3: //case for calibration x.y
                    CvInvoke.CvtColor(color_frame, gray_frame, ColorConversion.Bgr2Gray); //This threw an exception for greyscale stuff
                    CvInvoke.Threshold(gray_frame, binary_frame, 100, 255, ThresholdType.Binary);
                    return binary_frame;

                default:
                    return color_frame;

            }
        }


        ///<summary>
        ///Return coordinate offset for correcton
        ///</summary>
        public Mat TemplateDetection(string[] templatelist, Mat sourceImg, double[] xy_Coord, bool fromTab)
        { //takes in list of template images, source img

            using (Mat ResultMat = new Mat())                   //mat data holds template matches coordinates
            using (Mat result_img = sourceImg.Clone())
            {        //image with rectangles
                int template_length = 0;
                try
                {
                    template_length = templatelist.Length;
                }
                catch (System.NullReferenceException ex)
                {
                    MessageBox.Show(ex + Environment.NewLine + "Please select a template image");
                    return sourceImg;
                }

                //requirement for template detection
                double minValues = 0;
                double maxValues = 0;
                Point minLocations = new Point { X = 0, Y = 0 };
                Point maxLocations = new Point { X = 0, Y = 0 };

                //loop used to go through all template images
                for (int i = 0; i < template_length; i++)
                {
                    //loop to mark all matches

                    //creates image from list
                    Mat templateImg = CvInvoke.Imread(templatelist[i], LoadImageType.Grayscale);

                    //does template matching
                    CvInvoke.MatchTemplate(sourceImg, templateImg, ResultMat, TemplateMatchingType.CcoeffNormed);

                    //finds best matching location
                    CvInvoke.MinMaxLoc(ResultMat, ref minValues, ref maxValues, ref minLocations, ref maxLocations);

                    //accpetance check
                    if (maxValues > 0.7)
                    {

                        //creates rectangle 
                        Rectangle match = new Rectangle(maxLocations, templateImg.Size);

                        double offset_x;
                        double offset_y;
                        double x_cm = 1920 / 23;
                        double y_cm = 1080 / 13;
                        //23x13 @ 16.5 cm  use this z height for calibration
                        //20x10 @ 12.5 cm
                        //12.1x6.8 @ 8.3 cm 
                        //30 x 15.5 @ 21 cm

                        offset_x = Math.Round((960 - (match.X + (match.Width / 2))) / x_cm, 2) * 10;
                        offset_y = Math.Round((540 - (match.Y + (match.Height / 2))) / y_cm, 2) * 10;

                        xy_Coord[0] = offset_x;
                        xy_Coord[1] = offset_y;

                        double xShift, yShift = 0.0;
                        double[] template_xy = { offset_x, offset_y };

                        //MessageBox.Show("Left/Right:" + offset_x + "\n" + "Up/Down:" + offset_y, "Coordinates");
                        xShift = -1 * template_xy[0] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                       + template_xy[1] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                        yShift = template_xy[0] * Math.Sin(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533)
                            - template_xy[1] * Math.Cos(ArduinoMotionLibrary.ArmCoordinates[4] * 0.0174533);
                        xShift = xShift * (ArduinoMotionLibrary.ArmCoordinates[2] / 165);
                        yShift = -1 * yShift * (ArduinoMotionLibrary.ArmCoordinates[2] / 165);
                        if (fromTab)
                        {
                            MessageBox.Show("X Relative:" + xShift + "\n" + "Y Relative:" + yShift, "Coordinates");
                        }
                        //draws rectangle match onto source img
                        CvInvoke.Rectangle(sourceImg, match, new Bgr(Color.Black).MCvScalar, 20);

                        //section to compelte floodfill function
                        //Rectangle outRect;

                        //Mat mask = new Mat(sourceImg.Height + 2, sourceImg.Width + 2, DepthType.Cv8U, 1);

                        //MCvScalar lo = new MCvScalar(0);
                        //MCvScalar up = new MCvScalar(255);

                        //method to fill in all rectagles so there will be no redundant detection
                        //CvInvoke.FloodFill(sourceImg,
                        //    mask, maxLocations,
                        //    new MCvScalar(0), out outRect,
                        //    lo, up,
                        //    Connectivity.FourConnected,
                        //    FloodFillType.Default);

                    }
                    //loops template matching
                }

                return sourceImg;
            }
        }


        ///<summary>
        ///Scans 2D-DataMatrix Barcode and returns value
        ///</summary>
        public string BarcodeScanner(Mat barcode_img)
        {
            //creates decorder object
            DmtxImageDecoder decoder = new DmtxImageDecoder();

            //decode barcode img
            List<string> codes = decoder.DecodeImage(barcode_img.Bitmap, 1, new TimeSpan(0, 0, 2));

            //return barcode string
            if (codes.Count > 0)
                return codes[0];
            else
            {
                return "Nothing found";
            }
        }


        public void SaveImg(Mat Img, string filename)
        {
            Img.Save(filename);
        }


        //object detection, cpu chips via haar casecade
        public void haar_cascade(Mat Img, List<Rectangle> cpus)
        {
            using (CascadeClassifier cpu = new CascadeClassifier("../../../../Common/haar_classifier/cpu_working.xml"))
            {
                using (Mat gray = new Mat())
                {
                    //CvInvoke.CvtColor(Img, gray, ColorConversion.Bgr2Gray);
                    CvInvoke.EqualizeHist(gray, gray);
                    Rectangle[] cpuDetected = cpu.DetectMultiScale(gray, 1.2, 1);
                    foreach (Rectangle c in cpuDetected)
                    {
                        Rectangle cpuRect = c;
                        cpuRect.Offset(c.X, c.Y);
                        cpus.Add(cpuRect);
                    }
                }
            }
        }


        //displays haar detected images
        public void displayHar(Mat Img, List<Rectangle> cpus, ImageBox OutputImgBox)
        {
            foreach (Rectangle cpu in cpus)
                CvInvoke.Rectangle(Img, cpu, new Bgr(Color.Cyan).MCvScalar, 3);
            OutputImgBox.Image = Img;
        }
        
        public bool cpuExists(Mat Img, List<Rectangle> cpu)
        {
            bool exists;
           //CvInvoke.Resize(Img, Img, new Size(640, 480));
           // Image<Bgr, Byte> RImg = Img.ToImage<Bgr, Byte>();
            //RImg.Rotate(90, new Bgr(Color.Blue));
            //Mat img = RImg.Mat;
            haar_cascade(Img, cpu);

            if (cpu.Count > 1)
            {
                exists = true;
                //cpu.Clear();
            }
            else exists = false;
            return exists;
        }

    }
}
