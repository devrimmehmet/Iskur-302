using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iskur302
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formu açtın afferin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salihe Tıklama Kardeşşşş !!! ");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            button1.Text = "Salihi Kimse Silemez";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tB1.Text=="DevrimMehmet")
            {
                if (tB2.Text=="12345678")
                {
                    MessageBox.Show("Giriş Yapıldı.");
                }
                else
                {
                    MessageBox.Show("Yanlış Şifre Girildi.");
                }
            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adı Girildi.");
            }
        }
    }
}
