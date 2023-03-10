namespace WindowsFormsApplication14
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrackBarBrightness1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrackBarContrast1 = new System.Windows.Forms.TrackBar();
            this.buttonDefault1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTime1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxTime2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TrackBarBrightness2 = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.TrackBarContrast2 = new System.Windows.Forms.TrackBar();
            this.buttonDefault2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxTime3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TrackBarGamma3 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.TrackBarSaturation3 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.TrackBarHue3 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackBarBrightness3 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.TrackBarContrast3 = new System.Windows.Forms.TrackBar();
            this.buttonDefault3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTime4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TrackBarBrightness4 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.TrackBarContrast4 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxSafe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGamma3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarHue3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication14.Properties.Resources.untitled;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrackBarBrightness1
            // 
            this.TrackBarBrightness1.LargeChange = 50;
            this.TrackBarBrightness1.Location = new System.Drawing.Point(4, 32);
            this.TrackBarBrightness1.Maximum = 1000;
            this.TrackBarBrightness1.Minimum = -1000;
            this.TrackBarBrightness1.Name = "TrackBarBrightness1";
            this.TrackBarBrightness1.Size = new System.Drawing.Size(250, 42);
            this.TrackBarBrightness1.SmallChange = 10;
            this.TrackBarBrightness1.TabIndex = 0;
            this.TrackBarBrightness1.TickFrequency = 50;
            this.TrackBarBrightness1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Brightness:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contrast:";
            // 
            // TrackBarContrast1
            // 
            this.TrackBarContrast1.Location = new System.Drawing.Point(4, 92);
            this.TrackBarContrast1.Maximum = 5000;
            this.TrackBarContrast1.Name = "TrackBarContrast1";
            this.TrackBarContrast1.Size = new System.Drawing.Size(250, 42);
            this.TrackBarContrast1.TabIndex = 22;
            this.TrackBarContrast1.TickFrequency = 100;
            this.TrackBarContrast1.Value = 1250;
            this.TrackBarContrast1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // buttonDefault1
            // 
            this.buttonDefault1.Location = new System.Drawing.Point(260, 51);
            this.buttonDefault1.Name = "buttonDefault1";
            this.buttonDefault1.Size = new System.Drawing.Size(89, 23);
            this.buttonDefault1.TabIndex = 23;
            this.buttonDefault1.Text = "Default";
            this.buttonDefault1.UseVisualStyleBackColor = true;
            this.buttonDefault1.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSafe);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBoxTime1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TrackBarBrightness1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TrackBarContrast1);
            this.groupBox1.Controls.Add(this.buttonDefault1);
            this.groupBox1.Location = new System.Drawing.Point(524, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 137);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1: AForge";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(257, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Time Span:";
            // 
            // textBoxTime1
            // 
            this.textBoxTime1.Location = new System.Drawing.Point(261, 95);
            this.textBoxTime1.Name = "textBoxTime1";
            this.textBoxTime1.ReadOnly = true;
            this.textBoxTime1.Size = new System.Drawing.Size(89, 20);
            this.textBoxTime1.TabIndex = 24;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxTime2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TrackBarBrightness2);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TrackBarContrast2);
            this.groupBox4.Controls.Add(this.buttonDefault2);
            this.groupBox4.Location = new System.Drawing.Point(524, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 137);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "2: Other Filter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(257, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Time Span:";
            // 
            // textBoxTime2
            // 
            this.textBoxTime2.Location = new System.Drawing.Point(261, 95);
            this.textBoxTime2.Name = "textBoxTime2";
            this.textBoxTime2.ReadOnly = true;
            this.textBoxTime2.Size = new System.Drawing.Size(89, 20);
            this.textBoxTime2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Brightness:";
            // 
            // TrackBarBrightness2
            // 
            this.TrackBarBrightness2.LargeChange = 50;
            this.TrackBarBrightness2.Location = new System.Drawing.Point(4, 32);
            this.TrackBarBrightness2.Maximum = 250;
            this.TrackBarBrightness2.Minimum = -250;
            this.TrackBarBrightness2.Name = "TrackBarBrightness2";
            this.TrackBarBrightness2.Size = new System.Drawing.Size(250, 42);
            this.TrackBarBrightness2.SmallChange = 10;
            this.TrackBarBrightness2.TabIndex = 0;
            this.TrackBarBrightness2.TickFrequency = 10;
            this.TrackBarBrightness2.ValueChanged += new System.EventHandler(this.TrackBar2_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(109, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Contrast:";
            // 
            // TrackBarContrast2
            // 
            this.TrackBarContrast2.Location = new System.Drawing.Point(4, 92);
            this.TrackBarContrast2.Maximum = 100;
            this.TrackBarContrast2.Minimum = -100;
            this.TrackBarContrast2.Name = "TrackBarContrast2";
            this.TrackBarContrast2.Size = new System.Drawing.Size(250, 42);
            this.TrackBarContrast2.TabIndex = 22;
            this.TrackBarContrast2.TickFrequency = 5;
            this.TrackBarContrast2.ValueChanged += new System.EventHandler(this.TrackBar2_ValueChanged);
            // 
            // buttonDefault2
            // 
            this.buttonDefault2.Location = new System.Drawing.Point(260, 32);
            this.buttonDefault2.Name = "buttonDefault2";
            this.buttonDefault2.Size = new System.Drawing.Size(89, 23);
            this.buttonDefault2.TabIndex = 23;
            this.buttonDefault2.Text = "Default";
            this.buttonDefault2.UseVisualStyleBackColor = true;
            this.buttonDefault2.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBoxTime3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TrackBarGamma3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TrackBarSaturation3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TrackBarHue3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TrackBarBrightness3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TrackBarContrast3);
            this.groupBox2.Controls.Add(this.buttonDefault3);
            this.groupBox2.Location = new System.Drawing.Point(524, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 319);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3: QColorMatrix";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Time Span:";
            // 
            // textBoxTime3
            // 
            this.textBoxTime3.Location = new System.Drawing.Point(261, 95);
            this.textBoxTime3.Name = "textBoxTime3";
            this.textBoxTime3.ReadOnly = true;
            this.textBoxTime3.Size = new System.Drawing.Size(89, 20);
            this.textBoxTime3.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gamma:";
            // 
            // TrackBarGamma3
            // 
            this.TrackBarGamma3.Location = new System.Drawing.Point(4, 274);
            this.TrackBarGamma3.Maximum = 80;
            this.TrackBarGamma3.Minimum = 4;
            this.TrackBarGamma3.Name = "TrackBarGamma3";
            this.TrackBarGamma3.Size = new System.Drawing.Size(250, 42);
            this.TrackBarGamma3.TabIndex = 29;
            this.TrackBarGamma3.TickFrequency = 2;
            this.TrackBarGamma3.Value = 20;
            this.TrackBarGamma3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Saturation:";
            // 
            // TrackBarSaturation3
            // 
            this.TrackBarSaturation3.LargeChange = 50;
            this.TrackBarSaturation3.Location = new System.Drawing.Point(4, 153);
            this.TrackBarSaturation3.Maximum = 60;
            this.TrackBarSaturation3.Name = "TrackBarSaturation3";
            this.TrackBarSaturation3.Size = new System.Drawing.Size(250, 42);
            this.TrackBarSaturation3.SmallChange = 10;
            this.TrackBarSaturation3.TabIndex = 24;
            this.TrackBarSaturation3.TickFrequency = 2;
            this.TrackBarSaturation3.Value = 20;
            this.TrackBarSaturation3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hue:";
            // 
            // TrackBarHue3
            // 
            this.TrackBarHue3.Location = new System.Drawing.Point(4, 213);
            this.TrackBarHue3.Maximum = 45;
            this.TrackBarHue3.Minimum = -45;
            this.TrackBarHue3.Name = "TrackBarHue3";
            this.TrackBarHue3.Size = new System.Drawing.Size(250, 42);
            this.TrackBarHue3.TabIndex = 27;
            this.TrackBarHue3.TickFrequency = 2;
            this.TrackBarHue3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Brightness:";
            // 
            // TrackBarBrightness3
            // 
            this.TrackBarBrightness3.LargeChange = 50;
            this.TrackBarBrightness3.Location = new System.Drawing.Point(4, 32);
            this.TrackBarBrightness3.Maximum = 20;
            this.TrackBarBrightness3.Minimum = -20;
            this.TrackBarBrightness3.Name = "TrackBarBrightness3";
            this.TrackBarBrightness3.Size = new System.Drawing.Size(250, 42);
            this.TrackBarBrightness3.SmallChange = 10;
            this.TrackBarBrightness3.TabIndex = 0;
            this.TrackBarBrightness3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contrast:";
            // 
            // TrackBarContrast3
            // 
            this.TrackBarContrast3.Location = new System.Drawing.Point(4, 92);
            this.TrackBarContrast3.Maximum = 80;
            this.TrackBarContrast3.Minimum = 4;
            this.TrackBarContrast3.Name = "TrackBarContrast3";
            this.TrackBarContrast3.Size = new System.Drawing.Size(250, 42);
            this.TrackBarContrast3.TabIndex = 22;
            this.TrackBarContrast3.TickFrequency = 2;
            this.TrackBarContrast3.Value = 20;
            this.TrackBarContrast3.ValueChanged += new System.EventHandler(this.TrackBar3_ValueChanged);
            // 
            // buttonDefault3
            // 
            this.buttonDefault3.Location = new System.Drawing.Point(260, 32);
            this.buttonDefault3.Name = "buttonDefault3";
            this.buttonDefault3.Size = new System.Drawing.Size(89, 23);
            this.buttonDefault3.TabIndex = 23;
            this.buttonDefault3.Text = "Default";
            this.buttonDefault3.UseVisualStyleBackColor = true;
            this.buttonDefault3.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBoxTime4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TrackBarBrightness4);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.TrackBarContrast4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(12, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 152);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "4: - Slow!!!  GetPixel, SetPixel";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(257, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Time Span:";
            // 
            // textBoxTime4
            // 
            this.textBoxTime4.Location = new System.Drawing.Point(261, 95);
            this.textBoxTime4.Name = "textBoxTime4";
            this.textBoxTime4.ReadOnly = true;
            this.textBoxTime4.Size = new System.Drawing.Size(89, 20);
            this.textBoxTime4.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Brightness:";
            // 
            // TrackBarBrightness4
            // 
            this.TrackBarBrightness4.LargeChange = 50;
            this.TrackBarBrightness4.Location = new System.Drawing.Point(9, 37);
            this.TrackBarBrightness4.Maximum = 250;
            this.TrackBarBrightness4.Minimum = -250;
            this.TrackBarBrightness4.Name = "TrackBarBrightness4";
            this.TrackBarBrightness4.Size = new System.Drawing.Size(250, 42);
            this.TrackBarBrightness4.SmallChange = 10;
            this.TrackBarBrightness4.TabIndex = 24;
            this.TrackBarBrightness4.TickFrequency = 10;
            this.TrackBarBrightness4.ValueChanged += new System.EventHandler(this.TrackBar4_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Contrast:";
            // 
            // TrackBarContrast4
            // 
            this.TrackBarContrast4.Location = new System.Drawing.Point(9, 97);
            this.TrackBarContrast4.Maximum = 100;
            this.TrackBarContrast4.Minimum = -100;
            this.TrackBarContrast4.Name = "TrackBarContrast4";
            this.TrackBarContrast4.Size = new System.Drawing.Size(250, 42);
            this.TrackBarContrast4.TabIndex = 27;
            this.TrackBarContrast4.TickFrequency = 5;
            this.TrackBarContrast4.ValueChanged += new System.EventHandler(this.TrackBar4_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Default";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // checkBoxSafe
            // 
            this.checkBoxSafe.AutoSize = true;
            this.checkBoxSafe.Location = new System.Drawing.Point(260, 19);
            this.checkBoxSafe.Name = "checkBoxSafe";
            this.checkBoxSafe.Size = new System.Drawing.Size(48, 17);
            this.checkBoxSafe.TabIndex = 33;
            this.checkBoxSafe.Text = "Safe";
            this.checkBoxSafe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarGamma3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarSaturation3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarHue3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarContrast4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar TrackBarBrightness1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar TrackBarContrast1;
        private System.Windows.Forms.Button buttonDefault1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar TrackBarBrightness2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar TrackBarContrast2;
        private System.Windows.Forms.Button buttonDefault2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar TrackBarGamma3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar TrackBarSaturation3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar TrackBarHue3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar TrackBarBrightness3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar TrackBarContrast3;
        private System.Windows.Forms.Button buttonDefault3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar TrackBarBrightness4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar TrackBarContrast4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTime1;
        private System.Windows.Forms.TextBox textBoxTime2;
        private System.Windows.Forms.TextBox textBoxTime3;
        private System.Windows.Forms.TextBox textBoxTime4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxSafe;
    }
}

