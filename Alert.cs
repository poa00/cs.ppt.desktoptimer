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
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseAlert();
        }

        public void CloseAlert()
        {
            base.Close();
        }

        public void showAlert(string msg)
        {
            this.Opacity = 1.0f;
            this.StartPosition = FormStartPosition.Manual;

            this.Name = "Alert";
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Location = new Point(x, y); //show in bottom right corner

            this.labelMessage.Text = msg;
            this.TopMost = true;
            this.Show();
        }
    }
}
