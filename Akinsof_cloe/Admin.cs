using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akinsof_cloe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            int hour = Convert.ToInt32(txt_hour.Text);
            int min = Convert.ToInt32(txt_min.Text) + (hour * 60) ;
            int sec = Convert.ToInt32(txt_sec.Text) + (min * 60) ;
            progressBar1.Maximum= sec;
            progressBar1.Value = sec;
            timer1.Start();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        SoundPlayer player;
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value -= 1;
            if (progressBar1.Value==0)
            {
                timer1.Stop();
                SoundPlayer ses = new SoundPlayer();
                ses.SoundLocation = "sound.wav";
                ses.Play();
                MessageBox.Show("Time is END","ALERT",MessageBoxButtons.OK);
            }
        }
    }
}
