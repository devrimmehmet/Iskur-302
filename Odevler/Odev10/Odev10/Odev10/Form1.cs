using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Odev10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kasa kasa = new Kasa();
        GunSonuForm gunSonuForm = new GunSonuForm();

        private void Form1_Load(object sender, EventArgs e)
        {
          
            kasa.kolaFiyat = 15;
            kasa.cayFiyat = 7;
            kasa.limonataFiyat = 10;
            kasa.suFiyat = 5;
            kasa.kasaToplam = 0;
            kasa.siparisToplam = 0;
            lbl_siparis.Text = kasa.siparisToplam.ToString();
            lbl_total.Text = kasa.kasaToplam.ToString();
            coB_Kola.Enabled = false;
            coB_cay.Enabled = false;
            coB_limonata.Enabled = false;
            coB_su.Enabled = false;
        }

        private void coB_Kola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cB_kola_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_kola.Checked==true)
            {
                coB_Kola.Items.Remove("");
                coB_Kola.SelectedIndex = 0;
                coB_Kola.Enabled = true;
                
            }
            else
            {
                coB_Kola.Items.Add("");
                coB_Kola.SelectedIndex=(10);
                kasa.siparisToplam = 0;
                lbl_siparis.Text=kasa.siparisToplam.ToString();
                coB_Kola.Enabled = false;
            }
        }

        private void cB_Limonata_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Limonata.Checked == true)
            {
                coB_limonata.Items.Remove("");
                coB_limonata.SelectedIndex = 0;
                coB_limonata.Enabled = true;

            }
            else
            {
                coB_limonata.Items.Add("");
                coB_limonata.SelectedIndex = (10);
                kasa.siparisToplam = 0;
                lbl_siparis.Text = kasa.siparisToplam.ToString();
                coB_limonata.Enabled = false;
            }
        }

        private void cB_cay_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_cay.Checked == true)
            {
                coB_cay.Items.Remove("");
                coB_cay.SelectedIndex = 0;
                coB_cay.Enabled = true;

            }
            else
            {
                coB_cay.Items.Add("");
                coB_cay.SelectedIndex = (10);
                kasa.siparisToplam = 0;
                lbl_siparis.Text = kasa.siparisToplam.ToString();
                coB_cay.Enabled = false;
            }
        }

        private void cB_Su_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_Su.Checked == true)
            {
                coB_su.Items.Remove("");
                coB_su.SelectedIndex = 0;
                coB_su.Enabled = true;

            }
            else
            {
                coB_su.Items.Add("");
                coB_su.SelectedIndex = (10);
                kasa.siparisToplam = 0;
                lbl_siparis.Text = kasa.siparisToplam.ToString();
                coB_su.Enabled = false;
            }
        }

        private void btn_Hesapla_Click(object sender, EventArgs e)
        {
            kasa.siparisToplam = 0;
            if (cB_kola.Checked == true)
            {
              kasa.kolaAdet=Convert.ToDouble(coB_Kola.Text);
              kasa.siparisToplam = kasa.siparisToplam+( kasa.kolaAdet * kasa.kolaFiyat);
            }
            if (cB_cay.Checked == true)
            {
                kasa.cayAdet = Convert.ToDouble(coB_cay.Text);
                kasa.siparisToplam = kasa.siparisToplam + (kasa.cayAdet * kasa.cayFiyat);
            }
            if (cB_Limonata.Checked == true)
            {
                kasa.limonataAdet = Convert.ToDouble(coB_limonata.Text);
                kasa.siparisToplam = kasa.siparisToplam + (kasa.limonataAdet * kasa.limonataFiyat);
            }
            if (cB_Su.Checked == true)
            {
                kasa.suAdet = Convert.ToDouble(coB_su.Text);
                kasa.siparisToplam = kasa.siparisToplam + (kasa.suAdet * kasa.suFiyat);
            }

            lbl_siparis.Text=kasa.siparisToplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kasa.siparisToplam!=0)
            {
                gunSonuForm.listBox1.Items.Add($"{gunSonuForm.listBox1.Items.Count + 1} - {DateTime.Now} - Sipariş Toplamı: {kasa.siparisToplam} TL - Kola {kasa.kolaAdet} adet - Limonata {kasa.limonataAdet} adet - Çay {kasa.cayAdet} adet - Su {kasa.suAdet} adet.");
            }
           
            kasa.kasaToplam += kasa.siparisToplam;
            kasa.siparisToplam = 0;
            kasa.kolaAdet = 0;
            kasa.limonataAdet = 0;
            kasa.cayAdet = 0;
            kasa.suAdet = 0;
            cB_cay.Checked = false;
            cB_kola.Checked = false;
            cB_Limonata.Checked = false;
            cB_Su.Checked = false;
            lbl_siparis.Text=kasa.siparisToplam.ToString();
            lbl_total.Text = kasa.kasaToplam.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Gün Sonu Kasa Toplam Ciro: {kasa.kasaToplam.ToString()} TL");
            gunSonuForm.lbl_total.Text=kasa.kasaToplam.ToString();
            kasa.kasaToplam = 0;
        }

        private void coB_Kola_SelectedValueChanged(object sender, EventArgs e)
        {
            coB_Kola.Enabled = false;
        }

        private void coB_limonata_SelectedValueChanged(object sender, EventArgs e)
        {
            coB_limonata.Enabled = false;
        }

        private void coB_cay_SelectedValueChanged(object sender, EventArgs e)
        {
            coB_cay.Enabled = false;
        }

        private void coB_su_SelectedValueChanged(object sender, EventArgs e)
        {
            coB_su.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gunSonuForm.Show();
          //  gunSonuForm.listBox1.Items.Clear();
        }
    }
}
