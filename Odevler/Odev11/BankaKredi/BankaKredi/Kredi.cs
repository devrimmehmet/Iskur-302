using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKredi
{
    internal class Kredi
    {

        public double  anaPara, taksitSayisi;
        public double FaizHesaplama, AylıkOdeme = 0, OdenenTaksitSayisi, KrediKapatmaMiktari, CekilenKredi, FaizOranı, faizkapatma;
        public string KullaniciAdi, Sifre, cevap, Banka_Adi;

        public void BireyselKredi()
        {
            Console.WriteLine($"{Banka_Adi}\n1-Kredi Çekme 2-Kredi Kapatma");
            cevap = Console.ReadLine();
            if (cevap == "1")
            {
                BireyselKrediCekme();
            }
            else if (cevap == "2")
            {
                BireyselKrediKapama();
            }
        }
        public void BireyselKrediCekme()
        {
            Console.WriteLine("Çekmek İstediğiniz Kredi Miktarını Giriniz");
            CekilenKredi=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kaç Taksitte ödemek istiyorsunuz");
            taksitSayisi = Convert.ToDouble(Console.ReadLine());

            double usluSayi = Math.Pow((1 + FaizOranı), taksitSayisi);
            FaizHesaplama = (CekilenKredi * usluSayi) - CekilenKredi;
            KrediKapatmaMiktari = CekilenKredi + FaizHesaplama;
            AylıkOdeme = KrediKapatmaMiktari / taksitSayisi;

            Console.WriteLine($"Aylık Taksit Ücreti: {Math.Round(AylıkOdeme, 5)} TL\n" +
                 $"Çekilen Kredi: {Math.Round(CekilenKredi,5)} TL\nÖdenecek Toplam: {Math.Round(KrediKapatmaMiktari,5)} TL");
            double[] aylikFaiz = new double[(int)taksitSayisi];
            anaPara = CekilenKredi;
            
            Console.ReadLine();
            BireyselKredi();
        }
        public void BireyselKrediKapama()
        {
            Console.WriteLine("Kredi kapatma menüsüne hoşgeldiniz");
            Console.WriteLine("Kaç taksit ödediniz ?");
            OdenenTaksitSayisi = Convert.ToDouble(Console.ReadLine());
            string[] krediKapatmaMesajı = new string[(int)taksitSayisi];
            double faiz=0;
            for (int i = 0; i < OdenenTaksitSayisi; i++)
            {
                double usluSayi1 = Math.Pow((1 + FaizOranı), (taksitSayisi - i));
                double usluSayi2 = Math.Pow((1 + FaizOranı), (taksitSayisi - i - 1));
                double odenenFaiz1 = (CekilenKredi * usluSayi1) - CekilenKredi;
                double odenenFaiz2 = (CekilenKredi * usluSayi2) - CekilenKredi;
                faizkapatma = odenenFaiz1 - odenenFaiz2;
                anaPara -= (AylıkOdeme - faizkapatma);
                faiz += faizkapatma;
                Console.WriteLine($"{i + 1}.ay Ödenen Faiz {Math.Round(faizkapatma,5)} Ödenen Ana Para: {Math.Round((AylıkOdeme - faizkapatma), 5)}");
                krediKapatmaMesajı[i] = $"{i + 1}.ay Ödenen Toplam Faiz {Math.Round(faiz, 5)} Toplam Ödenen Ana Para: {Math.Round((CekilenKredi - anaPara), 5)} Kredi Kapatma Tutarı = {Math.Round(anaPara, 5)}";
            }
        
            Console.WriteLine();
            Console.WriteLine(krediKapatmaMesajı[(int)OdenenTaksitSayisi-1]);
            Console.ReadLine();
        }
        public void KurumsalKredi()
        {
            Console.WriteLine($"{Banka_Adi}\n1-Kredi Çekme 2-Kredi Kapatma");
            cevap = Console.ReadLine();
            if (cevap == "1")
            {
                KurumsalGiris();
                KurumsalKrediCekme();
            }
            else if (cevap == "2")
            {
                KurumsalGiris();
                KurumsalKrediKapama();
            }
        }
        public void KurumsalGiris()
        {
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Kullanıcı Adını Giriniz: ");
                KullaniciAdi = Console.ReadLine();
                Console.WriteLine("Şifreyi Giriniz: ");
                Sifre = Console.ReadLine();
                if (KullaniciAdi == "Salih" && Sifre == "Devrim")
                {
                    durum = false;
                }
                else
                {
                    Console.WriteLine("Lütfen kullanıcı adı ve şifreinizi doğru giriniz: ");
                }
            }
        }
        public void KurumsalKrediCekme()
        {
            Console.WriteLine("Çekmek İstediğiniz Kredi Miktarını Giriniz");
            CekilenKredi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kaç Taksitte ödemek istiyorsunuz");
            taksitSayisi = Convert.ToDouble(Console.ReadLine());

            double usluSayi = Math.Pow((1 + FaizOranı), taksitSayisi);
            FaizHesaplama = (CekilenKredi * usluSayi) - CekilenKredi;
            KrediKapatmaMiktari = CekilenKredi + FaizHesaplama;
            AylıkOdeme = KrediKapatmaMiktari / taksitSayisi;

            Console.WriteLine($"Aylık Taksit Ücreti: {Math.Round(AylıkOdeme, 5)} TL\n" +
                  $"Çekilen Kredi: {Math.Round(CekilenKredi, 5)} TL\nÖdenecek Toplam: {Math.Round(KrediKapatmaMiktari, 5)} TL");
            double[] aylikFaiz = new double[(int)taksitSayisi];
            anaPara = CekilenKredi;
            Console.ReadLine();
            KurumsalKredi();
        }
        public void KurumsalKrediKapama()
        {
            Console.WriteLine("Kredi kapatma menüsüne hoşgeldiniz");
            Console.WriteLine("Kaç taksit ödediniz ?");
            OdenenTaksitSayisi = Convert.ToDouble(Console.ReadLine());
            string[] krediKapatmaMesajı = new string[(int)taksitSayisi];
            double faiz = 0;
            for (int i = 0; i < OdenenTaksitSayisi; i++)
            {
                double usluSayi1 = Math.Pow((1 + FaizOranı), (taksitSayisi - i));
                double usluSayi2 = Math.Pow((1 + FaizOranı), (taksitSayisi - i - 1));
                double odenenFaiz1 = (CekilenKredi * usluSayi1) - CekilenKredi;
                double odenenFaiz2 = (CekilenKredi * usluSayi2) - CekilenKredi;
                faizkapatma = odenenFaiz1 - odenenFaiz2;
                anaPara -= (AylıkOdeme - faizkapatma);
                faiz += faizkapatma;
                Console.WriteLine($"{i + 1}.ay Ödenen Faiz {Math.Round(faizkapatma, 5)} Ödenen Ana Para: {Math.Round((AylıkOdeme - faizkapatma), 5)}");
                krediKapatmaMesajı[i] = $"{i + 1}.ay Ödenen Toplam Faiz {Math.Round(faiz, 5)} Toplam Ödenen Ana Para: {Math.Round((CekilenKredi - anaPara), 5)} Kredi Kapatma Tutarı = {Math.Round(anaPara, 5)}";
            }

            Console.WriteLine();
            Console.WriteLine(krediKapatmaMesajı[(int)OdenenTaksitSayisi - 1]);
            Console.ReadLine();
        }
        public void Menu()
        {

            Console.WriteLine("Banka Uygulamasına Hoşgeldiniz");
        start1:
            Console.WriteLine("Lütfen işlem yapmak istediğiniz bankayı seçiniz: ");
            Console.WriteLine("1- İş Bankası\n2- Ziraat Bankası\n3- Garanti Bankası\n4- Yapı Kredi\n5- Finans Bank");
            string cevap1 = " ";
            string cevap2 = " ";
        
            string banka = Console.ReadLine();

            switch (banka)
            {
                case "1":
                    Console.WriteLine("İş Bankasını seçtiniz. Devam etmek istiyor musunuz ?");
                    cevap1 = Console.ReadLine();
                    if (cevap1.ToLower() == "evet")
                    {
                        Banka_Adi = "İş Bankası";
                        FaizOranı = 0.019;
                        Console.WriteLine($"Faiz Oranı: %{FaizOranı*100}");
                        break;
                    }
                    else
                    {
                        goto start1;
                    }
                case "2":
                    Console.WriteLine("Ziraat Bankasını seçtiniz. Devam etmek istiyor musunuz ?");
                    cevap1 = Console.ReadLine();
                    if (cevap1.ToLower() == "evet")
                    {
                        Banka_Adi = "Ziraat Bankası";
                        FaizOranı = 0.018;
                        Console.WriteLine($"Faiz Oranı: %{FaizOranı*100}");
                        break;
                    }
                    else
                    {
                        goto start1;
                    }
                case "3":
                    Console.WriteLine("Garanti Bankasını seçtiniz. Devam etmek istiyor musunuz ?");
                    cevap1 = Console.ReadLine();
                    if (cevap1.ToLower() == "evet")
                    {
                        Banka_Adi = "Garanti Bankası";
                        FaizOranı = 0.017;
                        Console.WriteLine($"Faiz Oranı: %{FaizOranı*100}");
                        break;
                    }
                    else
                    {
                        goto start1;
                    }
                case "4":
                    Console.WriteLine("Yapı Kredi Bankasını seçtiniz. Devam etmek istiyor musunuz ?");
                    cevap1 = Console.ReadLine();
                    if (cevap1.ToLower() == "evet")
                    {
                        Banka_Adi = "Yapı Kredi Bankası";
                        FaizOranı = 0.017;
                        Console.WriteLine($"Faiz Oranı: %{FaizOranı * 100}");
                        break;
                    }
                    else
                    {
                        goto start1;
                    }
                case "5":
                    Console.WriteLine("Finans Bankasını seçtiniz. Devam etmek istiyor musunuz ?");
                    cevap1 = Console.ReadLine();
                    if (cevap1.ToLower() == "evet")
                    {
                        Banka_Adi = "Finans Bankası";
                        FaizOranı = 0.015;
                        Console.WriteLine($"Faiz Oranı: %{FaizOranı * 100}");
                        break;
                    }
                    else
                    {
                        goto start1;
                    }
                default:
                    break;
            }
            Console.WriteLine("Lütfen ilerlemek istediğiniz bölümü seçiniz");
            Console.WriteLine("1- Bireysel 2- Kurumsal");
            cevap2 = Console.ReadLine();
            if (cevap2 == "1")
            {
                BireyselKredi();
            }
            else if (cevap2 == "2")
            {
                KurumsalKredi();
            }
        }
    }
}

