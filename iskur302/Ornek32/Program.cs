using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek32
{
    internal class Program
    {
       public  string KelimeBul(string cumle, int kelimeSirasi)
        {
            
            string[] kelimeler = cumle.Split(' ');
           
            

            return kelimeler[kelimeSirasi];
        }
        static void Main(string[] args)
        {
            /*string KelimeBul(string cumle, int kelimeSirasi) adında bir metot tanımlanacaktır.
             * Metot a parametre olarak bir cümle ve bir sayı yollanacaktır. 
             * Metot geriye cümlenin istenilen sıradaki kelimesini geri döndürecektir. 
             * Bu özelliklerde KelimeBul adında bir metot tanımlayınız*/

            Program program = new Program();
            Console.WriteLine(program.KelimeBul("devrim mehmet pattabanoğlu", 1));
            
            Console.ReadLine();
        }
    }
}
