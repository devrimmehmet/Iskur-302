using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesapmakinesi
{
    internal class Program
    {
        private void Toplama(double sayi1, double sayi2) {
            Console.WriteLine("Toplama İşlemi Sonucu: "+ (sayi1+sayi2));
        }
        private void Cikarma(double sayi1, double sayi2)
        {
            Console.WriteLine("Çıkarma İşlemi Sonucu: " + (sayi1 - sayi2));
        }
        private void Carpma(double sayi1, double sayi2)
        {
            Console.WriteLine("Çarpma İşlemi Sonucu: " + (sayi1 * sayi2));
        }
        private void Bolme(double sayi1, double sayi2)
        {
            Console.WriteLine("Bölme İşlemi Sonucu: " + (sayi1 / sayi2));
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //geriye değer döndürmeyen parametreli
            double sayi1 = 0;
            double sayi2 = 0;
            bool state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen 1. Sayıyı Giriniz.");
                     sayi1 = double.Parse(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen int bir sayı giriniz.");
                }
            }
            state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen 2. Sayıyı Giriniz.");
                     sayi2 = double.Parse(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen int bir sayı giriniz.");
                }
            }
            start:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.(+,-,/,*)");
            string islem =Console.ReadLine();
            switch (islem)
            {
                case "+":
                    program.Toplama(sayi1, sayi2);
                    break;
                case "-":
                    program.Cikarma(sayi1, sayi2);
                    break;
                case "/":
                    program.Bolme(sayi1, sayi2);
                    break;
                case "*":
                    program.Carpma(sayi1, sayi2);
                    break;
                default:
                    Console.WriteLine(  "Lütfen doğru seçim yapınız.");
                    break;
            }    
            Console.ReadLine();

        }
    }
}
