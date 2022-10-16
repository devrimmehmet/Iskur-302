using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Panelin içine dikdörtgen kare üçgen daire 
            // özellikler panelin icinde olack 
            // seçime tıklayınca sadece o gözükecek.
            // panel yüklendiğinde panel kapalı olacak.

            comboBox1.Items.Clear();
            if (tB1.Text=="" || tB2.Text== "" || comboBox1.Text=="")
            {
                MessageBox.Show("Sayı Nerde Salih?  İşlem Seçtinmi Salih ? Doktor Bu Ne?");
            }
            else { 
            if (comboBox1.Text=="+")
            {
                int sayi1 = Convert.ToInt32(tB1.Text);
                int sayi2 = Convert.ToInt32(tB2.Text);
                int sonuc = sayi1 + sayi2;
                lblSonuc.Text = sonuc.ToString();
                tB1.Clear();
                tB2.Clear();
            }
            if (comboBox1.Text == "-")
            {
                int sayi1 = Convert.ToInt32(tB1.Text);
                int sayi2 = Convert.ToInt32(tB2.Text);
                int sonuc = sayi1 - sayi2;
                lblSonuc.Text = sonuc.ToString();
                tB1.Clear();
                tB2.Clear();
            }
            if (comboBox1.Text == "*")
            {
                int sayi1 = Convert.ToInt32(tB1.Text);
                int sayi2 = Convert.ToInt32(tB2.Text);
                int sonuc = sayi1 * sayi2;
                lblSonuc.Text = sonuc.ToString();
                tB1.Clear();
                tB2.Clear();
            }
            if (comboBox1.Text == "/")
            {
                int sayi1 = Convert.ToInt32(tB1.Text);
                int sayi2 = Convert.ToInt32(tB2.Text);
                int sonuc = sayi1 / sayi2;
                lblSonuc.Text = sonuc.ToString();
                tB1.Clear();
                tB2.Clear();
            }
            }
        }

        private void tB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
