using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ornek13
{
    public class Product
    {
       public double komisyon = 0;
        public  void Sell(double a)
        {
            
                    if (a<=60)
                    {
                        komisyon = komisyon + (a*0.03);
                        Console.WriteLine($"Toplam Komisyon Tutarı: {komisyon}TL Bu ürüne ait komisyon: {a * 0.03}TL(%3)");
                    }
                    else if (a>60)
                    {
                        komisyon = komisyon + (a * 0.02);
                        Console.WriteLine($"Toplam Komisyon Tutarı: {komisyon}TL Bu ürüne ait komisyon: {a * 0.02}TL(%2)");
                    }

           
        }
        public void Menu()
        {
            
            while (true)
            {
                try
                {
                    Console.WriteLine("Lütfen Ürün Tutarını Giriniz.Yada 0'a basıp sıfırlama işlemi yapınız.");
                    double a = Convert.ToInt32(Console.ReadLine());
                    if (a==0)
                    {
                        Console.WriteLine("Toplam Komisyon Tutarı = {0}",komisyon);
                        Console.WriteLine("Kasa Sıfırlandı.");
                        komisyon = 0;
                    }
                    Sell(a);
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen Sayı Giriniz");

                }
               
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // bir komisyoncu sattığı mallardan fiyatı 60 tlye kadar olanlardan %3 kar  daha fazla olanlarda ise %2 komisyon almaktadır. klavyeden teker teker girilen 5 malın komisyonlarını bulup ekrana yazdıran ve en sonunda toplam komisyonu ekrana yazdıran.
            Product product = new Product();
            product.Menu();
            Console.ReadLine();
        }
    }
}
