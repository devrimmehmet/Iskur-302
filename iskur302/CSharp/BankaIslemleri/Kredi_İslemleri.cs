using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri
{
        public class Kredi_İslemleri
        {
            public double İşBanka, ZiraatBanka, GarantiBanka, YapıKredi, FinansBanka, anaPara, taksitSayisi;
            public double FaizHesaplama, AylıkOdeme = 0, OdenenTaksitSayisi, KrediKapatmaMiktari, CekilenKredi, FaizOranı,faizlerToplami, faizkapatma,ayinFaizi;
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
                Console.WriteLine("Çekmek istediğiniz kredi miktarını giriniz ? ");
                CekilenKredi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kaç taksit olsun istersiniz ? ");
                taksitSayisi = Convert.ToDouble(Console.ReadLine());
            anaPara = CekilenKredi;
            FaizHesaplama = (anaPara/100) * (FaizOranı/12) * taksitSayisi;
            KrediKapatmaMiktari = CekilenKredi + FaizHesaplama;
            AylıkOdeme = (FaizHesaplama+anaPara)/taksitSayisi;
           
            Console.WriteLine($"Aylık Taksit Ücreti: {AylıkOdeme} TL\n" +
                $"Çekilen Kredi: {CekilenKredi} TL\nÖdenecek Toplam: {KrediKapatmaMiktari} TL");

            for (int i = 0; i < taksitSayisi; i++)
            {
                ayinFaizi = (anaPara / 100) * (FaizOranı / 12) * (i+1);
                faizlerToplami += ayinFaizi;
                anaPara -= AylıkOdeme - ayinFaizi;

                Console.WriteLine($"{i + 1}.ay Kalan Anapara {anaPara} Faizi:{ayinFaizi} Faizlerin Toplamı: {faizlerToplami} ");
            }
            Console.ReadLine();
                BireyselKredi();
            }
        public void BireyselKrediCekme1()
        {
            
            Console.WriteLine("Çekmek istediğiniz kredi miktarını giriniz ? ");
            CekilenKredi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kaç taksit olsun istersiniz ? ");
            taksitSayisi = Convert.ToDouble(Console.ReadLine());
            anaPara = CekilenKredi;
            FaizHesaplama = (anaPara / 100) * (FaizOranı / 12) * taksitSayisi;
            KrediKapatmaMiktari = CekilenKredi + FaizHesaplama;
            AylıkOdeme = (FaizHesaplama + anaPara) / taksitSayisi;

            Console.WriteLine($"Aylık Taksit Ücreti: {AylıkOdeme} TL\n" +
                $"Çekilen Kredi: {CekilenKredi} TL\nÖdenecek Toplam: {KrediKapatmaMiktari} TL");

            for (int i = 0; i < taksitSayisi; i++)
            {
                ayinFaizi = (anaPara / 100) * (FaizOranı / 12) * (i + 1);
                faizlerToplami += ayinFaizi;
                anaPara -= AylıkOdeme - ayinFaizi;

                Console.WriteLine($"{i + 1}.ay Kalan Anapara {anaPara} Faizi:{ayinFaizi} Faizlerin Toplamı: {faizlerToplami} ");
            }
            Console.ReadLine();
            BireyselKredi();
        }
        public void BireyselKrediKapama()
            {
            //Console.WriteLine("Kredi kapatma menüsüne hoşgeldiniz");
            //Console.WriteLine("Kaç taksit ödediniz ?");
            //OdenenTaksitSayisi = Convert.ToDouble(Console.ReadLine());
            //KrediKapatmaMiktari = anaPara - (AylıkOdeme * OdenenTaksitSayisi*0.2);
            //Console.WriteLine($"Kredi Kapatma Miktarı: {KrediKapatmaMiktari} TL");
            faizlerToplami = 0;
            for (int i = 0; i < taksitSayisi; i++)
            {
                ayinFaizi = (anaPara) * FaizOranı / 100;
                faizlerToplami += ayinFaizi;
                
                (anaPara) -=AylıkOdeme- ayinFaizi ;
                Console.WriteLine($"{i+1}.ay Kalan Anapara {anaPara} Faizi:{ayinFaizi} Faizlerin Toplamı: {faizlerToplami} ");
            }
            
                
            for (int i = 0; i < taksitSayisi; i++)
            {
                Console.WriteLine();
            }
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
                Console.WriteLine("Çekmek istediğiniz kredi miktarını giriniz ? ");
                CekilenKredi = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kaç taksit olsun istersiniz ? ");
                taksitSayisi = Convert.ToDouble(Console.ReadLine());
                for (int i = 0; i < taksitSayisi; i++)
                {
                    FaizHesaplama += CekilenKredi * FaizOranı / 100;
                }
                AylıkOdeme = (CekilenKredi + FaizHesaplama) / taksitSayisi;
                anaPara = CekilenKredi;
                KrediKapatmaMiktari = CekilenKredi + FaizHesaplama;
                Console.WriteLine($"Aylık Taksit Ücreti: {AylıkOdeme} TL\nÇekilen Kredi: {CekilenKredi} TL\nÖdenecek Toplam: {CekilenKredi + FaizHesaplama} TL");
                Console.ReadLine();
                BireyselKredi();
            }
            public void KurumsalKrediKapama()
            {
                Console.WriteLine("Kredi kapatma menüsüne hoşgeldiniz");
                Console.WriteLine("Kaç taksit ödediniz ?");
                OdenenTaksitSayisi = Convert.ToDouble(Console.ReadLine());
                faizkapatma = FaizHesaplama;
                for (int i = 0; i < OdenenTaksitSayisi; i++)
                {
                    faizkapatma = faizkapatma * 0.8;
                }
                KrediKapatmaMiktari = anaPara+FaizHesaplama - (AylıkOdeme * OdenenTaksitSayisi) - faizkapatma;
                Console.WriteLine($"Kredi Kapatma Miktarı: {KrediKapatmaMiktari} TL");
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
                string cevap3 = " ";
                string cevap4 = " ";
                string cevap5 = " ";
            start:
                string banka = Console.ReadLine();

                switch (banka)
                {
                    case "1":
                        Console.WriteLine("İş Bankasını seçtiniz. Devam etmek istiyor musunuz ?");
                        cevap1 = Console.ReadLine();
                        if (cevap1.ToLower() == "evet")
                        {
                            Banka_Adi = "İş Bankası";
                            FaizOranı = 15;
                            Console.WriteLine($"Faiz Oranı: %{FaizOranı}");
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
                            FaizOranı = 1.9;
                            Console.WriteLine($"Faiz Oranı: {FaizOranı}");
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
                            FaizOranı = 2;
                            Console.WriteLine($"Faiz Oranı: {FaizOranı}");
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
                            FaizOranı = 2.1;
                            Console.WriteLine($"Faiz Oranı: {FaizOranı}");
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
                            FaizOranı = 2.2;
                            Console.WriteLine($"Faiz Oranı: {FaizOranı}");
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
                else if (cevap2 == "2") ;
                {
                    KurumsalKredi();
                }
            }
        }
    }



