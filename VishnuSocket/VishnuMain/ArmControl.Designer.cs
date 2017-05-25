﻿namespace VishnuMain
{
    partial class ArmControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArmControl));
            this.redefineButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.ShiftButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trayGroupBox = new System.Windows.Forms.GroupBox();
            this.traySelectorBox = new System.Windows.Forms.ComboBox();
            this.trayRedefine = new System.Windows.Forms.Button();
            this.trayMove = new System.Windows.Forms.Button();
            this.trayStop = new System.Windows.Forms.Button();
            this.trayShift = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trayZaxis = new System.Windows.Forms.NumericUpDown();
            this.coordControl = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moveXval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.moveYval = new System.Windows.Forms.NumericUpDown();
            this.moveZval = new System.Windows.Forms.NumericUpDown();
            this.RotationDegrees = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findPorts = new System.Windows.Forms.Button();
            this.portListBox = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ArmFeedBox = new Emgu.CV.UI.ImageBox();
            this.grabButton = new System.Windows.Forms.Button();
            this.releaseButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DownRightButton = new System.Windows.Forms.Button();
            this.DownLeftButton = new System.Windows.Forms.Button();
            this.UpLeftButton = new System.Windows.Forms.Button();
            this.UpRightButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.lowerZButton = new System.Windows.Forms.Button();
            this.raiseZButton = new System.Windows.Forms.Button();
            this.captureButton = new System.Windows.Forms.Button();
            this.cameraFeedBox = new System.Windows.Forms.GroupBox();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.trayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayZaxis)).BeginInit();
            this.coordControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveXval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveYval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveZval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArmFeedBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.cameraFeedBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // redefineButton
            // 
            this.redefineButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redefineButton.Location = new System.Drawing.Point(217, 227);
            this.redefineButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.redefineButton.Name = "redefineButton";
            this.redefineButton.Size = new System.Drawing.Size(88, 42);
            this.redefineButton.TabIndex = 0;
            this.redefineButton.Text = "REDEFINE";
            this.redefineButton.UseVisualStyleBackColor = true;
            this.redefineButton.Click += new System.EventHandler(this.redefineButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(12, 282);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(293, 38);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // moveButton
            // 
            this.moveButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveButton.Location = new System.Drawing.Point(118, 227);
            this.moveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(78, 42);
            this.moveButton.TabIndex = 2;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // ShiftButton
            // 
            this.ShiftButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftButton.Location = new System.Drawing.Point(12, 227);
            this.ShiftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShiftButton.Name = "ShiftButton";
            this.ShiftButton.Size = new System.Drawing.Size(75, 42);
            this.ShiftButton.TabIndex = 3;
            this.ShiftButton.Text = "SHIFT";
            this.ShiftButton.UseVisualStyleBackColor = true;
            this.ShiftButton.Click += new System.EventHandler(this.ShiftButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trayGroupBox);
            this.groupBox1.Controls.Add(this.coordControl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(464, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(362, 638);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Control Panel";
            // 
            // trayGroupBox
            // 
            this.trayGroupBox.Controls.Add(this.traySelectorBox);
            this.trayGroupBox.Controls.Add(this.trayRedefine);
            this.trayGroupBox.Controls.Add(this.trayMove);
            this.trayGroupBox.Controls.Add(this.trayStop);
            this.trayGroupBox.Controls.Add(this.trayShift);
            this.trayGroupBox.Controls.Add(this.label7);
            this.trayGroupBox.Controls.Add(this.label8);
            this.trayGroupBox.Controls.Add(this.trayZaxis);
            this.trayGroupBox.Location = new System.Drawing.Point(28, 387);
            this.trayGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayGroupBox.Name = "trayGroupBox";
            this.trayGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayGroupBox.Size = new System.Drawing.Size(318, 237);
            this.trayGroupBox.TabIndex = 16;
            this.trayGroupBox.TabStop = false;
            this.trayGroupBox.Text = "Tray Arm Coordinate";
            // 
            // traySelectorBox
            // 
            this.traySelectorBox.FormattingEnabled = true;
            this.traySelectorBox.Items.AddRange(new object[] {
            "Untested Tray",
            "Good Tray",
            "Empty Tray",
            "Bad Tray"});
            this.traySelectorBox.Location = new System.Drawing.Point(28, 35);
            this.traySelectorBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.traySelectorBox.Name = "traySelectorBox";
            this.traySelectorBox.Size = new System.Drawing.Size(102, 25);
            this.traySelectorBox.TabIndex = 16;
            this.traySelectorBox.SelectedIndexChanged += new System.EventHandler(this.traySelectorBox_SelectedIndexChanged);
            // 
            // trayRedefine
            // 
            this.trayRedefine.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayRedefine.Location = new System.Drawing.Point(217, 128);
            this.trayRedefine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayRedefine.Name = "trayRedefine";
            this.trayRedefine.Size = new System.Drawing.Size(88, 42);
            this.trayRedefine.TabIndex = 13;
            this.trayRedefine.Text = "REDEFINE";
            this.trayRedefine.UseVisualStyleBackColor = true;
            // 
            // trayMove
            // 
            this.trayMove.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayMove.Location = new System.Drawing.Point(118, 128);
            this.trayMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayMove.Name = "trayMove";
            this.trayMove.Size = new System.Drawing.Size(78, 42);
            this.trayMove.TabIndex = 14;
            this.trayMove.Text = "MOVE";
            this.trayMove.UseVisualStyleBackColor = true;
            // 
            // trayStop
            // 
            this.trayStop.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayStop.Location = new System.Drawing.Point(12, 183);
            this.trayStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayStop.Name = "trayStop";
            this.trayStop.Size = new System.Drawing.Size(293, 38);
            this.trayStop.TabIndex = 1;
            this.trayStop.Text = "STOP";
            this.trayStop.UseVisualStyleBackColor = true;
            // 
            // trayShift
            // 
            this.trayShift.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayShift.Location = new System.Drawing.Point(12, 128);
            this.trayShift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayShift.Name = "trayShift";
            this.trayShift.Size = new System.Drawing.Size(75, 42);
            this.trayShift.TabIndex = 15;
            this.trayShift.Text = "SHIFT";
            this.trayShift.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Increment Z (cm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tray Choice 0..3";
            // 
            // trayZaxis
            // 
            this.trayZaxis.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayZaxis.Location = new System.Drawing.Point(42, 75);
            this.trayZaxis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trayZaxis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.trayZaxis.Name = "trayZaxis";
            this.trayZaxis.Size = new System.Drawing.Size(77, 25);
            this.trayZaxis.TabIndex = 5;
            // 
            // coordControl
            // 
            this.coordControl.Controls.Add(this.stopButton);
            this.coordControl.Controls.Add(this.ShiftButton);
            this.coordControl.Controls.Add(this.label2);
            this.coordControl.Controls.Add(this.redefineButton);
            this.coordControl.Controls.Add(this.label4);
            this.coordControl.Controls.Add(this.label1);
            this.coordControl.Controls.Add(this.moveXval);
            this.coordControl.Controls.Add(this.label3);
            this.coordControl.Controls.Add(this.moveYval);
            this.coordControl.Controls.Add(this.moveZval);
            this.coordControl.Controls.Add(this.RotationDegrees);
            this.coordControl.Controls.Add(this.moveButton);
            this.coordControl.Location = new System.Drawing.Point(28, 30);
            this.coordControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coordControl.Name = "coordControl";
            this.coordControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.coordControl.Size = new System.Drawing.Size(318, 333);
            this.coordControl.TabIndex = 12;
            this.coordControl.TabStop = false;
            this.coordControl.Text = "Main Arm Coordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rotation (Degrees)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Increment Y (mm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Increment Z (cm)";
            // 
            // moveXval
            // 
            this.moveXval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveXval.Location = new System.Drawing.Point(42, 32);
            this.moveXval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveXval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveXval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveXval.Name = "moveXval";
            this.moveXval.Size = new System.Drawing.Size(77, 23);
            this.moveXval.TabIndex = 8;
            this.moveXval.ValueChanged += new System.EventHandler(this.moveXval_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Increment X (mm)";
            // 
            // moveYval
            // 
            this.moveYval.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveYval.Location = new System.Drawing.Point(42, 82);
            this.moveYval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveYval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveYval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveYval.Name = "moveYval";
            this.moveYval.Size = new System.Drawing.Size(77, 23);
            this.moveYval.TabIndex = 9;
            this.moveYval.ValueChanged += new System.EventHandler(this.moveYval_ValueChanged);
            // 
            // moveZval
            // 
            this.moveZval.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveZval.Location = new System.Drawing.Point(42, 132);
            this.moveZval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.moveZval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.moveZval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.moveZval.Name = "moveZval";
            this.moveZval.Size = new System.Drawing.Size(77, 25);
            this.moveZval.TabIndex = 5;
            this.moveZval.ValueChanged += new System.EventHandler(this.moveZval_ValueChanged);
            // 
            // RotationDegrees
            // 
            this.RotationDegrees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotationDegrees.Location = new System.Drawing.Point(42, 175);
            this.RotationDegrees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RotationDegrees.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.RotationDegrees.Minimum = new decimal(new int[] {
            359,
            0,
            0,
            -2147483648});
            this.RotationDegrees.Name = "RotationDegrees";
            this.RotationDegrees.Size = new System.Drawing.Size(77, 25);
            this.RotationDegrees.TabIndex = 4;
            this.RotationDegrees.ValueChanged += new System.EventHandler(this.RotationDegrees_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Orange;
            this.groupBox2.Controls.Add(this.findPorts);
            this.groupBox2.Controls.Add(this.portListBox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(456, 640);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arduino Control";
            // 
            // findPorts
            // 
            this.findPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.findPorts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findPorts.Location = new System.Drawing.Point(12, 368);
            this.findPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findPorts.Name = "findPorts";
            this.findPorts.Size = new System.Drawing.Size(118, 62);
            this.findPorts.TabIndex = 3;
            this.findPorts.Text = "Find Ports";
            this.toolTip1.SetToolTip(this.findPorts, "Click to discover connected Arduinos if not connected already");
            this.findPorts.UseVisualStyleBackColor = true;
            this.findPorts.Click += new System.EventHandler(this.findPorts_Click);
            // 
            // portListBox
            // 
            this.portListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.portListBox.Location = new System.Drawing.Point(12, 35);
            this.portListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portListBox.Name = "portListBox";
            this.portListBox.ReadOnly = true;
            this.portListBox.Size = new System.Drawing.Size(432, 318);
            this.portListBox.TabIndex = 2;
            this.portListBox.Text = "";
            // 
            // ArmFeedBox
            // 
            this.ArmFeedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArmFeedBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ArmFeedBox.Location = new System.Drawing.Point(2, 17);
            this.ArmFeedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArmFeedBox.Name = "ArmFeedBox";
            this.ArmFeedBox.Size = new System.Drawing.Size(640, 357);
            this.ArmFeedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ArmFeedBox.TabIndex = 2;
            this.ArmFeedBox.TabStop = false;
            // 
            // grabButton
            // 
            this.grabButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabButton.Location = new System.Drawing.Point(1147, 501);
            this.grabButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grabButton.Name = "grabButton";
            this.grabButton.Size = new System.Drawing.Size(91, 46);
            this.grabButton.TabIndex = 10;
            this.grabButton.Text = "GRAB";
            this.grabButton.UseVisualStyleBackColor = true;
            this.grabButton.Click += new System.EventHandler(this.grabButton_Click);
            // 
            // releaseButton
            // 
            this.releaseButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseButton.Location = new System.Drawing.Point(1147, 568);
            this.releaseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.releaseButton.Name = "releaseButton";
            this.releaseButton.Size = new System.Drawing.Size(91, 46);
            this.releaseButton.TabIndex = 11;
            this.releaseButton.Text = "RELEASE";
            this.releaseButton.UseVisualStyleBackColor = true;
            this.releaseButton.Click += new System.EventHandler(this.releaseButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DownRightButton);
            this.groupBox3.Controls.Add(this.DownLeftButton);
            this.groupBox3.Controls.Add(this.UpLeftButton);
            this.groupBox3.Controls.Add(this.UpRightButton);
            this.groupBox3.Controls.Add(this.downButton);
            this.groupBox3.Controls.Add(this.rightButton);
            this.groupBox3.Controls.Add(this.leftButton);
            this.groupBox3.Controls.Add(this.upButton);
            this.groupBox3.Controls.Add(this.lowerZButton);
            this.groupBox3.Controls.Add(this.raiseZButton);
            this.groupBox3.Location = new System.Drawing.Point(844, 466);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(285, 304);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main arm Manual Control Pad";
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // DownRightButton
            // 
            this.DownRightButton.AutoSize = true;
            this.DownRightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownRightButton.Location = new System.Drawing.Point(198, 209);
            this.DownRightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DownRightButton.Name = "DownRightButton";
            this.DownRightButton.Size = new System.Drawing.Size(74, 62);
            this.DownRightButton.TabIndex = 24;
            this.DownRightButton.UseVisualStyleBackColor = true;
            // 
            // DownLeftButton
            // 
            this.DownLeftButton.AutoSize = true;
            this.DownLeftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownLeftButton.Location = new System.Drawing.Point(14, 209);
            this.DownLeftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DownLeftButton.Name = "DownLeftButton";
            this.DownLeftButton.Size = new System.Drawing.Size(74, 62);
            this.DownLeftButton.TabIndex = 23;
            this.DownLeftButton.UseVisualStyleBackColor = true;
            // 
            // UpLeftButton
            // 
            this.UpLeftButton.AutoSize = true;
            this.UpLeftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpLeftButton.Location = new System.Drawing.Point(14, 32);
            this.UpLeftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpLeftButton.Name = "UpLeftButton";
            this.UpLeftButton.Size = new System.Drawing.Size(74, 62);
            this.UpLeftButton.TabIndex = 22;
            this.UpLeftButton.UseVisualStyleBackColor = true;
            // 
            // UpRightButton
            // 
            this.UpRightButton.AutoSize = true;
            this.UpRightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpRightButton.Location = new System.Drawing.Point(198, 32);
            this.UpRightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpRightButton.Name = "UpRightButton";
            this.UpRightButton.Size = new System.Drawing.Size(74, 62);
            this.UpRightButton.TabIndex = 21;
            this.UpRightButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.AutoSize = true;
            this.downButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.Location = new System.Drawing.Point(106, 209);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(74, 62);
            this.downButton.TabIndex = 20;
            this.downButton.Text = "↓";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.AutoSize = true;
            this.rightButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightButton.Location = new System.Drawing.Point(198, 116);
            this.rightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(74, 62);
            this.rightButton.TabIndex = 19;
            this.rightButton.Text = "→";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // leftButton
            // 
            this.leftButton.AutoSize = true;
            this.leftButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(14, 116);
            this.leftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(74, 62);
            this.leftButton.TabIndex = 18;
            this.leftButton.Text = "←";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // upButton
            // 
            this.upButton.AutoSize = true;
            this.upButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.Location = new System.Drawing.Point(106, 32);
            this.upButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(74, 62);
            this.upButton.TabIndex = 17;
            this.upButton.Text = "↑";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // lowerZButton
            // 
            this.lowerZButton.AutoSize = true;
            this.lowerZButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerZButton.Location = new System.Drawing.Point(106, 159);
            this.lowerZButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lowerZButton.Name = "lowerZButton";
            this.lowerZButton.Size = new System.Drawing.Size(74, 42);
            this.lowerZButton.TabIndex = 1;
            this.lowerZButton.Text = "LOWER";
            this.lowerZButton.UseVisualStyleBackColor = true;
            this.lowerZButton.Click += new System.EventHandler(this.lowerZButton_Click);
            // 
            // raiseZButton
            // 
            this.raiseZButton.AutoSize = true;
            this.raiseZButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiseZButton.Location = new System.Drawing.Point(106, 112);
            this.raiseZButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raiseZButton.Name = "raiseZButton";
            this.raiseZButton.Size = new System.Drawing.Size(74, 42);
            this.raiseZButton.TabIndex = 0;
            this.raiseZButton.Text = "RAISE";
            this.raiseZButton.UseVisualStyleBackColor = true;
            this.raiseZButton.Click += new System.EventHandler(this.raiseZButton_Click);
            // 
            // captureButton
            // 
            this.captureButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureButton.Location = new System.Drawing.Point(1147, 422);
            this.captureButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(105, 32);
            this.captureButton.TabIndex = 12;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // cameraFeedBox
            // 
            this.cameraFeedBox.AutoSize = true;
            this.cameraFeedBox.Controls.Add(this.ArmFeedBox);
            this.cameraFeedBox.Location = new System.Drawing.Point(836, 12);
            this.cameraFeedBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cameraFeedBox.Name = "cameraFeedBox";
            this.cameraFeedBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cameraFeedBox.Size = new System.Drawing.Size(644, 376);
            this.cameraFeedBox.TabIndex = 18;
            this.cameraFeedBox.TabStop = false;
            this.cameraFeedBox.Text = "Camera Feed  Viewer";
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(844, 426);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(286, 24);
            this.Camera_Selection.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(839, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Camera Selector";
            // 
            // ArmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Camera_Selection);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.releaseButton);
            this.Controls.Add(this.grabButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cameraFeedBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ArmControl";
            this.Size = new System.Drawing.Size(1600, 900);
            this.groupBox1.ResumeLayout(false);
            this.trayGroupBox.ResumeLayout(false);
            this.trayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trayZaxis)).EndInit();
            this.coordControl.ResumeLayout(false);
            this.coordControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveXval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveYval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveZval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RotationDegrees)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArmFeedBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.cameraFeedBox.ResumeLayout(false);
            this.cameraFeedBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button redefineButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button ShiftButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button findPorts;
        private System.Windows.Forms.RichTextBox portListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown moveZval;
        private System.Windows.Forms.NumericUpDown RotationDegrees;
        private System.Windows.Forms.GroupBox coordControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown moveXval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown moveYval;
        private System.Windows.Forms.Button trayRedefine;
        private System.Windows.Forms.Button trayMove;
        private System.Windows.Forms.Button trayStop;
        private System.Windows.Forms.Button trayShift;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown trayZaxis;
        private System.Windows.Forms.ComboBox traySelectorBox;
        public System.Windows.Forms.GroupBox trayGroupBox;
        private Emgu.CV.UI.ImageBox ArmFeedBox;
        private System.Windows.Forms.Button grabButton;
        private System.Windows.Forms.Button releaseButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button lowerZButton;
        private System.Windows.Forms.Button raiseZButton;
        private System.Windows.Forms.GroupBox cameraFeedBox;
        private System.Windows.Forms.ComboBox Camera_Selection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DownRightButton;
        private System.Windows.Forms.Button DownLeftButton;
        private System.Windows.Forms.Button UpLeftButton;
        private System.Windows.Forms.Button UpRightButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button upButton;
    }
}
