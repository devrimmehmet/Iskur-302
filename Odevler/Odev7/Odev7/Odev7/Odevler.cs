using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev7
{
    internal class Odevler
    {
        public void Menu()
        {
            

            bool dongu = true;
            while (dongu)
            {
                Console.Clear();
                Console.WriteLine("Yapılacak İşlemi Seçiniz.");
                Console.WriteLine("1 - 0'dan Girilen Sayıya Kadar 9'un Katlarını Ekrana Yazdırma");
                Console.WriteLine("2 - Girilen Sayı Asal mı?");
                Console.WriteLine("3 - Girilen Sayının Faktöryel Hesabını Yap");
                Console.WriteLine("4 - Girilen karakterin harf mi , sayı mı yoksa özel karakter mi olduğunu tespit etme");
                Console.WriteLine("5 - Girilen 3 sayının en küçüğünü bulmak");
                Console.WriteLine("6 - Girilen harfin büyük mü küçük mü olduğunu bulma");
                Console.WriteLine("7 - Katsayıları girilen ikinci dereceden denklemin köklerini bulma");
                Console.WriteLine("8 - Çıkış Yap");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        DokuzunKatlari();
                       
                        break;
                    case "2":
                        AsalSayiKontrolu();
                   
                        break;
                    case "3":
                        FaktoryelHesapla();
                      
                        break;
                    case "4":
                        HarfKarakterOzel();
                     
                        break;
                    case "5":
                        EnKucukBul();
                       
                        break;
                    case "6":
                        BuyukKucukHarf();
                       
                        break;
                    case "7":
                        DenkleminKokleri();

                        break;
                    case "8":
                        dongu = false;
                        Console.WriteLine("Güle Güle");
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        public void DenkleminKokleri()
        {
        // Klavyeden girilen 2.dereceden denklemin köklerini bulma
        
            double a=0, b=0, c=0, delta, x1, x2;
            Console.WriteLine("ax2 + bx + c = 0 denklemi için");
            bool state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("a katsayısını giriniz: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
            state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("b katsayısını giriniz: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
            state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("c katsayısını giriniz: ");
                    c = Convert.ToInt16(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }

            delta = b * b - 4 * a * c;
            if (delta >= 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("1.Kök = {0} ", x1);
                Console.WriteLine("2.Kök = {0} ", x2);
            }else if (delta < 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("Tek Kök = {0}", x1);
            }
            else
            {
                Console.WriteLine("Kök Yok");
            }
            Console.WriteLine();

            Console.ReadLine();
            Menu();

        }
        public void BuyukKucukHarf()
        {
       
            char klm= ' ';

            bool state = true;
            while (state)
            {
                try
                {basadon:
                    Console.WriteLine("Lütfen sadece bir harfe basınız");
                    klm = Convert.ToChar(Console.ReadLine());
                    if (klm >= 'A' & klm <= 'Z')
                    {
                        state = false;
                    }else if ((klm >= 'a' & klm <= 'z'))
                    {
                        state = false;
                    }else
                    {
                        Console.WriteLine("Hatalı Girdiniz : Sadece bir harf Giriniz");
                       goto basadon;
                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen sadece bir harf girişi yapınız.");
                }

            }

            
            if ((klm >= 'A' & klm <= 'Z'))
            {
                Console.WriteLine("Büyük harf");
            }
            else if ((klm >= 'a' & klm <= 'z'))
            {
                Console.WriteLine("Küçük harf");
            }

            Console.ReadLine();
            Menu();
        }
        public void EnKucukBul()
        {
        // Kullanıcı tarafından klavyeden girilen 3 farklı sayıdan en küçüğünü bulmak
        
            int a=0, b=0, c=0;

            bool state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Birinci sayıyı giriniz: ");
                    a = Convert.ToInt16(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
             state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("İkinci sayıyı giriniz: ");
                    b = Convert.ToInt16(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
             state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Üçüncü sayıyı giriniz: ");
                    c = Convert.ToInt16(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece integer sayı girişi yapınız.");
                }
            }
            
           
            if (a < b && a < c)
            {
                Console.WriteLine("{0} sayısı en küçüktür", a);
            }
            if (b < a && b < c)
            {
                Console.WriteLine("{0} sayısı en küçüktür", b);
            }
            if (c < a && c < b)
            {
                Console.WriteLine("{0} sayısı en küçüktür", c);
            }

            Console.ReadLine();
            Menu();
        }
        public void HarfKarakterOzel()
        {
        // Klavyede girilen karakterin harf mi , sayı mı yoksa özel karakter mi olduğunu tespit etme
       
            char klm=' ';
            bool state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen klavyede bir tuşa(Tek Karakter) basınız ");
                    klm = Convert.ToChar(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen sadece bir karakter girişi yapınız.");
                }
                
            }
            
            if ((klm > 'A' & klm < 'Z') || (klm > 'a' & klm < 'z'))
            {
                Console.WriteLine("Harf tuşuna basıldı");
            }
            if (klm >= '0' & klm <= '9')
            {
                Console.WriteLine("Rakam tuşuna basıldı");
            }
            if (!((klm >= 'A' & klm <= 'Z') || (klm >= 'a' & klm <= 'z' || (klm >= '0' && klm <= '9'))))
            {
                Console.WriteLine("Özel karakter girildi");
            }

            Console.ReadLine();
            Menu();
        }
        public void FaktoryelHesapla()
        {

            int sayi=0;
            int faktoriyel = 1;
            bool state = true;
            while (state)
            {
                try
                {
                pozitif:
                    Console.WriteLine("Sayıyı Giriniz: ");
                    sayi = Convert.ToInt16(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Lütfen sadece pozitif ve integer sayı girişi yapınız.");
                        goto pozitif;
                    }
                    if (sayi >= 0)
                    {
                        state = false;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece pozitif ve integer sayı girişi yapınız.");
                }
            }
            while (sayi >= 1)
            {
                faktoriyel = faktoriyel * sayi;
                sayi--;
            }
            Console.WriteLine("Sonuç: " + faktoriyel);
            Console.ReadLine();
            Menu();
        }
        public void AsalSayiKontrolu()
        {
            int sayi = 0;
            bool state = true;
            while (state)
            {


                try
                {
                pozitif:
                    Console.WriteLine("Sayıyı Giriniz: ");
                    sayi = Convert.ToInt16(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Lütfen sadece pozitif ve integer sayı girişi yapınız.");
                        goto pozitif;
                    }
                    if (sayi >= 0)
                    {
                        state = false;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece pozitif integer sayı girişi yapınız.");
                }
            }

            bool durum = true;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    durum = false;
                }
            }
            if (sayi == 2)
            {
                durum = true;
            }
            if (sayi == 1)
            {
                durum = false;
            }
            if (sayi == 0)
            {
                durum = false;
            }
            if (durum)
            {
                Console.WriteLine("Girmiş olduğunuz sayı asal sayıdır");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayı asal sayı değildir");
            }
            Console.ReadLine();
            Menu();
        }
        public void DokuzunKatlari()
        {

            int sayi = 0;
            bool state = true;
            while (state)
            {


                try
                {
                pozitif:
                    Console.WriteLine("Sayıyı Giriniz: ");
                    sayi = Convert.ToInt16(Console.ReadLine());
                    if (sayi < 0)
                    {
                        Console.WriteLine("Lütfen sadece pozitif ve integer sayı girişi yapınız.");
                        goto pozitif;
                    }
                    if (sayi >= 0)
                    {
                        state = false;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen sadece pozitif integer sayı girişi yapınız.");
                }
            }
            Console.WriteLine("SONUÇ;");
            for (int i = 1; i <= sayi; i++)
            {
                if (i % 9 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            Menu();
        }
    }
}
