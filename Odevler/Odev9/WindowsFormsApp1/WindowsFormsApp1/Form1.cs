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
        public double a, b, c, s, toplama;
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
           Form2 frm2 = new Form2();
        frm2.Show();
            
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
          //  tB_c.Visible = false;
            //lbl_c.Visible = false;
            tB_a.Text = "";
            tB_b.Text = "";
         //   tB_c.Text = "";
            lbl_a.Text = "Bir Sayı Giriniz.";
            lbl_b.Text = "Üçgenin İkinci Kenarını Giriniz";
        //    lbl_c.Text = "Üçgenin Üçüncü Kenarını Giriniz";
            lbl_baslik.Text = "";
            tB_a.Enabled = true;
            tB_b.Enabled = true;
        //    tB_c.Enabled = true;
            secim = "Asal-Faktoryel-TekCift";
        }

        private void tB_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void btn_dikdortgen_Click(object sender, EventArgs e)
        {
            lbl_hosgeldiniz.Visible = false;
            pnl_verigirisi.Visible = true;
            pnl_sonuc.Visible = false;
            tB_b.Visible = true;
            lbl_b.Visible = true;
        //    tB_c.Visible = false;
            //lbl_c.Visible = false;
            tB_a.Text = "";
            tB_b.Text = "";
            lbl_a.Text = "Birinci Sayıyı Giriniz";
            lbl_b.Text= "İkinci Sayıyı Giriniz";
            lbl_baslik.Text = "Toplama";
            lbl_cevre.Text = "Toplam";
            
            lbl_alan.Text = "";
            lbl_alan_yazdir.Text = "";
            tB_a.Enabled = true;
            tB_b.Enabled = true;
            secim = "Toplama";
        }

        private void tB_a_TextChanged(object sender, EventArgs e)
        {
            
        }
        string tekCift(double sayi)
        {
            string sonuc = "Tek";
            if (sayi%2==0)
            {
                sonuc = "Çift";
            }
            return sonuc;
        }
        string Asal(double sayi)
        {
            string sonuc = "Asal";
            int sayac = 0;
            for (int i = 1; i <= sayi; i++)
            {
               if(sayi % i == 0)
                {
                    sayac++;
                }
            }
           if(sayac > 2)
            {
                 sonuc = "Değil";
            }



                return sonuc;

        }

        int Faktoryel(double sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
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
                case "Dizi":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        pnl_sonuc.Visible = true;
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                       
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veri Giriniz.");
                    }
                   
                    
                    break;
                
                case "Toplama":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        b = int.Parse(tB_b.Text);
                        toplama = a + b;
                        lbl_cevre_yazdir.Text = toplama.ToString();
                        lbl_cevre.Text = "Toplam";
                     
                        pnl_sonuc.Visible = true;
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                        lbl_sonuc3baslik.Text = "";
                        lbl_sonuc3.Text = "";
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Veri Giriniz.");
                    }
                    break;
               
                case "Asal-Faktoryel-TekCift":
                    try
                    {
                        a = int.Parse(tB_a.Text);
                        pnl_sonuc.Visible = true;
                        lbl_sonuc3baslik.Text = "Tek - Çift";
                        lbl_cevre.Text = "Faktöryeli";
                        lbl_alan.Text = "Asal Mı?";
                        

                        lbl_alan_yazdir.Text = Asal(a);
                        lbl_sonuc3.Text = tekCift(a);
                        lbl_cevre_yazdir.Text = Faktoryel(a).ToString();
                        tB_a.Enabled = false;
                        tB_b.Enabled = false;
                       
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

