
namespace removeColor
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.saturateBlue = new System.Windows.Forms.Button();
            this.saturateGreen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.loadFile = new System.Windows.Forms.Button();
            this.grayscaleButton = new System.Windows.Forms.Button();
            this.redIntensity = new System.Windows.Forms.TrackBar();
            this.blueIntensity = new System.Windows.Forms.TrackBar();
            this.greenIntensity = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.originalPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(37, 44);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(492, 576);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(38, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Line Art";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Location = new System.Drawing.Point(38, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Saturate Reds";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saturateBlue
            // 
            this.saturateBlue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saturateBlue.Location = new System.Drawing.Point(38, 198);
            this.saturateBlue.Name = "saturateBlue";
            this.saturateBlue.Size = new System.Drawing.Size(97, 40);
            this.saturateBlue.TabIndex = 3;
            this.saturateBlue.Text = "Saturate Blues";
            this.saturateBlue.UseVisualStyleBackColor = false;
            this.saturateBlue.Click += new System.EventHandler(this.saturateBlue_Click);
            // 
            // saturateGreen
            // 
            this.saturateGreen.BackColor = System.Drawing.Color.LightGreen;
            this.saturateGreen.Location = new System.Drawing.Point(38, 152);
            this.saturateGreen.Name = "saturateGreen";
            this.saturateGreen.Size = new System.Drawing.Size(97, 40);
            this.saturateGreen.TabIndex = 4;
            this.saturateGreen.Text = "Saturate Greens";
            this.saturateGreen.UseVisualStyleBackColor = false;
            this.saturateGreen.Click += new System.EventHandler(this.saturateGreen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.greenIntensity);
            this.groupBox1.Controls.Add(this.blueIntensity);
            this.groupBox1.Controls.Add(this.redIntensity);
            this.groupBox1.Controls.Add(this.grayscaleButton);
            this.groupBox1.Controls.Add(this.loadFile);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.saturateGreen);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.saturateBlue);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 393);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Modes";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(97, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox3.Controls.Add(this.picCanvas);
            this.groupBox3.Location = new System.Drawing.Point(289, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(570, 644);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(38, 336);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(97, 40);
            this.loadFile.TabIndex = 9;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // grayscaleButton
            // 
            this.grayscaleButton.BackColor = System.Drawing.Color.LightGray;
            this.grayscaleButton.Location = new System.Drawing.Point(38, 244);
            this.grayscaleButton.Name = "grayscaleButton";
            this.grayscaleButton.Size = new System.Drawing.Size(97, 40);
            this.grayscaleButton.TabIndex = 8;
            this.grayscaleButton.Text = "Grayscale";
            this.grayscaleButton.UseVisualStyleBackColor = false;
            this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
            // 
            // redIntensity
            // 
            this.redIntensity.Location = new System.Drawing.Point(141, 101);
            this.redIntensity.Maximum = 255;
            this.redIntensity.Name = "redIntensity";
            this.redIntensity.Size = new System.Drawing.Size(128, 45);
            this.redIntensity.TabIndex = 10;
            this.redIntensity.Value = 100;
            // 
            // blueIntensity
            // 
            this.blueIntensity.Location = new System.Drawing.Point(141, 198);
            this.blueIntensity.Maximum = 255;
            this.blueIntensity.Name = "blueIntensity";
            this.blueIntensity.Size = new System.Drawing.Size(128, 45);
            this.blueIntensity.TabIndex = 11;
            this.blueIntensity.Value = 100;
            // 
            // greenIntensity
            // 
            this.greenIntensity.Location = new System.Drawing.Point(141, 152);
            this.greenIntensity.Maximum = 255;
            this.greenIntensity.Name = "greenIntensity";
            this.greenIntensity.Size = new System.Drawing.Size(128, 45);
            this.greenIntensity.TabIndex = 12;
            this.greenIntensity.Value = 100;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Location = new System.Drawing.Point(38, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Custom Saturation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // originalPreview
            // 
            this.originalPreview.Location = new System.Drawing.Point(93, 437);
            this.originalPreview.Name = "originalPreview";
            this.originalPreview.Size = new System.Drawing.Size(152, 196);
            this.originalPreview.TabIndex = 1;
            this.originalPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Original Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 683);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.originalPreview);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Anti-Colorize!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.redIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button saturateBlue;
        private System.Windows.Forms.Button saturateGreen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button grayscaleButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar greenIntensity;
        private System.Windows.Forms.TrackBar blueIntensity;
        private System.Windows.Forms.TrackBar redIntensity;
        private System.Windows.Forms.PictureBox originalPreview;
        private System.Windows.Forms.Label label1;
    }
}

