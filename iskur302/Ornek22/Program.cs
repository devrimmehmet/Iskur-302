using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek22
{
    internal class Program
    {
       static bool isPrime(int a)
        {
            bool isPrime = true;
            //Console.WriteLine("girilen sayı: {0}",a);
            if (a==2)
            {
                isPrime = true;
            }else if (a>2)
            {
                for (int i = 2; i < a; i++)
                {
                    if (a%i==0)
                    {
                        isPrime = false;
                    }
                }
            }
            return isPrime;
        }
        static void Main(string[] args)
        {
            /*Parametre olarak yollanan bir sayının asal sayı olup olmadığını geriye döndüren bir metot yazınız. Eğer sayı asal ise geriye “true” değil ise “false” değeri döndürülecektir.
             * */
            //Program program = new Program();
           
            Console.WriteLine(isPrime(15));
            Console.ReadLine();
        }
    }
}
