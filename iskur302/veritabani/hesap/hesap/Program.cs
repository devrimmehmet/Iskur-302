using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double anapara, faizorani, toplamfaiz,taksitSayisi,aylikfaiz;
            anapara = 30000;
            faizorani=0.15;
            taksitSayisi = 8;

            // Console.WriteLine(aylikfaiz);
            toplamfaiz = ((anapara * taksitSayisi * faizorani) / 12) * (1 - (1 - taksitSayisi / 12) * faizorani);
            for (int i = 0; i < taksitSayisi; i++)
            {
                aylikfaiz = (anapara / 100) * (faizorani / 12) * (i+1);
               
                Console.WriteLine(toplamfaiz);
                Console.WriteLine(aylikfaiz);
            }
            Console.ReadLine();
        }
    }
}
