using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool durum = false;
        double sonuc = 0;
        string opt = "";
        private void rakam(object sender, EventArgs e)
        {
            if (txt_Sonuc.Text == "0" || durum)
            {
               // txt_Sonuc.Text = "0";
             //   txt_Sonuc.Clear();
            }
            durum = false;

            Button btn = (Button)sender;
            txt_Sonuc.Text += btn.Text;
        }

        private void hesaplama(object sender, EventArgs e)
        {
            durum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lbl_Sonuc.Text = lbl_Sonuc.Text + " " + txt_Sonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+":
                    txt_Sonuc.Text = (sonuc + double.Parse(txt_Sonuc.Text)).ToString();
                    break;
                case "-":
                    txt_Sonuc.Text = (sonuc - double.Parse(txt_Sonuc.Text)).ToString();
                    break;
                case "*":
                    txt_Sonuc.Text = (sonuc * double.Parse(txt_Sonuc.Text)).ToString();
                    break;
                case "/":
                    txt_Sonuc.Text = (sonuc / double.Parse(txt_Sonuc.Text)).ToString();
                    break;
            }
            sonuc=double.Parse(txt_Sonuc.Text);
            txt_Sonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Text = "0";
            lbl_Sonuc.Text = "";
            opt = "";
            sonuc = 0;
            durum = false;
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {
            lbl_Sonuc.Text = "";
            durum = true;
            switch (opt)
            {
                case "+":
                    txt_Sonuc.Text = (sonuc + double.Parse(txt_Sonuc.Text)).ToString();
                    break;
                case "-":
                    txt_Sonuc.Text = (sonuc - double.Parse(txt_Sonuc.Text)).ToString();
                    break;
                case "*":
                    txt_Sonuc.Text = (sonuc * double.Parse(txt_Sonuc.Text)).ToString();
                    break;
                case "/":
                    txt_Sonuc.Text = (sonuc / double.Parse(txt_Sonuc.Text)).ToString();
                    break;
            }
            sonuc = double.Parse(txt_Sonuc.Text);
            txt_Sonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void btn_Virgul_Click(object sender, EventArgs e)
        {
            if (txt_Sonuc.Text=="0")
            {
                txt_Sonuc.Text="0";
            }else if (durum)
            {
                txt_Sonuc.Text = "0";
            }

            if (!txt_Sonuc.Text.Contains(","))
            {
                txt_Sonuc.Text += ",";
            }
            durum = false;
        }
    }
}
