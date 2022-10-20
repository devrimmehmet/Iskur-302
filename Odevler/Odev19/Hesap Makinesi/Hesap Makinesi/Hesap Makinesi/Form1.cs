using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        bool islem = false;
        double sonuc = 0;
        string islemString = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Salih(KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 8 && e.KeyChar != 13)
            {

            }
            else
            {
                if (e.KeyChar == '0')
                {
                    Rakam_Olay(btn_0, new EventArgs());    
                }
                if (e.KeyChar == '1')
                {
                    Rakam_Olay(btn_1, new EventArgs());
                }
                if (e.KeyChar == '2')
                {
                    Rakam_Olay(btn_2, new EventArgs());
                }
                if (e.KeyChar == '3')
                {
                    Rakam_Olay(btn_3, new EventArgs());
                }
                if (e.KeyChar == '4')
                {
                    Rakam_Olay(btn_4, new EventArgs());
                }
                if (e.KeyChar == '5')
                {
                    Rakam_Olay(btn_5, new EventArgs());
                }
                if (e.KeyChar == '6')
                {
                    Rakam_Olay(btn_6, new EventArgs());
                }
                if (e.KeyChar == '7')
                {
                    Rakam_Olay(btn_7, new EventArgs());
                }
                if (e.KeyChar == '8')
                {
                    Rakam_Olay(btn_8, new EventArgs());
                }
                if (e.KeyChar == '9')
                {
                    Rakam_Olay(btn_9, new EventArgs());
                }
                if (e.KeyChar == ',')
                {
                    btn_Virgul_Click(btn_Virgul, new EventArgs());
                }
                if (e.KeyChar == '+')
                {
                    Islem_Yap(btn_Toplama, new EventArgs());
                }
                if (e.KeyChar == '-')
                {
                    Islem_Yap(btn_Cikarma, new EventArgs());
                }
                if (e.KeyChar == '*')
                {
                    Islem_Yap(btn_Carpma, new EventArgs());
                }
                if (e.KeyChar == '/')
                {
                    Islem_Yap(btn_Bolme, new EventArgs());
                }
                if (e.KeyChar == 13) //enter
                {
                    btn_Esittir_Click(btn_Esittir, new EventArgs());
                }
                if (e.KeyChar == 8) //backspace
                {
                    btn_Geri_Click(btn_Geri, new EventArgs());
                }

            }
        }
        private void Rakam_Olay(object sender, EventArgs e)
        {
            if (txt_Sonuc.Text=="0" || islem)
            {
                txt_Sonuc.Clear();
            }
            islem = false;
            Button btn = (Button)sender;
            txt_Sonuc.Text += btn.Text;
        }

        private void Islem_Yap(object sender, EventArgs e)
        {
            islem = true;
            Button btn= (Button)sender;
            string yeniIslem = btn.Text;
            lbl_Sonuc.Text = lbl_Sonuc.Text  + txt_Sonuc.Text + yeniIslem;
            switch (islemString)
            {
                case "+":
                    txt_Sonuc.Text =((sonuc+double.Parse(txt_Sonuc.Text)).ToString());
                    break;
                case "-":
                    txt_Sonuc.Text = ((sonuc - double.Parse(txt_Sonuc.Text)).ToString());
                    break;
                case "*":
                    txt_Sonuc.Text = ((sonuc * double.Parse(txt_Sonuc.Text)).ToString());
                    break;
                case "/":
                    txt_Sonuc.Text = ((sonuc / double.Parse(txt_Sonuc.Text)).ToString());
                    break;
            }
            sonuc=double.Parse(txt_Sonuc.Text);
            txt_Sonuc.Text = sonuc.ToString();
            islemString = yeniIslem;
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Text = "0";
            lbl_Sonuc.Text = "";
            islemString = "";
            sonuc = 0;
            islem = false;
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Text = "0";
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {
            lbl_Sonuc.Text = "";
            islem = true;
            switch (islemString)
            {
                case "+":
                    txt_Sonuc.Text = ((sonuc + double.Parse(txt_Sonuc.Text)).ToString());
                    break;
                case "-":
                    txt_Sonuc.Text = ((sonuc - double.Parse(txt_Sonuc.Text)).ToString());
                    break;
                case "*":
                    txt_Sonuc.Text = ((sonuc * double.Parse(txt_Sonuc.Text)).ToString());
                    break;
                case "/":
                    txt_Sonuc.Text = ((sonuc / double.Parse(txt_Sonuc.Text)).ToString());
                    break;
            }
            sonuc=double.Parse(txt_Sonuc.Text);
            txt_Sonuc.Text = sonuc.ToString();
            islemString = "";
        }

        private void btn_Virgul_Click(object sender, EventArgs e)
        {
            if (txt_Sonuc.Text=="0")
            {
                txt_Sonuc.Text = "0";
            }
            else if(islem==true)
            {
                txt_Sonuc.Text = "0";
            }

            if (!txt_Sonuc.Text.Contains(","))
            {
                txt_Sonuc.Text += ",";
            }
            islem = false;
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Text = txt_Sonuc.Text.Remove(txt_Sonuc.Text.Length - 1);
           
            if (txt_Sonuc.Text == "")
            {
                txt_Sonuc.Text = " ";
            }
        }

        private void btn_CE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Salih(e);
        }
    }
}
