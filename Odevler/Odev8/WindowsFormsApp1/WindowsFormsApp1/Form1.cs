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
    public partial class Form1 : Form
    {
        public string secim = "";
        public double a,b,c,s, alan, cevre;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_verigirisi.Visible = false;
            pnl_sonuc.Visible = false;
           
        }

        private void btn_kare_Click(object sender, EventArgs e)
        {
            lbl_hosgeldiniz.Visible = false;
            pnl_verigirisi.Visible = true;
            pnl_sonuc.Visible = false;
            tB_b.Visible = false;
            lbl_b.Visible = false;
            tB_c.Visible = false;
            lbl_c.Visible = false;
            tB_a.Text = "";
            lbl_a.Text = "Karenin Bir Kenarının Uzunluğunu Giriniz";
            lbl_baslik.Text = "Kare";
            tB_a.Enabled = true;
            secim = "Kare";
            
        }

        private void tB_b_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tB_c_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_daire_Click(object sender, EventArgs e)
        {
            lbl_hosgeldiniz.Visible = false;
            pnl_verigirisi.Visible = true;
            pnl_sonuc.Visible = false;
            tB_b.Visible = false;
            lbl_b.Visible = false;
            tB_c.Visible = false;
            lbl_c.Visible = false;
            tB_a.Text = "";
            tB_b.Text = "";
            tB_c.Text = "";
            lbl_a.Text = "Dairenin Yarıçapını Giriniz";
            lbl_b.Text = "Üçgenin İkinci Kenarını Giriniz";
            lbl_c.Text = "Üçgenin Üçüncü Kenarını Giriniz";
            lbl_baslik.Text = "Daire";
            tB_a.Enabled = true;
            tB_b.Enabled = true;
            tB_c.Enabled = true;
            secim = "Daire";
        }

        private void tB_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_ucgen_Click(object sender, EventArgs e)
        {
            lbl_hosgeldiniz.Visible = false;
            pnl_verigirisi.Visible = true;
            pnl_sonuc.Visible = false;
            tB_b.Visible = true;
            lbl_b.Visible = true;
            tB_c.Visible = true;
            lbl_c.Visible = true;
            tB_a.Text = "";
            tB_b.Text = "";
            tB_c.Text = "";
            lbl_a.Text = "Üçgenin Birinci Kenarını Giriniz";
            lbl_b.Text = "Üçgenin İkinci Kenarını Giriniz";
            lbl_c.Text = "Üçgenin Üçüncü Kenarını Giriniz";
            lbl_baslik.Text = "Üçgen";
            tB_a.Enabled = true;
            tB_b.Enabled = true;
            tB_c.Enabled = true;
            secim = "Üçgen";
        }

        private void btn_dikdortgen_Click(object sender, EventArgs e)
        {
            lbl_hosgeldiniz.Visible = false;
            pnl_verigirisi.Visible = true;
            pnl_sonuc.Visible = false;
            tB_b.Visible = true;
            lbl_b.Visible = true;
            tB_c.Visible = false;
            lbl_c.Visible = false;
            tB_a.Text = "";
            tB_b.Text = "";
            lbl_a.Text = "Dikdörtgenin Kısa Kenarını Giriniz";
            lbl_b.Text= "Dikdörtgenin Uzun Kenarını Giriniz";
            lbl_baslik.Text = "Dikdörtgen";
            tB_a.Enabled = true;
            tB_b.Enabled = true;
            secim = "Dikdörtgen";
        }

        private void tB_a_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            /* bir faktöryel   
             * asal say
             * toplama işlemi
             * dizi // params   
             * tek çift olayı
             * // hepsi metotlu olacak 
             * */
            



            switch (secim)
            {
                case "Kare":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        cevre = a * 4;
                        alan = a * a;
                        lbl_cevre_yazdir.Text = cevre.ToString();
                        lbl_alan_yazdir.Text = alan.ToString();
                        pnl_sonuc.Visible = true;
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                        tB_c.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veri Giriniz.");
                    }
                   
                    
                    break;
                
                case "Dikdörtgen":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        b = int.Parse(tB_b.Text);
                        cevre = (a + b)*2;
                        alan = a * b;
                        lbl_cevre_yazdir.Text = cevre.ToString();
                        lbl_alan_yazdir.Text = alan.ToString();
                        pnl_sonuc.Visible = true;
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                        tB_c.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veri Giriniz.");
                    }
                    break;
                case "Üçgen":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        b = int.Parse(tB_b.Text);
                        c = int.Parse(tB_c.Text);
                        cevre = a+b+c;
                        s = (a + b + c) / 2;
                        if ((s * (s - a) * (s - b) * (s - c))<0)
                        {
                            alan = Math.Sqrt((s * (s - a) * (s - b) * (s - c)*-1));
                        }
                        else
                        {
                            alan = Math.Sqrt((s * (s - a) * (s - b) * (s - c)));
                        }
                        
                        lbl_cevre_yazdir.Text = cevre.ToString();
                        lbl_alan_yazdir.Text = alan.ToString();
                        pnl_sonuc.Visible = true;
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                        tB_c.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veri Giriniz.");
                    }

                    break;
                case "Daire":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        cevre = 2*Math.PI*a;
                        alan = Math.PI*a*a;
                        lbl_cevre_yazdir.Text = cevre.ToString();
                        lbl_alan_yazdir.Text = alan.ToString();
                        pnl_sonuc.Visible = true;
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                        tB_c.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veri Giriniz.");
                    }

                    break;
                default:
                    break;
            }
        }
    }
}
