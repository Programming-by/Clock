using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private int countSeconds = 0;
        private int countMinutes = 0;
        private int countHours = 0;
        private void CurrentTime()
        {
            lblClockInAlarm.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second;
            lblCllockInStopWatch.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second;
            lblClockInTimer.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            CurrentTime();

            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Enabled = true;

        }

        System.Windows.Forms.Timer t = null;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime();
        }
        private void btnAlarm_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Alarm in " + numericHours.Value + " Hours " + numericMinutes.Value + " Minutes " + numericSeconds.Value + " Seconds";
            notifyIcon1.BalloonTipText = "This is Alarm";
            notifyIcon1.ShowBalloonTip(1000);


        }
        private void btnStopWatch_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void IncreaseStopWatchTime()
        {
            if (countSeconds > 59)
            {
                countSeconds = 0;
                countMinutes++;
            }

            if (countMinutes > 59)
            {
                countMinutes = 0;
                countHours++;
            }


            if (countHours > 23)
            {
                countSeconds = 0;
                countMinutes = 0;
                countHours = 0;
            }

        }
       
        private void ChangeStopWatchTime()
        {

            string AddSZero = " :0";
            string AddMZero = " :0";
            string AddHZero = "0";

          
            if (countSeconds > 9)
            {
                AddSZero = " : ";
           }

            if(countMinutes > 9)
            {
                AddMZero = " : ";

            }

            if (countHours > 9)
            {
                AddHZero = " ";
            }

            lblStopWatch.Text = AddHZero + countHours.ToString() + AddMZero + countMinutes.ToString() + AddSZero + countSeconds.ToString();




        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            countSeconds++;
            IncreaseStopWatchTime();
            ChangeStopWatchTime();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblStopWatch.Text = "00 : 00 : 00";
            timer2.Enabled = false;
            countSeconds = 0;
            countMinutes = 0;
            countHours = 0;
        }

        private int TimerSeconds = 0;
        private int TimerMinutes = 0;
        private int TimerHours = 0;

        private void ConvertTimerCounterToInt()
        {

            TimerSeconds = Convert.ToInt32(numericSecondTimer.Value);
            TimerMinutes = Convert.ToInt32(numericMinuteTimer.Value);
            TimerHours = Convert.ToInt32(numericHourTimer.Value);
        }

        private void TimerNotifyIcon()
        {
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Timer";
            notifyIcon1.BalloonTipText = "Timer Done";
            notifyIcon1.ShowBalloonTip(1000);
        }


        private void ChangeTimerTime()
        {

            string AddSZero = " :0";
            string AddMZero = " :0";
            string AddHZero = "0";


            if (TimerSeconds > 9)
            {
                AddSZero = " : ";
            }

            if (TimerMinutes > 9)
            {
                AddMZero = " : ";

            }

            if (TimerHours > 9)
            {
                AddHZero = " ";
            }

            lblTimer.Text = AddHZero + TimerHours.ToString() + AddMZero + TimerMinutes.ToString() + AddSZero + TimerSeconds.ToString();
        }


        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;

            ConvertTimerCounterToInt();

        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            if (TimerSeconds  > 0 && TimerSeconds <= 59)
            {

            TimerSeconds--;

            }

            if ((TimerMinutes > 0 && TimerMinutes <=  59))
            {
                if (TimerSeconds == 0)
                {
                    TimerMinutes--;
                    TimerSeconds = 60;
                    TimerSeconds--;
                }
            }

            if ((TimerHours > 0 && TimerHours <= 23))
            {
                if (TimerSeconds == 0)
                {
                    TimerHours--;
                    TimerMinutes = 59;
                }
            }

            ChangeTimerTime();
            ShowTimerNotifyIcon();

        }
   
    
        private void ShowTimerNotifyIcon()
        {
            if (TimerHours == 0 && TimerMinutes == 0 && TimerSeconds == 0)
            {
            TimerNotifyIcon();
            timer3.Enabled = false;
            return;
            }
        }

    }
}
