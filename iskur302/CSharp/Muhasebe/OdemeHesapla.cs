using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    public class OdemeHesapla
    {
        public int MyProperty { get; set; }
        public int Borc { get; set; }

    
        public void Fatura(int a,bool d)
        {
            Araba araba = new Araba();
            if (d==true)
            {
                Borc = 1000 * (a*1/10)*2;
            }
            else
            {
                Borc = 1000 * (a * 1 / 10);
            }
            Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine("Borcunuz {0} TL",Borc);
        }

    }
}
