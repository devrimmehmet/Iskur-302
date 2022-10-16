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
            //Console.ReadKey();
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
                Console.ReadKey();
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
                Console.ReadKey();
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
                Console.ReadKey();
                MasaIslemDetay();

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
            Console.ForegroundColor = ConsoleColor.Green;
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
                Console.ReadKey();
                MasaAc();
            }
        }
        public void siparisSil()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                      {aktifMasa}.Masa - Sipariş Sil                 ");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"                          SİPARİŞLER                           ");
            Console.WriteLine("----------------------------------------------------------------");


            if (aktifMasa == "1")
            {
                int sayac = 1;
                foreach (var item in siparisListesi1)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }
            else if (aktifMasa == "2")
            {
                int sayac = 1;
                foreach (var item in siparisListesi2)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }
            else if (aktifMasa == "3")
            {
                int sayac = 1;
                foreach (var item in siparisListesi3)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }
            else if (aktifMasa == "4")
            {
                int sayac = 1;
                foreach (var item in siparisListesi4)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }
            else if (aktifMasa == "5")
            {
                int sayac = 1;
                foreach (var item in siparisListesi5)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }
            else if (aktifMasa == "6")
            {
                int sayac = 1;
                foreach (var item in siparisListesi6)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }
            else if (aktifMasa == "7")
            {
                int sayac = 1;
                foreach (var item in siparisListesi7)
                {
                    Console.WriteLine(sayac + ". Ürün  " + item + $" [{sayac}]");
                    sayac++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            if (siparisListesi.Count >= 1)
            {
                Console.WriteLine();
                Console.WriteLine("----Onaylarsanız Silinecek Siparişler----");
                Console.WriteLine();
            }

            foreach (var item in siparisListesi)
            {
                Console.WriteLine(item);

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("ONAYLA       [Space]");
            Console.WriteLine("GERİ GİT     [Sok Ok]");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write("Ürün Silmek İçin İd Giriniz: ");

            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key.ToString() == "Spacebar")
            {
                AnaMenu();
            }
            else if (KeyInfo.Key.ToString() == "LeftArrow")
            {



                if (aktifMasa == "1")
                {
                    siparisListesi1.AddRange(siparisListesi);
                }
                else if (aktifMasa == "2")
                {
                    siparisListesi2.AddRange(siparisListesi);
                }
                else if (aktifMasa == "3")
                {
                    siparisListesi3.AddRange(siparisListesi);
                }
                else if (aktifMasa == "4")
                {
                    siparisListesi4.AddRange(siparisListesi);
                }
                else if (aktifMasa == "5")
                {
                    siparisListesi5.AddRange(siparisListesi);
                }
                else if (aktifMasa == "6")
                {
                    siparisListesi6.AddRange(siparisListesi);
                }
                else if (aktifMasa == "7")
                {
                    siparisListesi7.AddRange(siparisListesi);
                }
                MasaIslemDetay();
            }
            else if (KeyInfo.Key.ToString() == "D1")
            {
                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi1[0]);
                        siparisListesi1.RemoveAt(0);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi2[0]);
                        siparisListesi1.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi3[0]);
                        siparisListesi3.RemoveAt(0);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi4[0]);
                        siparisListesi4.RemoveAt(0);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi5[0]);
                        siparisListesi5.RemoveAt(0);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi6[0]);
                        siparisListesi6.RemoveAt(0);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 1)
                    {
                        siparisListesi.Add(siparisListesi7[0]);
                        siparisListesi7.RemoveAt(0);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }



            }
            else if (KeyInfo.Key.ToString() == "D2")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi1[1]);
                        siparisListesi1.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi2[1]);
                        siparisListesi1.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi3[1]);
                        siparisListesi3.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi4[1]);
                        siparisListesi4.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi5[1]);
                        siparisListesi5.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi6[1]);
                        siparisListesi6.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 2)
                    {
                        siparisListesi.Add(siparisListesi7[1]);
                        siparisListesi7.RemoveAt(1);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D3")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi1[2]);
                        siparisListesi1.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi2[2]);
                        siparisListesi1.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi3[2]);
                        siparisListesi3.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi4[2]);
                        siparisListesi4.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi5[2]);
                        siparisListesi5.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi6[2]);
                        siparisListesi6.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 3)
                    {
                        siparisListesi.Add(siparisListesi7[2]);
                        siparisListesi7.RemoveAt(2);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D4")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi1[3]);
                        siparisListesi1.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi2[3]);
                        siparisListesi1.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi3[3]);
                        siparisListesi3.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi4[3]);
                        siparisListesi4.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi5[3]);
                        siparisListesi5.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi6[3]);
                        siparisListesi6.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 4)
                    {
                        siparisListesi.Add(siparisListesi7[3]);
                        siparisListesi7.RemoveAt(3);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D5")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi1[4]);
                        siparisListesi1.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi2[4]);
                        siparisListesi1.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi3[4]);
                        siparisListesi3.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi4[4]);
                        siparisListesi4.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi5[4]);
                        siparisListesi5.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi6[4]);
                        siparisListesi6.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 5)
                    {
                        siparisListesi.Add(siparisListesi7[4]);
                        siparisListesi7.RemoveAt(4);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D6")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi1[5]);
                        siparisListesi1.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi2[5]);
                        siparisListesi1.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi3[5]);
                        siparisListesi3.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi4[5]);
                        siparisListesi4.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi5[5]);
                        siparisListesi5.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi6[5]);
                        siparisListesi6.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 6)
                    {
                        siparisListesi.Add(siparisListesi7[5]);
                        siparisListesi7.RemoveAt(5);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D7")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi1[6]);
                        siparisListesi1.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi2[6]);
                        siparisListesi1.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi3[6]);
                        siparisListesi3.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi4[6]);
                        siparisListesi4.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi5[6]);
                        siparisListesi5.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi6[6]);
                        siparisListesi6.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 7)
                    {
                        siparisListesi.Add(siparisListesi7[6]);
                        siparisListesi7.RemoveAt(6);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D8")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi1[7]);
                        siparisListesi1.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi2[7]);
                        siparisListesi1.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi3[7]);
                        siparisListesi3.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi4[7]);
                        siparisListesi4.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi5[7]);
                        siparisListesi5.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi6[7]);
                        siparisListesi6.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 8)
                    {
                        siparisListesi.Add(siparisListesi7[7]);
                        siparisListesi7.RemoveAt(7);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


            }
            else if (KeyInfo.Key.ToString() == "D9")
            {

                if (aktifMasa == "1")
                {
                    if (siparisListesi1.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi1[8]);
                        siparisListesi1.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "2")
                {
                    if (siparisListesi2.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi2[8]);
                        siparisListesi1.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "3")
                {
                    if (siparisListesi3.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi3[8]);
                        siparisListesi3.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "4")
                {
                    if (siparisListesi4.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi4[8]);
                        siparisListesi4.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "5")
                {
                    if (siparisListesi5.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi5[8]);
                        siparisListesi5.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "6")
                {
                    if (siparisListesi6.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi6[8]);
                        siparisListesi6.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }
                else if (aktifMasa == "7")
                {
                    if (siparisListesi7.Count >= 9)
                    {
                        siparisListesi.Add(siparisListesi7[8]);
                        siparisListesi7.RemoveAt(8);
                        siparisSil();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Tuşa Bastınız");
                        Console.ReadKey();
                        siparisSil();
                    }
                }


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
                Console.WriteLine($"4.Masa [{Masa4}]");
            }
            if (Masa5 == "Dolu")
            {
                Console.WriteLine($"5.Masa [{Masa5}]");
            }
            if (Masa6 == "Dolu")
            {
                Console.WriteLine($"6.Masa [{Masa6}]");
            }
            if (Masa7 == "Dolu")
            {
                Console.WriteLine($"7.Masa [{Masa7}]");
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
                    aktifMasa = "1";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D2")
            {
                if (Masa2 == "Dolu")
                {
                    aktifMasa = "2";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D3")
            {
                if (Masa3 == "Dolu")
                {
                    aktifMasa = "3";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D4")
            {
                if (Masa4 == "Dolu")
                {
                    aktifMasa = "4";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D5")
            {
                if (Masa5 == "Dolu")
                {
                    aktifMasa = "5";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D6")
            {
                if (Masa6 == "Dolu")
                {
                    aktifMasa = "6";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else if (KeyInfo.Key.ToString() == "D7")
            {
                if (Masa7 == "Dolu")
                {
                    aktifMasa = "7";
                    MasaIslemDetay();
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz Masa Boş Önce Masayı Açınız.");
                    Console.ReadKey();
                    MasaIslem();
                }
            }
            else
            {
                Console.WriteLine("Yanlış Seçim Yaptınız.");
                Console.ReadKey();
                MasaIslem();
            }
        }
    }
}
