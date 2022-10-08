using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
   
    public partial class Form1 : Form
    {
        public string[] atlar = { "Muhammet","CihatHan","Neval","İlker","Devrim","Salih","Burak","Bedirhan","Mısra","Büşra","MertK","MertT","Sena","Berkcan" };
        decimal point = 100m;
        string kazanan = "0";
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();//Örnek alma
        private void btnBaslat_Click(object sender, EventArgs e)
        {


            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region Atları Koşturma
           
            pbAt1.Left += rnd.Next(2, 15);//10,20,15
            pbAt2.Left += rnd.Next(2, 15);
            pbAt3.Left += rnd.Next(2, 15);
            pbAt4.Left += rnd.Next(2, 15);//10,20,15
            pbAt5.Left += rnd.Next(2, 15);
            pbAt6.Left += rnd.Next(2, 15);
            pbAt7.Left += rnd.Next(2, 15);//10,20,15
            pbAt8.Left += rnd.Next(2, 15);
            pbAt9.Left += rnd.Next(2, 15);
            pbAt10.Left += rnd.Next(2, 15);//10,20,15
            pbAt11.Left += rnd.Next(2, 15);
            pbAt12.Left += rnd.Next(2, 15);
            pbAt13.Left += rnd.Next(2, 15);//10,20,15 //
            pbAt14.Left += rnd.Next(2, 15);

            #endregion

            #region Atların Kazanma Durumu
            if (pbAt1.Right >= lblFinish.Left)
            {
                //point = point + (numericUpDown1.Value * 1.30m);
                label9.Text = point.ToString() + " TL";
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Muhammet)1. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;

                }
                else
                {
                    Application.Exit();
                }
            }
            else if (pbAt2.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Cihat Han)2. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
                else
                {
                    Application.Exit();
                }

            }
            else if (pbAt3.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Neval)3. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
                else
                {
                    Application.Exit();
                }

            }
            else if (pbAt4.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(İlker)4. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt5.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Devrim)5. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt6.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Salih)6. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt7.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Burak)7. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt8.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Bedirhan)8. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt9.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Mısra)9. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt10.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Büşra)10. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt11.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(MertK)11. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt12.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(MertT)12. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt13.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Sena)13. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
            else if (pbAt14.Right >= lblFinish.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("(Berkcan)14. At Kazandı\nTekrar oynamak ister misin?", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    pbAt1.Left = 12;
                    pbAt2.Left = 12;
                    pbAt3.Left = 12;
                    pbAt4.Left = 12;
                    pbAt5.Left = 12;
                    pbAt6.Left = 12;
                    pbAt7.Left = 12;
                    pbAt8.Left = 12;
                    pbAt9.Left = 12;
                    pbAt10.Left = 12;
                    pbAt11.Left = 12;
                    pbAt12.Left = 12;
                    pbAt13.Left = 12;
                    pbAt14.Left = 12;
                }
            }
           
            #endregion

            //#region Spiker
            //if (pbAt1.Right > pbAt2.Right && pbAt1.Right > pbAt3.Right)
            //{
            //    lblSpiker.Text = "1. At önde gidiyor";
            //}
            //else if (pbAt2.Right > pbAt1.Right && pbAt2.Right > pbAt3.Right)
            //{
            //    lblSpiker.Text = "2. At önde gidiyor";
            //}
            ////else if (pbAt3.Right > pbAt1.Right && pbAt3.Right > pbAt2.Right)
            ////{
            ////    lblSpiker.Text = "3. At önde gidiyor";
            ////}
            //else
            //{
            //    lblSpiker.Text = "3. At önde gidiyor";
            //} 
            //#endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  point = point - (numericUpDown1.Value);
            label9.Text = point.ToString() + " TL";
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label9.Text =point.ToString()+" TL" ;
        }
    }
}
