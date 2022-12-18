using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    internal class Program
    {
        
        private void Toplama()
        {
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz.");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz.");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Toplama İşlemi Sonucu: " + (sayi1 + sayi2));
        }
        private void Cikarma()
        {
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz.");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz.");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Çıkarma İşlemi Sonucu: " + (sayi1 - sayi2));
        }
        private void Carpma()
        {
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz.");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz.");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Çarpma İşlemi Sonucu: " + (sayi1 * sayi2));
        }
        private void Bolme()
        {
            Console.WriteLine("Lütfen 1. Sayıyı Giriniz.");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sayıyı Giriniz.");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Bölme İşlemi Sonucu: " + (sayi1 / sayi2));
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //geriye değer döndürmeyen parametresiz

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.(+,-,/,*)");
            string islem = Console.ReadLine();
            switch (islem)
            {
                case "+":
                    program.Toplama();
                    break;
                case "-":
                    program.Cikarma();
                    break;
                case "/":
                    program.Bolme();
                    break;
                case "*":
                    program.Carpma();
                    break;
            }
            Console.ReadLine();
        }
    }
}
