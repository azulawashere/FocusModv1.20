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
            if(!string.IsNullOrEmpty(txt_hour.Text)&& !string.IsNullOrEmpty(txt_min.Text)&& !string.IsNullOrEmpty(txt_sec.Text))
            {
                int hour = Convert.ToInt32(txt_hour.Text);
                int min = Convert.ToInt32(txt_min.Text) + (hour * 60);
                int sec = Convert.ToInt32(txt_sec.Text) + (min * 60);
                progressBar1.Maximum = sec;
                progressBar1.Value = sec;
                timer1.Start();
                this.button1.Enabled = false;
                button1.Visible = false;
                button2.Enabled = true;
                button3.Enabled = false;
                btnreset.Visible = true;
                if (progressBar1.Value == 0)//Timer end sound.
                {
                    timer1.Stop();
                    SoundPlayer ses = new SoundPlayer();
                    ses.SoundLocation = "sound.wav";
                    ses.Play();
                    MessageBox.Show("Time is END", "ALERT", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please fill the lines.");
            }
           
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {   
            progressBar1.Value -= 1;//Countdown.
            if (progressBar1.Value==0)//Timer end sound.
            {
                timer1.Stop();
                SoundPlayer ses = new SoundPlayer();
                ses.SoundLocation = "sound.wav";
                ses.Play();
                MessageBox.Show("Time is END","ALERT",MessageBoxButtons.OK);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
          timer1.Start();
            button3.Enabled = false;
            button2.Enabled = true;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Enabled=false;
            button3.Enabled = false;
            progressBar1.Value= 0;
            timer1.Stop();
            btnreset.Visible = false;
            button1.Enabled = true;
        }
    }
}
