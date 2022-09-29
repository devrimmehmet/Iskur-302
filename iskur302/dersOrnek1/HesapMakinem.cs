using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dersOrnek1
{
    public class HesapMakinem
    {
        void Toplama(double number1, double number2)
        {
            Console.WriteLine("Toplama Sonucu: " + (number1 + number2));
        }
        void Cikarma(double number1, double number2)
        {
            Console.WriteLine("Çıkarma Sonucu: " + (number1 - number2));
        }
        void Carpma(double number1, double number2)
        {
            Console.WriteLine("Çarpma Sonucu: " + (number1 * number2));
        }
        void Bolme(double number1, double number2)
        {
            Console.WriteLine("Çarpma Sonucu: " + (number1 / number2));
        }
        public void HesapMakinesi()
        {
            bool state = true;
            while (state)
            {


                Console.WriteLine("Lütfen Bir Sayı Giriniz.");
                double number1 = int.Parse(Console.ReadLine());
                Random random = new Random();
                double number2 = random.Next(1, 100);

                HesapMakinem program = new HesapMakinem();

                Console.WriteLine("Lütfen Yapmak istediğiniz işlemi giriniz. ( +,-,/,*)");
                string durum = Console.ReadLine();
                switch (durum)
                {
                    case "+":
                        Console.WriteLine("Random Atanan Sayımız: {0}", number2);
                        program.Toplama(number1, number2);
                        break;
                    case "-":
                        Console.WriteLine("Random Atanan Sayımız: {0}", number2);
                        program.Cikarma(number1, number2);
                        break;
                    case "*":
                        Console.WriteLine("Random Atanan Sayımız: {0}", number2);
                        program.Carpma(number1, number2);
                        break;
                    case "/":
                        Console.WriteLine("Random Atanan Sayımız: {0}", number2);
                        program.Bolme(number1, number2);
                        break;

                    default:
                        state = false;
                        break;
                }


            }
        }
    }
}
