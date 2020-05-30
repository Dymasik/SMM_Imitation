namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxQueue1AvrLength = new System.Windows.Forms.TextBox();
            this.textBoxQueue1AvrTimeAsReal = new System.Windows.Forms.TextBox();
            this.textBoxQueue1AvrTime = new System.Windows.Forms.TextBox();
            this.textBoxQueue2AvrLength = new System.Windows.Forms.TextBox();
            this.textBoxQueue2AvrTimeAsReal = new System.Windows.Forms.TextBox();
            this.textBoxQueue2AvrTime = new System.Windows.Forms.TextBox();
            this.textBoxDevice1Loading = new System.Windows.Forms.TextBox();
            this.textBoxDevice2Loading = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(346, 472);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(126, 47);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(673, 472);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(126, 47);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(61, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(18, 20);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Queue 1 Avr Length";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Queue 2 Avr Length";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Queue 1 Avr Time Real";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Queue 2 Avr Time Real";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Queue 1 Avr Time Calculated";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Queue 2 Avr Time Calculated";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Device 1 Loading";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(386, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Device 2 Loading";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxQueue1AvrLength
            // 
            this.textBoxQueue1AvrLength.Enabled = false;
            this.textBoxQueue1AvrLength.Location = new System.Drawing.Point(169, 43);
            this.textBoxQueue1AvrLength.Name = "textBoxQueue1AvrLength";
            this.textBoxQueue1AvrLength.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue1AvrLength.TabIndex = 19;
            // 
            // textBoxQueue1AvrTimeAsReal
            // 
            this.textBoxQueue1AvrTimeAsReal.Enabled = false;
            this.textBoxQueue1AvrTimeAsReal.Location = new System.Drawing.Point(517, 43);
            this.textBoxQueue1AvrTimeAsReal.Name = "textBoxQueue1AvrTimeAsReal";
            this.textBoxQueue1AvrTimeAsReal.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue1AvrTimeAsReal.TabIndex = 20;
            // 
            // textBoxQueue1AvrTime
            // 
            this.textBoxQueue1AvrTime.Enabled = false;
            this.textBoxQueue1AvrTime.Location = new System.Drawing.Point(907, 43);
            this.textBoxQueue1AvrTime.Name = "textBoxQueue1AvrTime";
            this.textBoxQueue1AvrTime.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue1AvrTime.TabIndex = 21;
            // 
            // textBoxQueue2AvrLength
            // 
            this.textBoxQueue2AvrLength.Enabled = false;
            this.textBoxQueue2AvrLength.Location = new System.Drawing.Point(169, 91);
            this.textBoxQueue2AvrLength.Name = "textBoxQueue2AvrLength";
            this.textBoxQueue2AvrLength.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue2AvrLength.TabIndex = 22;
            // 
            // textBoxQueue2AvrTimeAsReal
            // 
            this.textBoxQueue2AvrTimeAsReal.Enabled = false;
            this.textBoxQueue2AvrTimeAsReal.Location = new System.Drawing.Point(517, 88);
            this.textBoxQueue2AvrTimeAsReal.Name = "textBoxQueue2AvrTimeAsReal";
            this.textBoxQueue2AvrTimeAsReal.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue2AvrTimeAsReal.TabIndex = 23;
            // 
            // textBoxQueue2AvrTime
            // 
            this.textBoxQueue2AvrTime.Enabled = false;
            this.textBoxQueue2AvrTime.Location = new System.Drawing.Point(907, 85);
            this.textBoxQueue2AvrTime.Name = "textBoxQueue2AvrTime";
            this.textBoxQueue2AvrTime.Size = new System.Drawing.Size(164, 26);
            this.textBoxQueue2AvrTime.TabIndex = 24;
            // 
            // textBoxDevice1Loading
            // 
            this.textBoxDevice1Loading.Enabled = false;
            this.textBoxDevice1Loading.Location = new System.Drawing.Point(169, 143);
            this.textBoxDevice1Loading.Name = "textBoxDevice1Loading";
            this.textBoxDevice1Loading.Size = new System.Drawing.Size(164, 26);
            this.textBoxDevice1Loading.TabIndex = 25;
            // 
            // textBoxDevice2Loading
            // 
            this.textBoxDevice2Loading.Enabled = false;
            this.textBoxDevice2Loading.Location = new System.Drawing.Point(536, 140);
            this.textBoxDevice2Loading.Name = "textBoxDevice2Loading";
            this.textBoxDevice2Loading.Size = new System.Drawing.Size(164, 26);
            this.textBoxDevice2Loading.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 224);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 566);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxDevice2Loading);
            this.Controls.Add(this.textBoxDevice1Loading);
            this.Controls.Add(this.textBoxQueue2AvrTime);
            this.Controls.Add(this.textBoxQueue2AvrTimeAsReal);
            this.Controls.Add(this.textBoxQueue2AvrLength);
            this.Controls.Add(this.textBoxQueue1AvrTime);
            this.Controls.Add(this.textBoxQueue1AvrTimeAsReal);
            this.Controls.Add(this.textBoxQueue1AvrLength);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxQueue1AvrLength;
        private System.Windows.Forms.TextBox textBoxQueue1AvrTimeAsReal;
        private System.Windows.Forms.TextBox textBoxQueue1AvrTime;
        private System.Windows.Forms.TextBox textBoxQueue2AvrLength;
        private System.Windows.Forms.TextBox textBoxQueue2AvrTimeAsReal;
        private System.Windows.Forms.TextBox textBoxQueue2AvrTime;
        private System.Windows.Forms.TextBox textBoxDevice1Loading;
        private System.Windows.Forms.TextBox textBoxDevice2Loading;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

