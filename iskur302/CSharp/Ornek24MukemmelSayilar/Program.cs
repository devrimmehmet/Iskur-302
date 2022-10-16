using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek24MukemmelSayilar
{
    internal class Program
    {
       static void MukemmelSayi(int sayi)
        {
            int toplam = 0;
            for (int i = 1; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    toplam += i;
                }

            }
            if (toplam == sayi)
            {
                Console.WriteLine(" {0} Mükemmel Sayıdır.",sayi);
            }
            else
            {
                Console.WriteLine(" {0} Mükemmel Sayı Değildir.", sayi);
            }
        }
        int SayiAl()
        {
            int sayi=0;
            try
            {
                Console.WriteLine("Lütfen Bir sayı giriniz.");
                sayi = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen int türünde sayı giriniz.");
            }
           
            return sayi;
        }
        static void Main(string[] args)
        {
            /*Kendisi hariç bütün pozitif çarpanları (tam bölenleri) toplamı,
             * yine kendisine eşit olan sayılara “mükemmel sayı” denir.
             * Örneğin 6=1+2+3 ve 28=1+2+4+7+14 gibi. 
             * Buna göre klavyeden girilen bir tamsayının “mükemmel sayı” olup olmadığını kontrol eden MukemmelSayi adında bir metot tanımlayınız. 
             * Metot eğer sayı mükemmel sayı ise ekrana “Mükemmel Sayıdır” değilse “Mükemmel Sayı DEĞĠLDĠR” yazan programın kodlarını yazınız.
             * ( static void MukemmelSayi(int sayi) )
             * */
            Program program = new Program();    
            MukemmelSayi(program.SayiAl());
            Console.ReadLine();
            
        }
    }
}
