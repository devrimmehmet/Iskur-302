using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string mevsim = txtMevsim.Text.ToLower();

            #region If-else
            //if (mevsim == "kış")
            //{
            //    MessageBox.Show("Aralık-Ocak-Şubat");
            //}
            //else if (mevsim == "ilkbahar")
            //{
            //    MessageBox.Show("Mart-Nisan-Mayıs");
            //}
            //else if (mevsim == "yaz")
            //{
            //    MessageBox.Show("Haziran-Temmuz-Ağustos");
            //}
            //else if (mevsim == "sonbahar")
            //{
            //    MessageBox.Show("Eylül-Ekim-Kasım");
            //}
            //else
            //{
            //    MessageBox.Show("Böyle bir mevsim duymadım!");
            //} 
            #endregion

            switch (mevsim)//kış
            {
                case "kış":
                    MessageBox.Show("Aralık-Ocak-Şubat");
                    break;
                case "ilkabahar":
                    MessageBox.Show("Mart-Nisan-Mayıs");
                    break;
                case "yaz":
                    MessageBox.Show("Haziran-Temmuz-Ağustos");
                    break;
                case "sonbahar":
                    MessageBox.Show("Eylül-Ekim-Kasım");
                    break;
            }

        }

        private void btnRolGetir_Click(object sender, EventArgs e)
        {
            //Eğer textbopx'a "Admin","Moderatör","Yönetici","Ceo","Başkan" girilirse "Yönetim paneline yönlendiriliyorsunuz",
            //"üye" girilirse "anasayfaya yönlendiriliyorsunuz"
            //harici bir değer girildiğinde "bu sayfayı görüntülemeye yetkiniz yok" mesajını kullanıcıya gösterin.

            string deger = txtRol.Text.ToLower();
            string mesaj = "";

            #region If-Else
            //if (deger == "admin" || deger == "moderatör" || deger == "yönetici" || deger == "ceo" || deger == "başkan")
            //{
            //    mesaj = "Yönetim paneline yönlendiriliyorsunuz";
            //}
            //else if (deger == "üye")
            //{
            //    mesaj = "anasayfaya yönlendiriliyorsunuz";
            //}
            //else
            //{
            //    mesaj = "bu sayfayı görüntülemeye yetkiniz yok";
            //} 
            #endregion

            switch (deger)
            {
                case "admin":
                case "moderatör":
                case "yönetici":
                case "ceo":
                case "başkan":
                    mesaj = "Yönetim paneline yönlendiriliyorsunuz";
                    break;
                case "üye":
                    mesaj = "anasayfaya yönlendiriliyorsunuz";
                    break;
                default:
                    mesaj = "bu sayfayı görüntülemeye yetkiniz yok";
                    break;


            }

            MessageBox.Show(mesaj);

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //kullanıcı adı: "bilgeadam"
            //şifre:1234

            //Eğer kullanıcı txtKullaniciAdina girmiş olduğu değer "bilgeadam" ve txtSfire'ye girilen değer 1234 ise "Tebrikler hem kullanıcı adı hem de şifre doğru",
            //kullanıcı adı doğru şifre yanlışsa "kullanıcı adınız doğru şifreniz yanlış",
            //kullanıcı adı yanlışsa "kullanıcı adınız yanlış, şifreye bakmadım bile" uyarısını kullanıcıya verin.
        }
    }
}
