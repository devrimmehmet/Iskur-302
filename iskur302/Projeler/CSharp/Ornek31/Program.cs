using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ornek31
{
    internal class Program
    {
       public int BuyukSayi(params int[] dizi )
        {
           
            int enBuyuk = dizi[0];
            for (int j = 0; j < dizi.Length; j++)
            {
                if (enBuyuk < dizi[j])
                {
                    enBuyuk= dizi[j];
                }
            }
            return enBuyuk;
        }
        public int KucukSayi(params int[] dizi)
        {
           
            
            int enKucuk = dizi[0];

            for (int j = 0; j < dizi.Length; j++)
            {
                if (enKucuk > dizi[j])
                {
                    enKucuk = dizi[j];
                }
            }
            
            return enKucuk;
        }

        static void Main(string[] args)
        {
            /*Kendisine değişken sayıda parametre olarak yollanan rakamlardan oluşabilecek en büyük ve en küçük sayıları oluşturup
             * geriye döndüren int BuyukSayi(………) ve int KucukSayi(……) adındaki metotları yazınız.
             Örnek: BuyukSayi(1,5,3,7,8,2,9) > 9875321 KucukSayi(1,5,3,7,8,2) > 123578*/

            Program program = new Program();
            //program.BuyukSayi(5,2,3,4,5,6,7,8,9,15);
            //program.KucukSayi(5, 2, 3, 4, 5, 6, 7, 8, 9, 15);

            Console.WriteLine(program.BuyukSayi(1, 2, 3, 4, 5, 8, 15, 10));
            Console.WriteLine(program.KucukSayi(1, -1, 3, 4, 5, 6, 7, 8, 9, 10));
            Console.ReadLine();


            // params kullanımı çalış 
            //params object[] dizi
        }
    }
}
