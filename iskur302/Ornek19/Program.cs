using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek19
{
    internal class Program
    {
        void MaasHesapla()
        {
            double ahmetBaslangicMaas = 0;
            double hasanBaslangicMaas = 0;
            double girilenAy = 0;
            bool durum = true;
            while (durum)
            {
                try
                {
                    start:
                    Console.WriteLine("Ahmetin Başlangıç ücretini giriniz.");
                     ahmetBaslangicMaas = double.Parse(Console.ReadLine());
                    if (ahmetBaslangicMaas <= 0)
                    {
                        Console.WriteLine("Maaş Bilgisi Negatif olamaz.");
                        goto start;
                    }
                    durum = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen double türünde veri giriniz ve pozitif olsun.");
                }
            }
            durum = true;
            while (durum)
            {
                try
                {
                start:
                    Console.WriteLine("Hasanın Başlangıç ücretini giriniz.");
                     hasanBaslangicMaas = double.Parse(Console.ReadLine());
                    if (hasanBaslangicMaas <= 0)
                    {
                        Console.WriteLine("Maaş Bilgisi Negatif olamaz.");
                        goto start;
                    }
                    durum = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen double türünde veri giriniz ve pozitif olsun.");
                }
            }
            durum = true;
            while (durum)
            {
                try
                {
                start:
                    Console.WriteLine("Kaç aylık verileri listelemek istiyorsunuz?");
                     girilenAy = double.Parse(Console.ReadLine());
                    if (girilenAy <= 0)
                    {
                        Console.WriteLine("Ay Bilgisi Negatif olamaz.");
                        goto start;
                    }
                    durum = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen double türünde veri giriniz ve pozitif olsun.");
                }
            }
            Hesapla(ahmetBaslangicMaas,hasanBaslangicMaas, girilenAy);

        }
        void Hesapla(double AhmetMaas,double HasanMaas,double AyBilgisi)
        {
            Console.WriteLine();
            Console.WriteLine("Ahmetin Başlangıç Maaşı:{0}",AhmetMaas);
            Console.WriteLine("Hasanın Başlangıç Maaşı:{0}", HasanMaas);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < AyBilgisi; i++)
            {
                if (i%2==0)
                {
                    AhmetMaas=AhmetMaas*1.50;
                    Console.WriteLine($"Ahmetin {i+1}.ay maaş bilgisi: {AhmetMaas} TL (+%50)");
                }
                else
                {
                    AhmetMaas = AhmetMaas * 0.75;
                    Console.WriteLine($"Ahmetin {i + 1}.ay maaş bilgisi: {AhmetMaas} TL (-%25)");
                }
               
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < AyBilgisi; i++)
            {
               
                    HasanMaas = HasanMaas * 1.25;
                    Console.WriteLine($"Hasanın {i + 1}.ay maaş bilgisi: {HasanMaas} TL (+%25)");
               

            }
            Console.WriteLine();
            Console.WriteLine();
            if (HasanMaas>AhmetMaas)
            {
                Console.WriteLine("Hasanın Maaşı Ahmetin Maaşından {0} aylık süre sonunda {1} TL farkla fazladır.",AyBilgisi,(HasanMaas-AhmetMaas));
            }
            else if(HasanMaas == AhmetMaas)
            {
                Console.WriteLine("Hasanın Maaşı Ahmetin Maaşına {0} aylık süre sonunda eşittir.", AyBilgisi);
            }
            else
            {
                Console.WriteLine("Ahmetin Maaşı Hasanın Maaşından {0} aylık süre sonunda {1} TL farkla fazladır.", AyBilgisi, (AhmetMaas - HasanMaas));
            }
        }
        static void Main(string[] args)
        {
            // aynı firmadaki ahmet ve hasan iki işçidir bunlardan birinin AHmet=maas= 1 ay %50 artmakta sonraki ay %25 azalmaktadır.
            // hasanın ise ücreti her ay %25 artmaktadır. her ikisininde yılbaşında başlangıç ücretleri ve hesaplanacak ay bilgisi klvyeden girildiktne sonra ay ay ücretlerinin ne olacağını ve en sonunda hangi işçinin daha fazla veya eşit ücret alacağını hesaplayan programı yazınız.
            Program program = new Program();
            program.MaasHesapla();
            Console.ReadLine();


        }
    }
}
