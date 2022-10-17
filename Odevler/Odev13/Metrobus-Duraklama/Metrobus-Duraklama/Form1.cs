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

namespace Metrobus_Duraklama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure = 0;
        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer2.Start();

        }
        SoundPlayer sogutluCesme = new SoundPlayer(@"C:\Users\DevrimMehmet\Documents\GitHub\Iskur-302\Odevler\Odev13\Metrobus-Duraklama\Metrobus-Duraklama\sesler\sogutlucesme.wav");
        SoundPlayer fikirTepe = new SoundPlayer(@"C:\Users\DevrimMehmet\Documents\GitHub\Iskur-302\Odevler\Odev13\Metrobus-Duraklama\Metrobus-Duraklama\sesler\fikirtepe.wav");
        SoundPlayer uzunCayir = new SoundPlayer(@"C:\Users\DevrimMehmet\Documents\GitHub\Iskur-302\Odevler\Odev13\Metrobus-Duraklama\Metrobus-Duraklama\sesler\uzuncayir.wav");
        SoundPlayer acibadem = new SoundPlayer(@"C:\Users\DevrimMehmet\Documents\GitHub\Iskur-302\Odevler\Odev13\Metrobus-Duraklama\Metrobus-Duraklama\sesler\acibadem.wav");


        private void timer2_Tick(object sender, EventArgs e)
        {
           
            sure++; ;
            if (sure >= 0 && sure <= 60)
            {
                label1.Text = "-" + label1.Text;
                pictureBox1.Left += 4;
            }
            if (sure >=60 && sure <= 80)
            {
                if (sure==70)
                {
                    
                    sogutluCesme.Play();
                }
                Random r = new Random();
                lbl_sogutlucesme.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 80 && sure <= 140)
            {
                
                if (sure >= 90 && sure <= 120)
                {
                    label1.Text = "-" + label1.Text;
                }
                lbl_sogutlucesme.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
                
            }
            if (sure >= 140 && sure <= 160)
            {
                if (sure == 150)
                {

                    fikirTepe.Play();
                }
                Random r = new Random();
                lbl_fikirtepe.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 160 && sure <= 220)
            {
                if (sure >= 165 && sure <= 215)
                {
                    label1.Text = "-" + label1.Text;
                }
               
                lbl_fikirtepe.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 220 && sure <= 240)
            {
                // MessageBox.Show(pictureBox1.Left.ToString());
                if (sure == 230)
                {

                    uzunCayir.Play();
                }
                Random r = new Random();
                lbl_uzuncayir.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 240 && sure <= 300)
            {
                if (sure >= 250 && sure <= 290)
                {
                    label1.Text = "-" + label1.Text;
                }
                lbl_uzuncayir.BackColor = Color.DarkGray;
                pictureBox1.Left += 4;
            }
            if (sure >= 300 && sure <= 320)
            {
                if (sure == 310)
                {

                    acibadem.Play();
                }
                //   MessageBox.Show(pictureBox1.Left.ToString());
                Random r = new Random();
                lbl_acibadem.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure==321)
            {
                
                lbl_acibadem.BackColor = Color.DarkGray;
                timer2.Stop();
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "<--";
            lbl_acibadem.BackColor = Color.Transparent;
            lbl_fikirtepe.BackColor = Color.Transparent;
            lbl_uzuncayir.BackColor = Color.Transparent;
            lbl_sogutlucesme.BackColor = Color.Transparent;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.TextAlign = ContentAlignment.MiddleRight;
            sure--;
            if (sure >= 0 && sure <= 60)
            {
                if (sure >= 0 && sure <= 60)
                {
                    label1.Text =  label1.Text+ "-";
                }
                pictureBox1.Left -= 4;
                lbl_sogutlucesme.BackColor = Color.DarkGray;
            }
            if (sure >= 60 && sure <= 80)
            {
                if (sure == 70)
                {

                    sogutluCesme.Play();
                }
                Random r = new Random();
                lbl_sogutlucesme.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 80 && sure <= 140)
            {
                if (sure >= 80 && sure <= 125)
                {
                    label1.Text = label1.Text + "-";
                }
                lbl_fikirtepe.BackColor = Color.DarkGray;
                pictureBox1.Left -= 4;

            }
            if (sure >= 140 && sure <= 160)
            {
                if (sure == 150)
                {

                    fikirTepe.Play();
                }
                Random r = new Random();
                lbl_fikirtepe.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 160 && sure <= 220)
            {
                if (sure >= 170 && sure <=200)
                {
                    label1.Text = label1.Text + "-";
                }
                lbl_uzuncayir.BackColor = Color.DarkGray;
                pictureBox1.Left -= 4;
            }
            if (sure >= 220 && sure <= 240)
            {
                // MessageBox.Show(pictureBox1.Left.ToString());
                if (sure == 230)
                {

                    uzunCayir.Play();
                }
                Random r = new Random();
                lbl_uzuncayir.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure >= 240 && sure <= 300)
            {
                if (sure >= 240 && sure <= 300)
                {
                    label1.Text = label1.Text + "-";
                }
                lbl_acibadem.BackColor = Color.DarkGray;
                pictureBox1.Left -= 4;
            }
            if (sure >= 300 && sure <= 320)
            {
                if (sure == 310)
                {

                    acibadem.Play();
                }
                Random r = new Random();
                lbl_acibadem.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
            if (sure == 0)
            {
                timer1.Stop();
            }

        }
    }
}
