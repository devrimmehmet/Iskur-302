using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Örnek alma
        Random rnd = new Random();
        int tutulanSayi;
        int tahminHakki=5;
        int seviye = 1;
        int seviyeCarpan = 10;

        private void Form1_Load(object sender, EventArgs e)
        {
            tutulanSayi = rnd.Next(1, 11);
            this.Text = tutulanSayi.ToString();


        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            // int tahminEdilenSayi = Convert.ToInt32(txtTahmin.Text);

            try
            {
                int tahminEdilenSayi = int.Parse(txtTahmin.Text);
                if (tahminEdilenSayi > 0)
                {
                    if (tahminHakki > 0)
                    {
                        if (tahminEdilenSayi == tutulanSayi)
                        {
                            MessageBox.Show("Tebrikler! Doğru Tahmin!");
                            seviye++;
                            lblSeviye.Text = seviye.ToString();
                            lblTahminHakki.Text = tahminHakki.ToString();
                            tutulanSayi = rnd.Next(1, seviye*seviyeCarpan+1);
                            this.Text = tutulanSayi.ToString();
                        }
                        else if (tahminEdilenSayi < tutulanSayi)
                        {
                            lblSonuc.Text = "daha büyük bir sayı girin";
                            tahminHakki--;
                            lblTahminHakki.Text = tahminHakki.ToString();

                        }
                        else
                        {
                            lblSonuc.Text = "daha küçük bir sayı girin";
                            tahminHakki--;
                            lblTahminHakki.Text = tahminHakki.ToString();
                        }

                    }
                    else
                    {
                        if (tahminHakki == 0)
                        {
                            //MessageBox.Show("tahmin hakkınız olmadığı için kasadan jeton alın");

                            DialogResult dr=MessageBox.Show("Tahmin Hakkınız Bitti!", "Oyun Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (dr == DialogResult.Yes)
                            {
                                seviye =1;
                                lblSeviye.Text = seviye.ToString();
                                tahminHakki = 5;
                                lblTahminHakki.Text = tahminHakki.ToString();
                                tutulanSayi = rnd.Next(1, seviye * seviyeCarpan + 1);
                                this.Text = tutulanSayi.ToString();
                                lblSonuc.Text = "";

                            }
                            else
                            {
                                Application.Exit();
                            }
                           
                           

                            btnTahminEt.Enabled = false;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen 0'dan büyük bir sayı girin");
                }
            }
            catch
            {

                MessageBox.Show("Bir hata meydana geldi");
            }

        }
    }
}
