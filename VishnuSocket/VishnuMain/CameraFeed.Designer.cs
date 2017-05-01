﻿namespace VishnuMain
{
    partial class CameraFeed
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
            this.captureButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Setting_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showStats = new System.Windows.Forms.Button();
            this.MainSequenceButton = new System.Windows.Forms.Button();
            this.Reset_Cam_Settings = new System.Windows.Forms.Button();
            this.Refresh_BTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Camera_Selection = new System.Windows.Forms.ComboBox();
            this.Cam_lbl = new System.Windows.Forms.Label();
            this.CaptureBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureButton
            // 
            this.captureButton.Enabled = false;
            this.captureButton.Location = new System.Drawing.Point(27, 98);
            this.captureButton.Margin = new System.Windows.Forms.Padding(4);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(153, 34);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Setting_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cam_lbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CaptureBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 18);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 1072);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Setting_lbl
            // 
            this.Setting_lbl.AutoSize = true;
            this.Setting_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_lbl.Location = new System.Drawing.Point(617, 0);
            this.Setting_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Setting_lbl.Name = "Setting_lbl";
            this.Setting_lbl.Size = new System.Drawing.Size(91, 25);
            this.Setting_lbl.TabIndex = 2;
            this.Setting_lbl.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.showStats);
            this.panel1.Controls.Add(this.MainSequenceButton);
            this.panel1.Controls.Add(this.Reset_Cam_Settings);
            this.panel1.Controls.Add(this.Refresh_BTN);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Camera_Selection);
            this.panel1.Controls.Add(this.captureButton);
            this.panel1.Location = new System.Drawing.Point(617, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 1032);
            this.panel1.TabIndex = 0;
            // 
            // showStats
            // 
            this.showStats.Location = new System.Drawing.Point(27, 730);
            this.showStats.Name = "showStats";
            this.showStats.Size = new System.Drawing.Size(133, 34);
            this.showStats.TabIndex = 26;
            this.showStats.Text = "Show Stats";
            this.showStats.UseVisualStyleBackColor = true;
            this.showStats.Click += new System.EventHandler(this.showStats_Click);
            // 
            // MainSequenceButton
            // 
            this.MainSequenceButton.BackColor = System.Drawing.Color.Blue;
            this.MainSequenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSequenceButton.Location = new System.Drawing.Point(27, 383);
            this.MainSequenceButton.Margin = new System.Windows.Forms.Padding(4);
            this.MainSequenceButton.Name = "MainSequenceButton";
            this.MainSequenceButton.Size = new System.Drawing.Size(286, 94);
            this.MainSequenceButton.TabIndex = 25;
            this.MainSequenceButton.Text = "Start Test Sequence";
            this.MainSequenceButton.UseVisualStyleBackColor = false;
            this.MainSequenceButton.Click += new System.EventHandler(this.MainSequenceButton_Click);
            // 
            // Reset_Cam_Settings
            // 
            this.Reset_Cam_Settings.Location = new System.Drawing.Point(446, 730);
            this.Reset_Cam_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Reset_Cam_Settings.Name = "Reset_Cam_Settings";
            this.Reset_Cam_Settings.Size = new System.Drawing.Size(153, 34);
            this.Reset_Cam_Settings.TabIndex = 17;
            this.Reset_Cam_Settings.Text = "Reset";
            this.Reset_Cam_Settings.UseVisualStyleBackColor = true;
            this.Reset_Cam_Settings.Click += new System.EventHandler(this.Reset_Cam_Settings_Click);
            // 
            // Refresh_BTN
            // 
            this.Refresh_BTN.Location = new System.Drawing.Point(446, 969);
            this.Refresh_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Refresh_BTN.Name = "Refresh_BTN";
            this.Refresh_BTN.Size = new System.Drawing.Size(153, 34);
            this.Refresh_BTN.TabIndex = 12;
            this.Refresh_BTN.Text = "Refresh";
            this.Refresh_BTN.UseVisualStyleBackColor = true;
            this.Refresh_BTN.Click += new System.EventHandler(this.Refresh_BTN_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 807);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(571, 152);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 777);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Camera";
            // 
            // Camera_Selection
            // 
            this.Camera_Selection.FormattingEnabled = true;
            this.Camera_Selection.Location = new System.Drawing.Point(27, 56);
            this.Camera_Selection.Margin = new System.Windows.Forms.Padding(4);
            this.Camera_Selection.Name = "Camera_Selection";
            this.Camera_Selection.Size = new System.Drawing.Size(343, 28);
            this.Camera_Selection.TabIndex = 3;
            // 
            // Cam_lbl
            // 
            this.Cam_lbl.AutoSize = true;
            this.Cam_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cam_lbl.Location = new System.Drawing.Point(4, 0);
            this.Cam_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cam_lbl.Name = "Cam_lbl";
            this.Cam_lbl.Size = new System.Drawing.Size(141, 25);
            this.Cam_lbl.TabIndex = 1;
            this.Cam_lbl.Text = "Camera View";
            // 
            // CaptureBox
            // 
            this.CaptureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptureBox.Location = new System.Drawing.Point(3, 35);
            this.CaptureBox.Name = "CaptureBox";
            this.CaptureBox.Size = new System.Drawing.Size(606, 540);
            this.CaptureBox.TabIndex = 3;
            this.CaptureBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 504);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(558, 35);
            this.progressBar1.TabIndex = 27;
            // 
            // CameraFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CameraFeed";
            this.Size = new System.Drawing.Size(1263, 1110);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Setting_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Cam_lbl;
        private System.Windows.Forms.ComboBox Camera_Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Refresh_BTN;
        private System.Windows.Forms.Button Reset_Cam_Settings;
        private System.Windows.Forms.PictureBox CaptureBox;
        private System.Windows.Forms.Button MainSequenceButton;
        private System.Windows.Forms.Button showStats;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backWorker;
    }
}
 
