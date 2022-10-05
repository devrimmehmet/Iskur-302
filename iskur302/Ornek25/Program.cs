using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek25
{
    internal class Program
    {
        void DiziRandomAtama()
        {
            int elemanSayisi = 0;
            try
            {
                Console.WriteLine("Lütfen dizinin eleman sayısını giriniz.");
                 elemanSayisi=int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Lütfen int türünde sayı giriniz.");
            }
            Random sayiRandom = new Random();
            int[] dizi=new int[elemanSayisi];
            int sayi = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
               
                sayi= sayiRandom.Next(5,1000);
              
                if (sayi%5==0 && sayi%2!=0)
                {
                    dizi[i]=sayi;
                }
                else
                {
                    i--;
                }

            }
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }


        }
        static void Main(string[] args)
        {
            /*Eleman sayısı klavyeden girilerek bir sayısal dizi oluşturulacaktır. 
             * Diziye 0-1000 arasında rastgele tek ve 5(beş) in katlarında değer atanacaktır. 
             * Diziye değer atandıktan sonra dizi elemanları ekrana yazdırılacaktır. 
             * Bu işlemin kodları yazınız.*/
            Program program = new Program();
            program.DiziRandomAtama();
            Console.ReadLine();
        }
    }
}
