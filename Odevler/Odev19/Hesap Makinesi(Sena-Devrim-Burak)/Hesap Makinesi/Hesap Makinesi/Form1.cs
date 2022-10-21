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
        bool bool_Islem = false;
        double sonuc = 0;
        string string_Islem = "", string_Islem2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Rakam(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            btn_Islem_Aktif();
            if (txt_Sonuc.Text == "0" || bool_Islem)
            {
                txt_Sonuc.Clear();
            }
            bool_Islem = false;
            Button btn = (Button)sender;
            txt_Sonuc.Text += btn.Text;
        }
        private void IslemSecimi()
        {
            if (btn_Bolme.Enabled == true && btn_Carpma.Enabled == true && btn_Toplama.Enabled == true && btn_Cikarma.Enabled == true)
            {

            }
            else
            {
                sonuc = Convert.ToDouble(txt_Sonuc.Text);
                MessageBox.Show("girdim");
            }

            if (string_Islem == "+")
            {
                btn_Islem_Aktif();
                btn_Toplama.Enabled = false;

            }
            if (string_Islem == "-")
            {
                btn_Islem_Aktif();
                btn_Cikarma.Enabled = false;
            }
            if (string_Islem == "*")
            {
                btn_Islem_Aktif();
                btn_Carpma.Enabled = false;

            }
            if (string_Islem == "/")
            {
                btn_Islem_Aktif();
                btn_Bolme.Enabled = false;

            }
            switch (string_Islem)
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
          

            sonuc = Convert.ToDouble(txt_Sonuc.Text);
            lbl_Sonuc.Text = sonuc.ToString();

            btn_Esittir.Select();
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
            btn_Esittir.Select();
            bool_Islem = true;
            Button btn = (Button)sender;
            
            string yeni_String_Islem = btn.Text;
            //  lbl_Sonuc.Text = lbl_Sonuc.Text + " " + txt_Sonuc.Text + " "+yeni_String_Islem;

            IslemSecimi();
            lbl_Sonuc.Text = txt_Sonuc.Text + " " + yeni_String_Islem;
            //txt_Sonuc.Text = lbl_Sonuc.Text + yeni_String_Islem;
            string_Islem = yeni_String_Islem;
        }
        private void btn_Islem_Aktif()
        {
            btn_Esittir.Select();
            btn_Toplama.Enabled = true;
            btn_Carpma.Enabled = true;
            btn_Bolme.Enabled = true;
            btn_Cikarma.Enabled = true;
        }
        private void btn_CE_Click(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            btn_Islem_Aktif();
            txt_Sonuc.Text = "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            txt_Sonuc.Text = "0";
            lbl_Sonuc.Text = "";
            string_Islem = "";
            sonuc = 0;
            bool_Islem = false;
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            lbl_Sonuc.Text = "";
            bool_Islem = true;
            IslemSecimi();
            string_Islem = "";
        }

        private void btn_Virgul_Click(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            if (txt_Sonuc.Text == "0")
            {
                txt_Sonuc.Text = "0";
            }
            else if (bool_Islem)
            {
                txt_Sonuc.Text = "0";
            }
            if (!txt_Sonuc.Text.Contains(","))
            {
                txt_Sonuc.Text += ",";
            }
            bool_Islem = false;
        }

        private void KeyPressforAllButtons(object sender, KeyPressEventArgs e)
        {
            btn_Esittir.Select();
            Salih(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            txt_Sonuc.Text = "0";
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            btn_Esittir.Select();
            btn_Islem_Aktif();
            txt_Sonuc.Text = txt_Sonuc.Text.Remove(txt_Sonuc.Text.Length - 1);

            if (txt_Sonuc.Text == "")
            {
                txt_Sonuc.Text = "0";
            }
            //  btn0.KeyPress += new KeyPressEventHandler(btnartı_KeyPress);
        }
    }
}
