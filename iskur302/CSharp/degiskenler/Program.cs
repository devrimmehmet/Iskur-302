using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int sayi,sayi2;
            sayi2 = 1923;
            Console.Write("Lütfen sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if ((sayi%2)==0)
            {
                Console.WriteLine("{0} çift sayıdır.{1} güzel bir sayıdır.",sayi,sayi2);
            }
            else
            {
                Console.WriteLine("{0} tek sayıdır. {1} güzel bir sayıdır.", sayi, sayi2);
            }
            Console.ReadLine();
            */
            /*

            int sayi1 = 10;
            int sayi2 = 20;
            int sayi3 = 30;

            sayi1 = sayi1 + sayi2;
            Console.WriteLine(sayi1);
            sayi1 = ++sayi1;

            Console.WriteLine(sayi1);
            sayi2 = sayi2++;

            Console.WriteLine(sayi2);
            Console.ReadLine();
            */
            /*Değişkenler isimlendirilirken kelimeler arasında boşluk karakteri kullanılmaz. Gerekli durumlarda _ ile kelimeler birleştirilebilir.
            C#’da değişken isimleri büyük-küçük harf duyarlıdır. Yani sayi ile SAYI aynı değişkeni göstermez.
            Değişken isimlerinde zorunluluk olmamasına karşın Türkçe karakter kullanılmamalıdır.
            Değişken isimleri ?,!,:,% gibi özel karakterler içeremez.
            Değişken ismi olarak C# dilindeki özel kelimeler seçilemez.
            Değişken isimlerinde zorunlu olmamasına karşın küçük harf kullanımı tercih edilir. Eğer değişken ismi iki ya da daha fazla kelimeden oluşuyorsa ilk kelime hariç diğer kelimelerin ilk harfi büyük yazılır. (sayi, maasMiktari, kitapSayisi v.b.)
            */


            // ASAL SAYI ÇÖZÜMÜ !!!
            /*
                         deneme:
                        int number;
                        Console.WriteLine("Lütfen bir sayı giriniz:");
                        number = Convert.ToInt32(Console.ReadLine());
                      bool  isPrime=true;
                        if (number < 1)
                        {
                            Console.WriteLine("Geçersiz sayı");
                            isPrime = false;
                        }
                        if (number == 1)
                        {
                            isPrime = false;
                        }

                        for (int i = 2; i < number; i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;

                            }
                        }

                        if (isPrime==true)
                        {
                            Console.WriteLine("Sayı Asaldır.");
                        }
                        else
                        {
                            Console.WriteLine("Sayı Asal Değildir.");
                        }
                        goto deneme;
                        Console.ReadLine();*/

            /*
                        int sayi;
                     basadon:
                     Console.Write("Lütfen bir sayı giriniz: ");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if (sayi % 2 == 0)
                         {
                        Console.WriteLine("{0} çift sayıdır",sayi);
                        }else 
                        { Console.WriteLine("{0} tek sayıdır", sayi); }
                    goto basadon;
                        Console.ReadLine();

            */





            //Klavyeden girilen bir sayının negatif yada pozitif olduğunu belirleme;
            /*            int sayi;
                    start:
                        Console.Write("Lütfen bir sayı giriniz :");
                        sayi = Convert.ToInt32(Console.ReadLine());
                        if (sayi < 0)
                        {
                            Console.Write("{0} negatiftir.",sayi);
                        }
                        else
                        {
                            Console.Write("{0} pozitiftir.", sayi);

                        }
                        Console.WriteLine();
                        goto start;
                        Console.ReadKey();

            */
            /*
            //Klavyeden bir kenarı girilen karenin alan ve çevresini hesaplama;
            int kenar,alan,cevre;
            start:
            Console.Write("Lütfen karenin bir kenarını giriniz :");
            kenar = Convert.ToInt32(Console.ReadLine());
            cevre = kenar * 4;
            alan = kenar * kenar;
            Console.WriteLine("Alanı: {0}  Çevresi: {1}",alan,cevre);
            goto start;
            Console.ReadLine();

            */

            //Klavyeden kenar uzunlukları girilen dikdörtgenin alan ve çevresini hesaplama;
            /* int kisaKenar, uzunKenar, alan, cevre;
             start:
             Console.Write("Lütfen Dikdörtgenin kısa kenarını giriniz :");
             kisaKenar = Convert.ToInt32(Console.ReadLine());
             Console.Write("Lütfen Dikdörtgenin uzun kenarını giriniz :");
             uzunKenar = Convert.ToInt32(Console.ReadLine());
             alan = kisaKenar * uzunKenar;
             cevre = (kisaKenar + uzunKenar) * 2;
             Console.WriteLine("Dikdörtgenin çevresi:{0} Dikdörtgenin Alanı:{1}", cevre, alan);
             Console.WriteLine();
             goto start;
             Console.ReadLine();*/
            #region odev

            // Bir manav bölümünde satılan elma-3tl,armut-5tl ve muz-7tl kg fiyatlarına göre müşterinin önünde ne kadarlık bir ürün alacağı sorulup ücretini hesaplanması
            /*
            double elma = 3;
            double armut = 5;
            double muz = 7;
            double kackg, total;
            string secim;
            start:
            Console.WriteLine("Ne almak istersiniz? (Elma,Armut,Muz)");
            secim = Console.ReadLine();
            if (secim != "Elma" && secim != "Armut" && secim != "Muz")
            {
                Console.WriteLine("Lütfen ne alacağınızı küçük büyük dikkat ederek yazınız");
                goto start;
            }
            Console.WriteLine("Kaç kg almak istersiniz?");
            kackg =Convert.ToInt32( Console.ReadLine());
            if (secim == "Elma") {
                total = elma * kackg;
                if (total<50) { 
                    total=(total*0.9);
                }
                if(total>50 && total < 100)
                {
                    total = (total * 0.85);
                }
                if (total >= 100 )
                {
                    total = (total * 0.8);
                }
                Console.WriteLine("Borcunuz: {0} Tl",total);
            }
            if (secim == "Armut")
            {
                total = armut * kackg;
                if (total < 50)
                {
                    total = (total * 0.9);
                }
                if (total > 50 && total < 100)
                {
                    total = (total * 0.85);
                }
                if (total >= 100)
                {
                    total = (total * 0.8);
                }
                Console.WriteLine("Borcunuz: {0} Tl", total);
            }
            if (secim=="Muz")
            {
                total = muz * kackg;
                if (total < 50)
                {
                    total = (total * 0.9);
                }
                if (total > 50 && total < 100)
                {
                    total = (total * 0.85);
                }
                if (total >= 100)
                {
                    total = (total * 0.8);
                }
                Console.WriteLine("Borcunuz: {0} Tl", total);
            }

            goto start;

            Console.ReadLine();
            */
            //ödev - 0 ile 50 arsında ise ücreti 50 dahil değil %10  indirim
            //50 ile 100 arsında ise ücreti 50 dahil değil %15  indirim
            // 100 üstü %20
            /*
                        switch (secim)
                        {
                            case "Elma":
                                total = elma * kackg;
                                Console.WriteLine("Borcunuz: {0} Tl", total);
                                break; 

                            default:
                                break;
                        }*/
            #endregion
            #region ortalama


            // 1.sınav 2.sınav ortalama  1.sınav .%30 2.sınv %50 proje %20
            //0ile 50 arasında kaldı
            //50ile 70 arasında geçti
            //70 üzeri çok iyi
            // 
            /*   double sinav1, sinav2, sinav3,ortalama;

               Console.WriteLine("Lütfen 1.sınav notunuzu giriniz");
               sinav1 = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Lütfen 2.sınav notunuzu giriniz");
               sinav2 = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine("Lütfen Proje ödevi notunuzu giriniz");
               sinav3 = Convert.ToInt32(Console.ReadLine());

               ortalama = (sinav1 * 0.3) + (sinav2 * 0.5) + (sinav3 * 0.2);

               Console.WriteLine("Ortalamanız :"+ ortalama);
               if (ortalama < 50)
               {
                   Console.WriteLine("Kaldınız");
               }
               if (ortalama < 70 && ortalama > 50)
               {
                   Console.WriteLine("Geçtiniz");
               }
               if (ortalama > 70)
               {
                   Console.WriteLine("Çok İyi Geçtiniz");
               }
            */
            #endregion
            #region mevsimler
            /* 
             string mevsim;
             baslangic:
             Console.WriteLine("Mevsim giriniz(Kış,Yaz,Sonbahar,İlkbahar)");
             mevsim = Console.ReadLine();
             if (mevsim == "Kış")
             {
                 Console.WriteLine("Kış Mevsiminin Ayları : Aralık, Ocak, Şubat");
             }else if (mevsim == "İlkbahar")
             {
                 Console.WriteLine("İlkbahar Mevsiminin Ayları : Mart, Nisan, Mayıs");
             }
             else if (mevsim == "Yaz")
             {
                 Console.WriteLine("Yaz Mevsiminin Ayları : Haziran, Temmuz, Ağustos");
             }
             else if (mevsim == "Sonbahar")
             {
                 Console.WriteLine("Sonbahar Mevsiminin Ayları : Eylül, Ekim, Kasım");
             }
             else {
                 Console.WriteLine("İstediğiniz mevsimi düzgün yazınız.");
                 goto baslangic;
             }*/
            #endregion

            #region switch-Case
            /*
            //Koşul bloğudur karşılaştırma sadece eşitlikten ibarettir örneğin
            Console.WriteLine("Adınız:");
            string deger=Console.ReadLine();

            switch (deger)
            {
                case "Salih":
                    Console.WriteLine("Hoşgeldin {0}",deger);
                    break;

                case "Cihat":
                    Console.WriteLine("Hoşgeldin {0}", deger);
                    break;

                case "Devrim":
                    Console.WriteLine("Hoşgeldin {0}", deger);
                    break;
                case "Büşra":
                    Console.WriteLine("Hoşgeldin {0}", deger);
                    break;

                case "Neval":
                    Console.WriteLine("Hoşgeldin {0}", deger);
                    break;
                case "İlker":
                    Console.WriteLine("Hoşgeldin {0}", deger);
                    break;

                default:
                    Console.WriteLine("Sen Kimsin? {0}", deger);
                    break;
            }
            */
            #endregion
            #region mevsim switch-case
            /*
            start:
            Console.WriteLine("Bir Mevsim Giriniz");
            string mevsim = Console.ReadLine();
            switch (mevsim)
            {
                case "Kış":
                    Console.WriteLine("Kış Mevsiminin Ayları: Aralık, Ocak, Şubat");
                    break;
                case "Yaz":
                    Console.WriteLine("Yaz Mevsiminin Ayları: Haziran, Temmuz, Ağustos");
                    break;
                case "Sonbahar":
                    Console.WriteLine("Sonbahar Mevsiminin Ayları: Eylül, Ekim, Kasım");
                    break;
                case "İlkbahar":
                    Console.WriteLine("İlkbahar Mevsiminin Ayları: Mart, Nisan, Mayıs");
                    break;

                default:
                    Console.WriteLine("Doğru bir mevsim değeri giriniz.");
                    break;
            }
            Console.WriteLine();
            goto start;
            */
            #endregion


            #region Haftanın Günleri
            /*
            int haftaningunu;
           start:
            Console.WriteLine("1-7 arasında rakam giriniz");
            haftaningunu = Convert.ToInt32(Console.ReadLine());

            switch (haftaningunu)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("1-7 Arasında bir sayı girmeliydin dostum.");
                    break;
            }
            Console.WriteLine();
            goto start;
            */
            #endregion

            #region Switch-Case ile 4 işlem 
            /*
        start:
            double sayi1, sayi2, sonuc;
            string secim;
            Console.WriteLine("Lütfen 1.sayıyı giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sayıyı giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz(+ - * /)");
            secim = Console.ReadLine();

            switch (secim)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Toplama Sonucu :{0}", sonuc);
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Çıkartma Sonucu :{0}", sonuc);
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Çarpma Sonucu :{0}", sonuc);
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Bölme Sonucu :{0}", sonuc);
                    break;
                default:
                    Console.WriteLine("4 İşlem dışında seçim yapmayınız");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("***************************************");
            Console.WriteLine("***************************************");
            Console.WriteLine();
            goto start;
            */
            #endregion

            #region odev2
            //111112222333445
            //555554444333221
            /*  int sonuc = 5;
              for (int i = 1; i <= 5; i++)
              {
                  for (int j = sonuc; j > 0; j--)
                  {
                      Console.Write(i);
                  }
                  sonuc--;
              }
            */
            /*
              int sonuc = 0;
              for (int i = 5; i > 0; i--)
              {
                  for (int j = sonuc; j < 5; j++)
                  {
                      Console.Write(i);
                  }
                  sonuc++;
              }
            */

            /*
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("302");
            }*/
            //   var 
            //  const
            /*
                        for (int i = 1; i < 6; i++)
                        {
                            for (int j = 6; j > i; j--)
                            {
                                Console.Write(i);
                            }
                        }

                        Console.WriteLine();
                        for (int i = 5; i > 0; i--)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(i);
                            }
                        }

                        */
            #endregion
            /*
            int toplam = 0;
            for (int i = 1; i <= 50; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine(toplam);*/
            /*
                        int toplam = 0;
                        for (int i = 1; i <= 50; i=i+2)
                        {
                            toplam = toplam + i;
                        }
                        Console.WriteLine(toplam);*/
            /*
            int a = 77;
            for (int i = 9; i < 77; i=i+9)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */
            //
            /*
            for (int i = 0; i <5; i++)
            {
                for (int j = 4-i; j > i; j--)
                {
                    Console.Write(" ");
                }
                for ( k = 0; k < 11; i++)
                {
                    Console.WriteLine("*");

                }
                
            }
            */
            //int a=1, b=0, c=0;
            //for (int i = 0; i < 10; i++)
            //{

            //    c = a + b;
            //    a = b;
            //    b = c;

            //    Console.WriteLine(c);
            //}


            //int total = 0;
            //for (int number = 2; number < 100; number++)
            //{
            //bool isPrime = true;

            //for (int i = 2; i < number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        isPrime = false;
            //    }
            //}
            //    if (isPrime == true)
            //    {
            //        total += number;       
            //    }
            //}
            //Console.WriteLine("toplam: " + total);
            //Console.ReadLine();
            //int toplam = 0;
            //for (int i = 2; i < 50; i=i+2)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine("Toplam: "+ toplam);

            //int a = 1;
            //int b = 1;
            //int c =0;
            //for (int i = 0; i < 10; i++)
            //{
            //    c = a+b;
            //    a = b;
            //    b = c;
            //    Console.WriteLine(c);

            //}

            #region While döngüsü -iken
            /*
            int i = 0;
            while (i < 5 )
            {
                Console.WriteLine(i);
                i++;
            }
            */
            #endregion
            #region 1-50  sayıları yazdırın
            // int i = 1;
            //while (i<50)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion
            #region 1-50  sayıları topla
            //int j = 1;
            //int toplam = 0;
            //while (j < 50)
            //{
            //    toplam += j;
            //    j++;
            //}
            //Console.WriteLine("Toplam: "+toplam);
            #endregion
            //int j = 0;
            //int toplam = 0;
            //while (j < 10)
            //{
            //    // toplam += j;
            //    if (j%2!=0)
            //    {
            //        Console.WriteLine(j);
            //    }

            //    j++;
            //}
            // Console.WriteLine("Toplam: " + toplam);
            /*
            while (i < 10)
            {
                

                i++;
            }*/

            //klavyeden girilen bir sayının faktöryelini alma
            //long faktoryel=1;
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //while (i<=sayi)
            //{
            //    faktoryel = faktoryel * i;
            //    i++;
            //}
            //Console.WriteLine("Faktöryel sonucu: "+faktoryel);


            #region foreach:
            /*
            string[] Listemiz = {"Salih","devrim","muhammed","burak"};
            foreach (string eleman in Listemiz)
            {
                Console.WriteLine(eleman);
            }
            */
            #endregion

            #region Diziler
            //int[] sayilar = { 1, 2, 3, 4 };
            //int[] sayilar2 = new int[5];
            //Console.WriteLine(sayilar[0]);
            //Console.WriteLine(sayilar.Length);//dizi uzunluğunu verir.

            #endregion
            #region eleman sayısı klavyeden girile diziyi oluşturma ve elemanlarını doldurup, çıktısını gösterme

            /*
            Console.WriteLine("Dizi kaç elemanlı olsun?");
            int elemansayısı = Convert.ToInt32(Console.ReadLine());
            int[] dizim = new int[elemansayısı];
            for (int i = 0; i < elemansayısı; i++)
            {
                Console.WriteLine("Dizinin {0}. Elemanını Yazınız.",i+1);
                dizim[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Dizimiz {0} elemanlıdır",elemansayısı);
           for (int i = 0; i < elemansayısı; i++)
            {
                Console.WriteLine("{0}. Elemanımız: {1}", i+1, dizim[i]);
            }*/
            #endregion
            #region isim yazdır ve forla ekrana yazdır.
            //string[] dizim = {"Devrim","Salih","Muhammet","İlker","Burak" };
            //for (int i = 0; i < dizim.Length; i++)
            //{
            //    Console.WriteLine(dizim[i]);
            //}
            #endregion
            #region tekboyutludizilere
            //Console.WriteLine("**** for");
            //string[] dizi = { "Mehmet", "Bedir", "Bedirhan", "Sena" };
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}
            //Console.WriteLine("**** foreach");
            //foreach (var item in dizi)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**** while");
            //int k = 0;
            //while (k < dizi.Length)
            //{
            //    Console.WriteLine(dizi[k]);
            //    k++;
            //}

            //Console.WriteLine("**** tek tek yazma");
            //Console.WriteLine(dizi[0]);
            //Console.WriteLine(dizi[1]);
            //Console.WriteLine(dizi[2]);
            //Console.WriteLine(dizi[3]);
            #endregion
            //string ad;
            //string soyad;

            //while (true)
            //{
            //    Console.Write("Lütfen adınızı giriniz: ");
            //    ad = Convert.ToString(Console.ReadLine());
            //    Console.Write("Lütfen soyadınızı giriniz: ");
            //    soyad = Convert.ToString(Console.ReadLine());
            //    Console.WriteLine(ad + " " + soyad + " Hoş geldiniz.");
            //    Console.WriteLine();
            //}



            #region boy kilo indexi
            //double boy, kilo,durum;
            //string cinsiyet;
            //while (true)
            //{
            //Console.WriteLine("Lütfen cinsiyetinizi giriniz");
            //cinsiyet = Console.ReadLine();
            //Console.WriteLine("Lütfen kilonuzu giriniz");
            //kilo = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Lütfen boyunuzu giriniz");
            //boy = Convert.ToDouble(Console.ReadLine());
            //durum = (kilo / (boy * boy)) * 10000;

            //if (durum < 18.5)
            //{
            //    Console.WriteLine("Vucüt kitle indexiniz : {0} , Zayıfsınız", durum);
            //} else if(durum>=18.5 && durum<24.9){
            //    Console.WriteLine("Vucüt kitle indexiniz : {0} , Normalsiniz", durum);
            //} else if (durum >= 24.9 && durum < 29.9)
            //{
            //    Console.WriteLine("Vucüt kitle indexiniz : {0} , Aşırı Kilolusunuz", durum);
            //} else {
            //    Console.WriteLine("Vucüt kitle indexiniz : {0} , Obezsiniz", durum);
            //}
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}


            // erkekler için
            // 18,5'ten küçükse zayıf'
            //18,5 ve 24,9 normal
            //24,9 ve 29,9 aşırı kilolu
            // 29,9 obez

            #endregion
            #region fonksiyonlar


            #endregion

            Console.ReadLine();
        }
    }
}

