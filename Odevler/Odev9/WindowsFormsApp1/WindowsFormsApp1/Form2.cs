using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tB_a.Text=="")
            {
                MessageBox.Show("Sayıyı Giriniz !");
            }
            else
            {
                int a = int.Parse(tB_a.Text);
                listBox1.Items.Add(a);
            }
          
        }
        int topla(params int[] sayilar)
        {
          int  toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }
        int carp(params int[] sayilar)
        {
            int carpim = 1;
            foreach (var item in sayilar)
            {
                carpim *= item;
            }
            return carpim;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pnl_sonuc.Visible = true;

            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] =int.Parse(listBox1.Items[i].ToString());
            }
            pnl_sonuc.Visible = true;
            lbl_cevre_yazdir.Text=(topla(sayilar)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnl_sonuc.Visible = true;

            int[] sayilar = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sayilar[i] = int.Parse(listBox1.Items[i].ToString());
            }
            pnl_sonuc.Visible = true;
            lbl_alan_yazdir.Text = (carp(sayilar)).ToString();
        }

        private void tB_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
