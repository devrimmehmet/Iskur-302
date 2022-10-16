using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Uygulamasi
{
    public class Kredi
    {
        
        public double anaPara, taksitSayisi;
        public double FaizHesaplama, AylıkOdeme = 0, OdenenTaksitSayisi, KrediKapatmaMiktari, CekilenKredi, FaizOranı, faizkapatma;
        public string KullaniciAdi, Sifre, cevap, Banka_Adi;
        public string Banka;
      
        public void BireyselKrediCekme()
        {
            FaizOranı = 0.019;
            Ziraat ziraat = new Ziraat();
            double usluSayi = Math.Pow((1 + FaizOranı), taksitSayisi);
            FaizHesaplama = (CekilenKredi * usluSayi) - CekilenKredi;
            KrediKapatmaMiktari = CekilenKredi + FaizHesaplama;
            AylıkOdeme = KrediKapatmaMiktari / taksitSayisi;
            anaPara = CekilenKredi;
            
        }
       
        
    }
}
