using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTimer
{
    public partial class Form1 : Form
    {
        private int timeRemaining;

        public Form1()
        {
            InitializeComponent();
        }

        private enum timerState
        {
            idle,
            active,
            alert
        }

        private Form1.timerState tState;
        private Alert alert;

        public void Alert(string msg)
        {
            if (alert != null)
            {
                alert.CloseAlert();
                alert = null;
            }
            alert = new Alert();

            alert.showAlert(msg);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (tState == timerState.active)
            {
                timerMain.Stop();
                tState = timerState.idle;
                StartButton.Text = "Start";
                return;
            }

            string[] totalSeconds = maskedTextBox1.Text.Split(':');
            int hours = Convert.ToInt32(totalSeconds[0]) > 60? 60 : Convert.ToInt32(totalSeconds[0]);
            int mins = Convert.ToInt32(totalSeconds[1]) > 60 ? 60 : Convert.ToInt32(totalSeconds[1]);
            int secs = Convert.ToInt32(totalSeconds[2]) > 60 ? 60 : Convert.ToInt32(totalSeconds[2]);

            timeRemaining = ((hours * 60 * 60) + (mins * 60) + secs);

            if (timeRemaining <= 0)
            {
                return;
            }

            timerMain.Interval = 1000;
            timerMain.Start();
            tState = timerState.active;
            StartButton.Text = "Pause";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            maskedTextBox1.Mask = "00:00:00";
            tState = timerState.idle;
            StartButton.Text = "Start";
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            timeRemaining -= 1;
            TimeSpan time = TimeSpan.FromSeconds(timeRemaining);
            maskedTextBox1.Text = time.ToString();

            if (timeRemaining <= 0)
            {
                this.Alert(msgTextBox.Text);
                timerMain.Stop(); //can't stop the main timer without stopping the Alert timer.
                StartButton.Text = "Start";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            timerMain.Stop();
            if (alert != null)
            {
                alert.CloseAlert();
                alert = null;
            }
            tState = timerState.idle;
            timeRemaining = 0;
            maskedTextBox1.Text = "00:00:00";
            StartButton.Text = "Start";
            //ResetOpenAlerts();
        }

    }
}
