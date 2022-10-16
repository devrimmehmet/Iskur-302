using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    public class MyClass
    {
        public void ekle()
        {
            Console.WriteLine("sa");
        }
    }

     class Program
    {
        public void cevre(double r)
        {
            const double P = 3.14;
            Console.WriteLine("Çemberin çevresi: {0}", (2 * P * r));
        }
        static void Main(string[] args)
        {
          MyClass myclass = new MyClass();
            //Console.Write("Lütfen Yarıçapı giriniz r: ");
            //double r = double.Parse(Console.ReadLine());
            //program.cevre(r);


            myclass.ekle();






            Console.ReadLine();
        }
    }
}
