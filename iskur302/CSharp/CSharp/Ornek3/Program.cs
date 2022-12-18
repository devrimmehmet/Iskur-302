using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    internal class Program
    {
        void ivme(Double ilkhız,double sonhiz,double sure)
        {
            double ivme = (sonhiz - ilkhız) / (sure);
            Console.WriteLine("İvme ={0}",ivme);
        }
        static void Main(string[] args)
        {
            // ivme hesaplaması  
            // ilk hız son hız 
            // ilk zaman son zaman
            //İvme (a) = Hız (v) / Zaman (t)
            // ilk hız son hız
            // (s-i)/gecen sure
            Program program = new Program();

            Console.WriteLine("Lütfen ilk hız değerini giriniz");
            double ilkhiz = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen son hız değerini giriniz");
            double sonhiz = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen süreyi giriniz");
            double sure= double.Parse(Console.ReadLine());
           

            program.ivme(ilkhiz,sonhiz,sure);

            Console.ReadLine();

        }
    }
}
