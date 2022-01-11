using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPER.View
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void time_sp_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 75)
            {
                label_wait.Text = "Waiting . . .";
                progressBar1.Value += 3;
            }
            else if (progressBar1.Value >= 75 && progressBar1.Value < 100)
            {
                label_wait.Text = "Mempersiapkan Data";
                progressBar1.Value += 1;
            }
            else if (progressBar1.Value == 100)
            {
                time_sp.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
            double progress = Math.Round((Convert.ToDouble(progressBar1.Value) / 100) * 100, 2);
            label_persen.Text = progress + "%";
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            time_sp.Start();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
