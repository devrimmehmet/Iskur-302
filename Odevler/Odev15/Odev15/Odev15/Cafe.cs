using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev15
{
    public class Cafe
    {
        public string Masa1 = "boş", Masa2 = "boş", Masa3 = "boş", Masa4 = "boş", Masa5 = "boş", Masa6 = "boş", Masa7 = "boş";
        public int yemek1 = 2, yemek2 = 3, yemek3 = 4, yemek4 = 5, icecek1 = 1, icecek2 = 2, icecek3 = 3, icecek4 = 4;
        public string aktifMasa;
        List<string> siparisListesi = new List<string>();
        List<string> siparisListesiYedek = new List<string>();
        List<string> siparisListesiYedek1 = new List<string>();
        List<string> siparisListesi1 = new List<string>();
        List<string> siparisListesi2 = new List<string>();
        List<string> siparisListesi3 = new List<string>();
        List<string> siparisListesi4 = new List<string>();
        List<string> siparisListesi5 = new List<string>();
        List<string> siparisListesi6 = new List<string>();
        List<string> siparisListesi7 = new List<string>();
        public void AnaMenu()
        {
            Console.Clear();
            Console.WriteLine("                            Ana Menü                            ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Masa Aç         [1]");
            Console.WriteLine("Masa İşlem      [2]");
            Console.WriteLine("Masa Hesap      [3]");
            Console.WriteLine("Kasa İşlemleri  [4]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ÇIKIŞ YAP       [0]");
            Console.Write("SEÇİMİNİZ: ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key.ToString() == "D0")
            {
                Kapat();
            }
            else if (KeyInfo.Key.ToString() == "D1")
            {
                Console.Clear();
                MasaAc();
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                Console.Clear();
                MasaIslem();
            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                Console.Clear();
                MasaAc();
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                Console.Clear();
                MasaAc();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                AnaMenu();
            }
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                            Masa  Aç                            ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                              MENÜ                              ");
            Console.WriteLine();
            Console.WriteLine("YEMEKLER                             İÇECEKLER         ");
            Console.WriteLine($" 1.Yemek - {yemek1} TL [1]                   1.İçecek  [5] - {icecek1} TL ");
            Console.WriteLine($" 2.Yemek - {yemek2} TL [2]                   2.İçecek  [6] - {icecek2} TL ");
            Console.WriteLine($" 3.Yemek - {yemek3} TL [3]                   3.İçecek  [7] - {icecek3} TL ");
            Console.WriteLine($" 4.Yemek - {yemek4} TL [4]                   4.İçecek  [8] - {icecek4} TL ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                          {aktifMasa}.Masa Siparişleri                   ");
            Console.WriteLine("----------------------------------------------------------------");
            if (aktifMasa == "1")
            {
                foreach (var item in siparisListesi1)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "2")
            {
                foreach (var item in siparisListesi2)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "3")
            {
                foreach (var item in siparisListesi3)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "4")
            {
                foreach (var item in siparisListesi4)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "5")
            {
                foreach (var item in siparisListesi5)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "6")
            {
                foreach (var item in siparisListesi6)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "7")
            {
                foreach (var item in siparisListesi7)
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in siparisListesi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ONAYLA       [Space]");
            Console.WriteLine("ANA MENÜ     [Esc]");
            Console.WriteLine("GERİ GİT     [Sok Ok]");
            Console.Write("Ürün Eklemek İçin Giriş Yapın: ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            //Console.WriteLine("\n" + KeyInfo.Key.ToString() + " tuşuna bastınız!..");
            //Console.ReadLine();
            if (KeyInfo.Key.ToString() == "D1")
            {
                Console.Clear();
                siparisListesi.Add($"1.Yemek - {yemek1} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                Console.Clear();
                siparisListesi.Add($"2.Yemek - {yemek2} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                Console.Clear();
                siparisListesi.Add($"3.Yemek - {yemek3} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                Console.Clear();
                siparisListesi.Add($"4.Yemek - {yemek4} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D5")
            {
                Console.Clear();
                siparisListesi.Add($"1.İçecek - {icecek1} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D6")
            {
                Console.Clear();
                siparisListesi.Add($"2.İçecek - {icecek2} TL");

                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D7")
            {
                Console.Clear();
                siparisListesi.Add($"3.İçecek - {icecek3} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D8")
            {
                Console.Clear();
                siparisListesi.Add($"4.İçecek - {icecek4} TL");
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "Escape")
            {
                AnaMenu();
            }
            else if (KeyInfo.Key.ToString() == "Spacebar")
            {
                if (aktifMasa == "1")
                {
                    Masa1 = "Dolu";
                    siparisListesi1.AddRange(siparisListesi);
                    siparisListesi.Clear();
                }
                else if (aktifMasa == "2")
                {
                    Masa2 = "Dolu";
                    siparisListesi2.AddRange(siparisListesi);
                    siparisListesi.Clear();
                }
                else if (aktifMasa == "3")
                {
                    Masa3 = "Dolu";
                    siparisListesi3.AddRange(siparisListesi);
                    siparisListesi.Clear();
                }
                else if (aktifMasa == "4")
                {
                    siparisListesi4.AddRange(siparisListesi);
                    siparisListesi.Clear();
                    Masa4 = "Dolu";
                }
                else if (aktifMasa == "5")
                {
                    siparisListesi5.AddRange(siparisListesi);
                    siparisListesi.Clear();
                    Masa5 = "Dolu";
                }
                else if (aktifMasa == "6")
                {
                    siparisListesi6.AddRange(siparisListesi);
                    siparisListesi.Clear();
                    Masa6 = "Dolu";
                }
                else if (aktifMasa == "7")
                {
                    siparisListesi7.AddRange(siparisListesi);
                    siparisListesi.Clear();
                    Masa7 = "Dolu";
                }

                AnaMenu();
            }
            else if (KeyInfo.Key.ToString() == "LeftArrow")
            {
                MasaAc();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                Console.ReadLine();
                MasaAc();
            }
        }
        public void MasaAc()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                            Masa  Aç                            ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"1.Masa         [{Masa1.ToString()}]");
            Console.WriteLine($"2.Masa         [{Masa2.ToString()}]");
            Console.WriteLine($"3.Masa         [{Masa3.ToString()}]");
            Console.WriteLine($"4.Masa         [{Masa4.ToString()}]");
            Console.WriteLine($"5.Masa         [{Masa5.ToString()}]");
            Console.WriteLine($"6.Masa         [{Masa6.ToString()}]");
            Console.WriteLine($"7.Masa         [{Masa7.ToString()}]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ANA MENÜ       [ESC]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Masa Açmak İçin Masa Numarası Giriniz: ");


            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key.ToString() == "D1")
            {
                Console.Clear();
                aktifMasa = "1";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                Console.Clear();
                aktifMasa = "2";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                Console.Clear();
                aktifMasa = "3";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                Console.Clear();
                aktifMasa = "4";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D5")
            {
                Console.Clear();
                aktifMasa = "5";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D6")
            {
                Console.Clear();
                aktifMasa = "6";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "D7")
            {
                Console.Clear();
                aktifMasa = "7";
                Menu();
            }
            else if (KeyInfo.Key.ToString() == "Escape")
            {
                AnaMenu();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                Console.ReadLine();
                MasaAc();
            }

        }
        public void Kapat()
        {

        }
        public void MasaIslemDetay()
        {
            Console.Clear();
          
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                            {aktifMasa}.Masa                       ");
            Console.WriteLine("----------------------------------------------------------------");
            int sayac = 1;
            if (aktifMasa == "1")
            {
                siparisListesiYedek = siparisListesi1;
                foreach (var item in siparisListesi1)
                {
                    
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;


                }
            }
            else if (aktifMasa == "2")
            {
                
                foreach (var item in siparisListesi2)
                {
                   
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;

                }
            }
            else if (aktifMasa == "3")
            {
               
                foreach (var item in siparisListesi3)
                {
                    
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;

                }
            }
            else if (aktifMasa == "4")
            {
               
                foreach (var item in siparisListesi4)
                {
                    
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;

                }
            }
            else if (aktifMasa == "5")
            {
             
                foreach (var item in siparisListesi5)
                {
                   
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;

                }
            }
            else if (aktifMasa == "6")
            {
              
                foreach (var item in siparisListesi6)
                {
                    
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;

                }
            }
            else if (aktifMasa == "7")
            {
               
                foreach (var item in siparisListesi7)
                {
                    
                    Console.WriteLine(sayac + ". Ürün  " + item);
                    sayac++;

                }
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Sipariş Ekle     [1]");
            Console.WriteLine($"Sipariş Sil      [2]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"ANA MENÜ         [ESC]");
            Console.WriteLine($"GERİ GİT         [Sol Ok]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("İşleminiz : ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);



            if (KeyInfo.Key.ToString() == "D1")
            {
                siparisListesi.Clear();
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                siparisListesi.Clear();
                siparisSil();
            }
            else if (KeyInfo.Key.ToString() == "Escape")
            {
                AnaMenu();
            }
            else if (KeyInfo.Key.ToString() == "LeftArrow")
            {
                MasaIslem();
            }
            else
            {
                Console.Write("Seçiminiz Hatalı...");
            }

        }
        public void siparisEkle()
        {
            Console.Clear();
            
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                 Masa  {aktifMasa} - Sipariş Ekle                 ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                              MENÜ                              ");
            Console.WriteLine();
            Console.WriteLine("YEMEKLER                             İÇECEKLER         ");
            Console.WriteLine($" 1.Yemek - {yemek1} TL [1]                   1.İçecek  [5] - {icecek1} TL ");
            Console.WriteLine($" 2.Yemek - {yemek2} TL [2]                   2.İçecek  [6] - {icecek2} TL ");
            Console.WriteLine($" 3.Yemek - {yemek3} TL [3]                   3.İçecek  [7] - {icecek3} TL ");
            Console.WriteLine($" 4.Yemek - {yemek4} TL [4]                   4.İçecek  [8] - {icecek4} TL ");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                          {aktifMasa}.Masa Siparişleri                   ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            if (aktifMasa == "1")
            {
                foreach (var item in siparisListesi1)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "2")
            {
                foreach (var item in siparisListesi2)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "3")
            {
                foreach (var item in siparisListesi3)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "4")
            {
                foreach (var item in siparisListesi4)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "5")
            {
                foreach (var item in siparisListesi5)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "6")
            {
                foreach (var item in siparisListesi6)
                {
                    Console.WriteLine(item);
                }
            }
            else if (aktifMasa == "7")
            {
                foreach (var item in siparisListesi7)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in siparisListesi)
            {
                Console.WriteLine(item);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ONAYLA       [Space]");
            Console.WriteLine("GERİ GİT     [Sok Ok]");
            Console.Write("Ürün Eklemek İçin Giriş Yapın: ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key.ToString() == "D1")
            {
                Console.Clear();
                siparisListesi.Add($"1.Yemek - {yemek1} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                Console.Clear();
                siparisListesi.Add($"2.Yemek - {yemek2} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                Console.Clear();
                siparisListesi.Add($"3.Yemek - {yemek3} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                Console.Clear();
                siparisListesi.Add($"4.Yemek - {yemek4} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D5")
            {
                Console.Clear();
                siparisListesi.Add($"1.İçecek - {icecek1} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D6")
            {
                Console.Clear();
                siparisListesi.Add($"2.İçecek - {icecek2} TL");

                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D7")
            {
                Console.Clear();
                siparisListesi.Add($"3.İçecek - {icecek3} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "D8")
            {
                Console.Clear();
                siparisListesi.Add($"4.İçecek - {icecek4} TL");
                siparisEkle();
            }
            else if (KeyInfo.Key.ToString() == "Spacebar")
            {
                if (aktifMasa == "1")
                {

                    siparisListesi1.AddRange(siparisListesi);
                    siparisListesi.Clear();
                }
                else if (aktifMasa == "2")
                {

                    siparisListesi2.AddRange(siparisListesi);
                    siparisListesi.Clear();
                }
                else if (aktifMasa == "3")
                {

                    siparisListesi3.AddRange(siparisListesi);
                    siparisListesi.Clear();
                }
                else if (aktifMasa == "4")
                {
                    siparisListesi4.AddRange(siparisListesi);
                    siparisListesi.Clear();

                }
                else if (aktifMasa == "5")
                {
                    siparisListesi5.AddRange(siparisListesi);
                    siparisListesi.Clear();

                }
                else if (aktifMasa == "6")
                {
                    siparisListesi6.AddRange(siparisListesi);
                    siparisListesi.Clear();

                }
                else if (aktifMasa == "7")
                {
                    siparisListesi7.AddRange(siparisListesi);
                    siparisListesi.Clear();

                }

                AnaMenu();
            }
            else if (KeyInfo.Key.ToString() == "LeftArrow")
            {
                siparisListesi.Clear();
                MasaIslemDetay();
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                Console.ReadLine();
                MasaAc();
            }
        }
        public void siparisSil()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                {aktifMasa}.Masa - Sipariş Sil                 ");
            Console.WriteLine("----------------------------------------------------------------");
            int sayac = 1;
            if (aktifMasa == "1")
            {
                siparisListesi = siparisListesi1;
                if (siparisListesi1.Count==siparisListesiYedek.Count)
                {
                   
                    foreach (var item in siparisListesi1)
                    {
                        Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                        sayac++;
                    }
                }
                else
                {
                    Console.WriteLine("dedede");
                    foreach (var item in siparisListesi)
                    {
                        Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                        sayac++;
                    }
                }     
            }
            else if (aktifMasa == "2")
            {
                if (siparisListesi2.Count == siparisListesiYedek.Count)
                {
                    siparisListesi = siparisListesi2;
                }
                foreach (var item in siparisListesi)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                    sayac++;

                }
            }
            else if (aktifMasa == "3")
            {
                if (siparisListesi3.Count == siparisListesiYedek.Count)
                {
                    siparisListesi = siparisListesi3;
                }
                foreach (var item in siparisListesi)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                    sayac++;

                }
            }
            else if (aktifMasa == "4")
            {
                if (siparisListesi4.Count == siparisListesiYedek.Count)
                {
                    siparisListesi = siparisListesi4;
                }
                
                foreach (var item in siparisListesi)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                    sayac++;

                }
            }
            else if (aktifMasa == "5")
            {
                if (siparisListesi5.Count == siparisListesiYedek.Count)
                {
                    siparisListesi = siparisListesi5;
                }
                foreach (var item in siparisListesi)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                    sayac++;

                }
            }
            else if (aktifMasa == "6")
            {
                if (siparisListesi6.Count == siparisListesiYedek.Count)
                {
                    siparisListesi = siparisListesi6;
                }
                foreach (var item in siparisListesi)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                    sayac++;

                }
            }
            else if (aktifMasa == "7")
            {
                if (siparisListesi7.Count == siparisListesiYedek.Count)
                {
                    siparisListesi = siparisListesi7;
                }
                foreach (var item in siparisListesi)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $"    [{sayac}]");
                    sayac++;

                }
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"ONAYLA           [Space]");
            Console.WriteLine($"GERİ GİT         [Sol Ok]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Ürün Silmek İçin Seçim Yapınız : ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);


            if (KeyInfo.Key.ToString() == "D1")
            {
                Console.WriteLine(siparisListesi.Count+"siparislistesi");
                Console.WriteLine(siparisListesiYedek.Count + "siparislistesiyedek");
                Console.WriteLine(siparisListesi1.Count + "siparislistesicount1");
                Console.ReadLine();
                if (siparisListesi.Count >= 1)
                {
                    siparisListesi.RemoveAt(0);
                    siparisListesiYedek.RemoveAt(0);
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
                

            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                if (siparisListesi.Count >= 2)
                {
                    siparisListesi.RemoveAt(1);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }

            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                if (siparisListesi.Count >= 3)
                {
                    siparisListesi.RemoveAt(2);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                if (siparisListesi.Count >= 4)
                {
                    siparisListesi.RemoveAt(3);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "D5")
            {
                if (siparisListesi.Count >= 5)
                {
                    siparisListesi.RemoveAt(4);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "D6")
            {
                if (siparisListesi.Count >= 6)
                {
                    siparisListesi.RemoveAt(5);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "D7")
            {
                if (siparisListesi.Count >= 7)
                {
                    siparisListesi.RemoveAt(6);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "D8")
            {
                if (siparisListesi.Count >= 8)
                {
                    siparisListesi.RemoveAt(7);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "D9")
            {
                if (siparisListesi.Count >= 9)
                {
                    siparisListesi.RemoveAt(8);
                    siparisListesiYedek = siparisListesi;
                    siparisSil();
                }
                else
                {
                    Console.WriteLine("Seçiminiz Hatalı...");
                }
            }
            else if (KeyInfo.Key.ToString() == "Spacebar")
            {
                if (aktifMasa == "1")
                {
                    siparisListesi1 = siparisListesi;
                   
                    MasaIslemDetay();
                }
                else if (aktifMasa == "2")
                {
                    siparisListesi2 = siparisListesi;
                    
                    MasaIslemDetay();
                }
                else if (aktifMasa == "3")
                {
                    siparisListesi3 = siparisListesi;
                   
                    MasaIslemDetay();
                }
                else if (aktifMasa == "4")
                {
                    siparisListesi4 = siparisListesi;
                   
                    MasaIslemDetay();
                }
                else if (aktifMasa == "5")
                {
                    siparisListesi5 = siparisListesi;
                    
                    MasaIslemDetay();
                }
                else if (aktifMasa == "6")
                {
                    siparisListesi6 = siparisListesi;
                   
                    MasaIslemDetay();
                }
                else if (aktifMasa == "7")
                {
                    siparisListesi7 = siparisListesi;
                   
                    MasaIslemDetay();
                }
            }
            else if (KeyInfo.Key.ToString() == "LeftArrow")
            {
            
                MasaIslemDetay();
            }
            else
            {
                Console.Write("Seçiminiz1 Hatalı...");
                Console.ReadLine();
          
            }


        }
        public void MasaIslem()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("                           Masa İşlem                           ");
            Console.WriteLine("----------------------------------------------------------------");

            if (Masa1 == "Dolu")
            {
                Console.WriteLine($"1.Masa [{Masa1}]");
            }
            if (Masa2 == "Dolu")
            {
                Console.WriteLine($"2.Masa [{Masa2}]");
            }
            if (Masa3 == "Dolu")
            {
                Console.WriteLine($"3.Masa [{Masa3}]");
            }
            if (Masa4 == "Dolu")
            {
                Console.WriteLine($"1.Masa [{Masa4}]");
            }
            if (Masa5 == "Dolu")
            {
                Console.WriteLine($"1.Masa [{Masa5}]");
            }
            if (Masa6 == "Dolu")
            {
                Console.WriteLine($"1.Masa [{Masa6}]");
            }
            if (Masa7 == "Dolu")
            {
                Console.WriteLine($"1.Masa [{Masa7}]");
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ANA MENÜ       [ESC]");
            Console.WriteLine("----------------------------------------------------------------");

            Console.Write("İşlem Yapmak İçin Masa Numarası Giriniz: ");
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key.ToString() == "Escape")
            {
                AnaMenu();
            }
            else if (KeyInfo.Key.ToString() == "D1")
            {
                if (Masa1 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                if (Masa2 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                if (Masa3 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                if (Masa4 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D5")
            {
                if (Masa5 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D6")
            {
                if (Masa6 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D7")
            {
                if (Masa7 == "Dolu")
                {
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadLine();
                    MasaIslem();
                }
            }
        }
    }
}
