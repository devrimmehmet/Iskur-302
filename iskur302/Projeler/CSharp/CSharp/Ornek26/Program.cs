using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20 öğrenciye ait Vize ve Final bilgileri rastgele atandıktan sonra,
             * her bir öğrencinin ortalamasını hesaplanacak
             * ve ekrana eğer öğrenci 70 ve üzeri ise “Geçti”,
             * değilse “Kaldı” yazacak programı çok boyutlu dizi kullanarak yazınız.*/
            int[,] dizi = new int[20,3];
            Random sinav = new Random();

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                
                    
                    dizi[i,0]= sinav.Next(0, 101); // vize
                    dizi[i,1] = sinav.Next(0, 101); // final
                    dizi[i,2] = (dizi[i, 0] + dizi[i, 1])/2; // ortalama
                    string sonuc = "Geçti";
                    if (dizi[i, 2] < 70)
                    {
                        sonuc = "Kaldı";
                    }
                    Console.WriteLine($"{i+1}.Öğrenci Vize Notu:{dizi[i, 0]} Final Notu:{dizi[i, 1]} Ortalama:{dizi[i, 2]} Sonuç:{sonuc} ");
                
            }
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
