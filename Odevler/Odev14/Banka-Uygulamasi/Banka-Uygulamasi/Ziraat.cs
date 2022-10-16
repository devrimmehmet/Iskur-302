using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulamasi
{
    public partial class Ziraat : Form
    {
        public Ziraat()
        {
            InitializeComponent();
        }
       
        Kredi kredi = new Kredi();
       
        private void btn_KrediCekmeHesaplama_Click(object sender, EventArgs e)
        {
            btn_KrediOnayla.Visible = true;
            lB_krediCekme.Items.Clear();

            kredi.CekilenKredi=Convert.ToDouble(tB_KrediCekme.Text);
            kredi.taksitSayisi = Convert.ToDouble(cB_TaksitSayisi.Text);
            kredi.BireyselKrediCekme();
            lB_krediCekme.Items.Add("Çekilecek Kredi : "+ Math.Round(kredi.CekilenKredi, 5) + " TL");
            lB_krediCekme.Items.Add("Ödenecek Toplam Faiz : " +Math.Round( kredi.FaizHesaplama,5) + " TL");
            lB_krediCekme.Items.Add("Toplam Taksit Sayısı : " + kredi.taksitSayisi );
            lB_krediCekme.Items.Add("Aylık Ödeme Miktarı : " + Math.Round(kredi.AylıkOdeme, 5) + " TL");
            lB_krediCekme.Items.Add("--------------------------------------------------------------------------");
            lB_krediCekme.Items.Add("--------------------------ÖDEME PLANI---------------------------");
            double anaPara = kredi.CekilenKredi;
            double faiz = 0;
            string[] krediKapatmaMesajı = new string[(int)kredi.taksitSayisi]; 
            string[] krediKapatmaMesajı1 = new string[(int)kredi.taksitSayisi];
            string[] krediKapatmaMesajı2 = new string[(int)kredi.taksitSayisi];
            for (int i = 0; i < kredi.taksitSayisi; i++)
            {
                double usluSayi1 = Math.Pow((1 + kredi.FaizOranı), (kredi.taksitSayisi - i));
                double usluSayi2 = Math.Pow((1 + kredi.FaizOranı), (kredi.taksitSayisi - i - 1));
                double odenenFaiz1 = (kredi.CekilenKredi * usluSayi1) - kredi.CekilenKredi;
                double odenenFaiz2 = (kredi.CekilenKredi * usluSayi2) - kredi.CekilenKredi;
               double faizkapatma = odenenFaiz1 - odenenFaiz2;
                anaPara -= (kredi.AylıkOdeme - faizkapatma);
                faiz += faizkapatma;
              
                krediKapatmaMesajı[i] = $"{i + 1}.ay Ödenen Toplam Faiz {Math.Round(faiz, 5)} TL";
                krediKapatmaMesajı1[i] = $"{i + 1}.ay Toplam Ödenen Ana Para: {Math.Round((kredi.CekilenKredi - anaPara), 5)} TL";
             
                lB_krediCekme.Items.Add(krediKapatmaMesajı[i]);
                lB_krediCekme.Items.Add(krediKapatmaMesajı1[i]);
                lB_krediCekme.Items.Add("");
            }
        }

        private void Ziraat_Load(object sender, EventArgs e)
        {
            cB_TaksitSayisi.SelectedItem = "12";
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show($"Kredi çekme işlemini onaylamak istiyor musunuz?\n\nÇekilecek Kredi :{Math.Round(kredi.CekilenKredi, 5)} TL\n\nÖdenecek Toplam Faiz : {Math.Round(kredi.FaizHesaplama, 5)} TL\n\nToplam Taksit Sayısı :  {kredi.taksitSayisi}\n\nAylık Ödeme Miktarı : {Math.Round(kredi.AylıkOdeme, 5)} TL\n\nGeri Ödenecek Toplam Miktar: {Math.Round( (kredi.CekilenKredi+kredi.FaizHesaplama),5)} TL", "Kredi Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            

            if (secenek == DialogResult.Yes)
            {
                MessageBox.Show("Krediniz Onaylandı Paranızı Çekebilirsiniz.");
               
            }
            else if (secenek == DialogResult.No)
            {
                lB_krediCekme.Items.Clear();
                btn_KrediOnayla.Visible = false;
            }
        }

        private void tB_KrediCekme_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lB_krediCekme.Items.Clear();
            btn_KrediOnayla.Visible = false;
            pnl_krediCekme.Visible = true;
            pnl_krediKapatma.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lB_KrediKapatma.Items.Clear();
            btn_krediKapatmaOnay.Visible = false;
            pnl_krediCekme.Visible = false;
            pnl_krediKapatma.Visible = true;
        }

        private void btn_hesaplaKrediKapatma_Click(object sender, EventArgs e)
        {
            btn_krediKapatmaOnay.Visible = true;
            
            kredi.OdenenTaksitSayisi = Convert.ToDouble(cB_odenenTaksit.Text);


            string[] krediKapatmaMesajı3 = new string[(int)kredi.taksitSayisi];
            double faiz1 = 0;
            for (int i = 0; i < kredi.OdenenTaksitSayisi; i++)
            {
                double usluSayi1 = Math.Pow((1 + kredi.FaizOranı), (kredi.taksitSayisi - i));
                double usluSayi2 = Math.Pow((1 + kredi.FaizOranı), (kredi.taksitSayisi - i - 1));
                double odenenFaiz1 = (kredi.CekilenKredi * usluSayi1) - kredi.CekilenKredi;
                double odenenFaiz2 = (kredi.CekilenKredi * usluSayi2) - kredi.CekilenKredi;
                kredi.faizkapatma = odenenFaiz1 - odenenFaiz2;
                kredi.anaPara -= (kredi.AylıkOdeme - kredi.faizkapatma);
                faiz1 += kredi.faizkapatma;
                Console.WriteLine($"{i + 1}.ay Ödenen Faiz {Math.Round(kredi.faizkapatma, 5)} Ödenen Ana Para: {Math.Round((kredi.AylıkOdeme - kredi.faizkapatma), 5)}");
                krediKapatmaMesajı3[i] = $"Kredi Kapatma Tutarı = {Math.Round(kredi.anaPara, 5)} TL";
            }

            lB_KrediKapatma.Items.Add(krediKapatmaMesajı3[(int)kredi.OdenenTaksitSayisi - 1]);



            double anaPara = kredi.CekilenKredi;
            double faiz = 0;
            string[] krediKapatmaMesajı = new string[(int)kredi.taksitSayisi];
            string[] krediKapatmaMesajı1 = new string[(int)kredi.taksitSayisi];
            string[] krediKapatmaMesajı2 = new string[(int)kredi.taksitSayisi];
            for (int i = 0; i < kredi.OdenenTaksitSayisi; i++)
            {
                double usluSayi1 = Math.Pow((1 + kredi.FaizOranı), (kredi.taksitSayisi - i));
                double usluSayi2 = Math.Pow((1 + kredi.FaizOranı), (kredi.taksitSayisi - i - 1));
                double odenenFaiz1 = (kredi.CekilenKredi * usluSayi1) - kredi.CekilenKredi;
                double odenenFaiz2 = (kredi.CekilenKredi * usluSayi2) - kredi.CekilenKredi;
                double faizkapatma = odenenFaiz1 - odenenFaiz2;
                anaPara -= (kredi.AylıkOdeme - faizkapatma);
                faiz += faizkapatma;

                krediKapatmaMesajı[i] = $"{i + 1}.ay Ödenen Toplam Faiz {Math.Round(faiz, 5)} TL";
                krediKapatmaMesajı1[i] = $"{i + 1}.ay Toplam Ödenen Ana Para: {Math.Round((kredi.CekilenKredi - anaPara), 5)} TL";

                
            }
            for (int i =(int)kredi.OdenenTaksitSayisi-1; i >= 0; i--)
            {
                lB_KrediKapatma.Items.Add("");
                lB_KrediKapatma.Items.Add(krediKapatmaMesajı[i]);
                lB_KrediKapatma.Items.Add(krediKapatmaMesajı1[i]);
                
            }

           
           
        }

        private void btn_krediKapatmaOnay_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show($"Kredi kapatma işlemini onaylamak istiyor musunuz?", "Kredi Kapatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            
            if (secenek == DialogResult.Yes)
            {
                MessageBox.Show("Krediniz Ödeme İşleminiz Tamamlandı.");
                
            }
            else if (secenek == DialogResult.No)
            {
                
                btn_krediKapatmaOnay.Visible = false;
            }
        }
    }
}
