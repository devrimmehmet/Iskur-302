using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] SayisalLoto=new int[6];
            for (int i = 0; i < 6; i++)
            {
              int sayi = random.Next(0, 50);
                if (Array.IndexOf(SayisalLoto, sayi) == -1)
                {
                    SayisalLoto[i] = sayi;
                }
                else
                {
                    i--;
                }
            }
            Array.Sort(SayisalLoto);
            foreach (var item in SayisalLoto)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}
