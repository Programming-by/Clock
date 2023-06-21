namespace Clock
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
            this.lblClockInAlarm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnAlarm = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.btnStopWatch = new System.Windows.Forms.Button();
            this.lblCllockInStopWatch = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTimer = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.numericSecondTimer = new System.Windows.Forms.NumericUpDown();
            this.numericMinuteTimer = new System.Windows.Forms.NumericUpDown();
            this.numericHourTimer = new System.Windows.Forms.NumericUpDown();
            this.lblClockInTimer = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecondTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinuteTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHourTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClockInAlarm
            // 
            this.lblClockInAlarm.AutoSize = true;
            this.lblClockInAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockInAlarm.Location = new System.Drawing.Point(280, 68);
            this.lblClockInAlarm.Name = "lblClockInAlarm";
            this.lblClockInAlarm.Size = new System.Drawing.Size(190, 69);
            this.lblClockInAlarm.TabIndex = 0;
            this.lblClockInAlarm.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(313, 192);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(145, 80);
            this.btnAlarm.TabIndex = 1;
            this.btnAlarm.Text = "OK";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 438);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericSeconds);
            this.tabPage1.Controls.Add(this.numericMinutes);
            this.tabPage1.Controls.Add(this.numericHours);
            this.tabPage1.Controls.Add(this.btnAlarm);
            this.tabPage1.Controls.Add(this.lblClockInAlarm);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alarm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numericSeconds
            // 
            this.numericSeconds.Location = new System.Drawing.Point(497, 150);
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(120, 22);
            this.numericSeconds.TabIndex = 4;
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(338, 150);
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(120, 22);
            this.numericMinutes.TabIndex = 3;
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(197, 150);
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(120, 22);
            this.numericHours.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.lblStopWatch);
            this.tabPage2.Controls.Add(this.btnStopWatch);
            this.tabPage2.Controls.Add(this.lblCllockInStopWatch);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "StopWatch";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(84, 196);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 93);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopWatch.Location = new System.Drawing.Point(249, 116);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(234, 51);
            this.lblStopWatch.TabIndex = 2;
            this.lblStopWatch.Text = "00 : 00 : 00";
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.Location = new System.Drawing.Point(278, 196);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.Size = new System.Drawing.Size(178, 93);
            this.btnStopWatch.TabIndex = 1;
            this.btnStopWatch.Text = "OK";
            this.btnStopWatch.UseVisualStyleBackColor = true;
            this.btnStopWatch.Click += new System.EventHandler(this.btnStopWatch_Click);
            // 
            // lblCllockInStopWatch
            // 
            this.lblCllockInStopWatch.AutoSize = true;
            this.lblCllockInStopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCllockInStopWatch.Location = new System.Drawing.Point(266, 33);
            this.lblCllockInStopWatch.Name = "lblCllockInStopWatch";
            this.lblCllockInStopWatch.Size = new System.Drawing.Size(190, 69);
            this.lblCllockInStopWatch.TabIndex = 0;
            this.lblCllockInStopWatch.Text = "label2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTimer);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.numericSecondTimer);
            this.tabPage3.Controls.Add(this.numericMinuteTimer);
            this.tabPage3.Controls.Add(this.numericHourTimer);
            this.tabPage3.Controls.Add(this.lblClockInTimer);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(783, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(249, 100);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(234, 51);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "00 : 00 : 00";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 66);
            this.button4.TabIndex = 4;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // numericSecondTimer
            // 
            this.numericSecondTimer.Location = new System.Drawing.Point(479, 179);
            this.numericSecondTimer.Name = "numericSecondTimer";
            this.numericSecondTimer.Size = new System.Drawing.Size(120, 22);
            this.numericSecondTimer.TabIndex = 3;
            // 
            // numericMinuteTimer
            // 
            this.numericMinuteTimer.Location = new System.Drawing.Point(330, 179);
            this.numericMinuteTimer.Name = "numericMinuteTimer";
            this.numericMinuteTimer.Size = new System.Drawing.Size(120, 22);
            this.numericMinuteTimer.TabIndex = 2;
            // 
            // numericHourTimer
            // 
            this.numericHourTimer.Location = new System.Drawing.Point(187, 179);
            this.numericHourTimer.Name = "numericHourTimer";
            this.numericHourTimer.Size = new System.Drawing.Size(120, 22);
            this.numericHourTimer.TabIndex = 1;
            // 
            // lblClockInTimer
            // 
            this.lblClockInTimer.AutoSize = true;
            this.lblClockInTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockInTimer.Location = new System.Drawing.Point(260, 13);
            this.lblClockInTimer.Name = "lblClockInTimer";
            this.lblClockInTimer.Size = new System.Drawing.Size(190, 69);
            this.lblClockInTimer.TabIndex = 0;
            this.lblClockInTimer.Text = "label4";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSecondTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinuteTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHourTimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClockInAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnStopWatch;
        private System.Windows.Forms.Label lblCllockInStopWatch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblClockInTimer;
        private System.Windows.Forms.NumericUpDown numericSecondTimer;
        private System.Windows.Forms.NumericUpDown numericMinuteTimer;
        private System.Windows.Forms.NumericUpDown numericHourTimer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer3;
    }
}

