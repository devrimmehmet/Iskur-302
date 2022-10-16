using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace cevreAlana
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lütfen karenin bir kenarını giriniz:");

            //int a = Convert.ToInt32(Console.ReadLine());
            //cevre alanHesabi =new cevre();
            //alanHesabi.alanHesapla(a);
            //alanHesabi.cevreHesapla(a);
           
            Arabalar arabalar = new Arabalar();
            // arabalar.DENEME = "bmw";
            //  Console.WriteLine(arabalar.DENEME);

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.Year);
            //Console.WriteLine(DateTime.Now.Month);
            arabalar.DENEME = "devrimMmPp";
            Console.WriteLine(arabalar.DENEME);

            //Console.Write("Doğum tarihini yazınız: ");
            //arabalar.DogumTarihi = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yaş:"+arabalar.DogumTarihi);

            Console.ReadLine();
        }
        

    }
}
