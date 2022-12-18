using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek35
{
    internal class Program
    {
        public string EnKisaKelime(params string[] yeniDizi)
        {
            string enKisa = yeniDizi[0];
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                if (enKisa.Length > yeniDizi[i].Length)
                {
                    enKisa = yeniDizi[i];
                }
            }
            Console.WriteLine("En Kısa Kelimenin Karakter Sayısı: {0}", enKisa.Length);
            return enKisa;
        }
        static void Main(string[] args)
        {
            /*Kendisine değişken sayıda parametre yollanan dizideki her bir elemanı bir kelime olan dizinin en kısa kelimsini ekrana yazıp geriye döndüren “EnKisaKelime” adındaki metodu yazınız.*/
            Program program = new Program();
            Console.WriteLine(program.EnKisaKelime("devrim", "Fb", "devrimmehmet"));


            Console.ReadLine();

        }
    }
}
