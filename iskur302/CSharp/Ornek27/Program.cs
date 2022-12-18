using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek27
{
    internal class Program
    {
        int  KarelerinToplami(int sayi)
        {
            if (sayi<1)
            {
                Console.WriteLine("Hesaplama İşlemi Yapılamaz");
                return -1;
            }
            else
            {
                int sonuc = 0;
                for (int i = 1; i <= sayi; i++)
                {
                    sonuc += (i * i);
                }
                return sonuc;
            }
           
        }
        static void Main(string[] args)
        {
            /*KarelerinToplami(int sayi) adlı kendini çağıran bir metot yazınız. 
             * Metot kendisine parametre olarak yollanan sayıdan bire(1) kadar olan sayıların karelerinin toplamını bulup geri döndürecektir.
             * Eğer parametre olarak yollanan sayı 0 veya negatif ise “Hesaplama Ġşlemi Yapılamaz.” 
             * ġeklinde bir mesajı ekrana yazdırıp geriye -1 döndürecektir.*/
            Program program = new Program();
           
            Console.WriteLine(program.KarelerinToplami(11));
            Console.ReadLine();
        }
    }
}
