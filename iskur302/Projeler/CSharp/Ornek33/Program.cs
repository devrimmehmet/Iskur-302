using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek33
{
    internal class Program
    {
        string EnUzunKelime(params string[] yeniDizi )
        {
            string enuzun = "";
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                if (enuzun.Length < yeniDizi[i].Length)
                {
                    enuzun = yeniDizi[i];
                }
            }
            Console.WriteLine("En Uzun Kelimenin Karakter Sayısı: {0}",enuzun.Length);
            return enuzun;
        }
        static void Main(string[] args)
        {
            /*Kendisine değişken sayıda parametre yollanan kelimelerden 
             * en uzun kelimeyi bulup geri döndüren “EnUzunKelime ” adındaki metodu yazınız.
             * */
            Program program = new Program();
            Console.WriteLine(program.EnUzunKelime("2022 2023 sezonu arasında","Şampiyon Fenerbahçeeeeeeeeeeeeeeeeeeeeeeeeeeeee"));
            Console.ReadLine();
        }
    }
}
