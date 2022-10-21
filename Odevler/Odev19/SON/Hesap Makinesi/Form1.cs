using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        string string_Islem = "";
        double sayim = 0;
        bool durum = true;


        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Rakam(object sender, EventArgs e)
        {
            
            if (durum==false)
            {
                txt_Sonuc.Clear();
                lbl_Sonuc.Text = "";
            }
            durum = true;
            
                Button btn = (Button)sender;
                txt_Sonuc.Text += btn.Text;
            
        }

        private void Salih(KeyPressEventArgs e)
        {
            btn_Esittir.Select();
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 8 && e.KeyChar != 13)
            {

            }
            else
            {

                if (e.KeyChar == '0')
                {
                    Click_Rakam(btn_0, new EventArgs());

                }
                if (e.KeyChar == '1')
                {
                    Click_Rakam(btn_1, new EventArgs());

                }
                if (e.KeyChar == '2')
                {
                    Click_Rakam(btn_2, new EventArgs());

                }
                if (e.KeyChar == '3')
                {
                    Click_Rakam(btn_3, new EventArgs());

                }
                if (e.KeyChar == '4')
                {
                    Click_Rakam(btn_4, new EventArgs());

                }
                if (e.KeyChar == '5')
                {
                    Click_Rakam(btn_5, new EventArgs());

                }
                if (e.KeyChar == '6')
                {
                    Click_Rakam(btn_6, new EventArgs());

                }
                if (e.KeyChar == '7')
                {
                    Click_Rakam(btn_7, new EventArgs());

                }
                if (e.KeyChar == '8')
                {
                    Click_Rakam(btn_8, new EventArgs());

                }
                if (e.KeyChar == '9')
                {
                    Click_Rakam(btn_9, new EventArgs());

                }
                if (e.KeyChar == ',')
                {
                    btn_Virgul_Click(btn_Virgul, new EventArgs());

                }
                if (e.KeyChar == '+')
                {
                    Click_Islem(btn_Toplama, new EventArgs());

                }
                if (e.KeyChar == '-')
                {
                    Click_Islem(btn_Cikarma, new EventArgs());


                }
                if (e.KeyChar == '*')
                {
                    Click_Islem(btn_Carpma, new EventArgs());


                }
                if (e.KeyChar == '/')
                {
                    Click_Islem(btn_Bolme, new EventArgs());

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
        private void Click_Islem(object sender, EventArgs e)
        {
            durum = true;
            Button btn = (Button)sender;
            
            metot();
            string_Islem = btn.Text;
            lbl_Sonuc.Text = " " + sayim.ToString() + " " + string_Islem;
            txt_Sonuc.Clear();
        }
        public double metot()
        {
            if (txt_Sonuc.Text == "" || txt_Sonuc.Text == null || txt_Sonuc.Text == string.Empty)
            {
                switch (string_Islem)
                {
                    case "+": sayim += 0; break;
                    case "-": sayim -= 0; break;
                    case "*": sayim *= sayim; break;
                    case "/": sayim /= sayim; break;
                    default: sayim = 0; break;
                }
            }
            else
            {
                switch (string_Islem)
                {
                    case "+": sayim += double.Parse(txt_Sonuc.Text); break;
                    case "-": sayim -= double.Parse(txt_Sonuc.Text); break;
                    case "*": sayim *= double.Parse(txt_Sonuc.Text); break;
                    case "/": sayim /= double.Parse(txt_Sonuc.Text); break;
                    default: sayim = double.Parse(txt_Sonuc.Text); break;
                }
            }
            return sayim;
        }
        private void btn_Islem_Aktif()
        {

        }
        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Clear();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txt_Sonuc.Clear();
            sayim = 0;
            string_Islem = "";
            lbl_Sonuc.Text = "";
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {

            if (txt_Sonuc.Text == "" ||  txt_Sonuc.Text == null  || txt_Sonuc.Text == string.Empty)
            {
                if (durum)
                {
                    lbl_Sonuc.Text += txt_Sonuc.Text + lbl_Sonuc.Text.Remove(3) + " =";
                    durum = false;
                }
            }
            else
            {
                if (durum)
                {
                    lbl_Sonuc.Text += " " + txt_Sonuc.Text + "  " + " = ";
                    durum = false;
                }
            }
            txt_Sonuc.Text = metot().ToString();
            string_Islem = "";

        }

        private void btn_Virgul_Click(object sender, EventArgs e)
        {
            if (!txt_Sonuc.Text.Contains(","))
            {
                txt_Sonuc.Text += ",";
                btn_0.Enabled = true;
            }
            durum = true;
        }

        private void KeyPressforAllButtons(object sender, KeyPressEventArgs e)
        {
            btn_Esittir.Select();
            Salih(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            if (txt_Sonuc.Text != "" || txt_Sonuc.Text != string.Empty || txt_Sonuc.Text != null)
            {
                if ((txt_Sonuc.Text).Length > 0)
                {
                    txt_Sonuc.Text = txt_Sonuc.Text.Remove(txt_Sonuc.Text.Length - 1, 1);
                }
            }
        }
    }
}
