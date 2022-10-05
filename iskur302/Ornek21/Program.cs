using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek21
{
    internal class Program
    {
        void OtoparkUcretiHesapla()
        {
        start:
            double toplamucret = 0;
            Console.WriteLine("Lütfen hangi tür aracınız olduğunu yazınız.(otomobil,minübüs,ticari))");
            string secim = Console.ReadLine();
            if (secim=="otomobil")
            {

            }else if (secim == "minübüs")
            {

            }
            else if (secim == "ticari")
            {

            }
            else
            {
                Console.WriteLine("Böyle bir aracı otoparka alamam.");
                goto start;
            }
                
            double beklemeSuresi = 0;
            bool durum = true;

            while (durum)
            {
                try
                {
                    Console.WriteLine("Lütfen kaç saat parka bırakacağınızı yazınız.");
                     beklemeSuresi =double.Parse( Console.ReadLine());
                    durum = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Hatalı Giriş Yaptınız.");
                }
            }
            if (secim == "otomobil")
            {
                toplamucret = 5;
               double total = 5;
                if (beklemeSuresi==1)
                {
                    toplamucret = 5;
                }else if (beklemeSuresi>1)
                {
                    for (int i = 1; i < beklemeSuresi; i++)
                    {
                        toplamucret = toplamucret*1.2;
                        total = total + toplamucret;
                    }
                    
                }
                Console.WriteLine("Toplam {0} saat için {1}",beklemeSuresi,total);
                
            }
            else if (secim == "minübüs")
            {
                double total = 6;
                if (beklemeSuresi == 1)
                {
                    toplamucret = 6;
                }
                else if (beklemeSuresi > 1)
                {
                    for (int i = 1; i < beklemeSuresi; i++)
                    {
                        toplamucret = toplamucret * 1.215;
                      //  total = total + toplamucret;
                    }
                }
                Console.WriteLine("Toplam {0} saat için {1}", beklemeSuresi, toplamucret);
            }
            else if (secim == "ticari")
            {
                double total = 6.5;
                if (beklemeSuresi == 1)
                {
                    toplamucret = 5;
                }
                else if (beklemeSuresi > 1)
                {
                    for (int i = 1; i < beklemeSuresi; i++)
                    {
                        toplamucret = toplamucret * 1.25;
                        //total = total + toplamucret;
                    }
                }
                Console.WriteLine("Toplam {0} saat için {1}", beklemeSuresi, toplamucret);
            }
            else
            {
                Console.WriteLine("Böyle bir aracı otoparka alamam.");
                goto start;
            }
        }
        static void Main(string[] args)
        {
            /* Bir otoparka park eden taksinin 1 saati 5TL,Taksi 1 saatten sonraki her saat başı için %20 daha fazla,
             * minibüsün 1 saati 6TL,minibüs 1 saatten sonraki her saat başı için toplamda %21.5
             * ticari aracın 1 saati 6.5TL dir. ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır.
             *   Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.
             * */
            Program program = new Program();
            program.OtoparkUcretiHesapla();
            Console.ReadLine();
        }
    }
}
