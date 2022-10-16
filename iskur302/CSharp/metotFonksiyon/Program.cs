using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace metotFonksiyon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar-Fonksiyonlar
            Console.WriteLine("Metotlar ve fonksiyonlar");
            Console.WriteLine("-------------------------");
            Console.WriteLine("*************************");
            Console.WriteLine();
            Console.WriteLine();
            /* Geriye Değer Döndüren Metotlar
             *      Parametreli ve Geriye Değer Döndüren Metotlar
             *      Parametresiz ve geriye değer döndüren Metotlar
             * Geriye Değer Döndürmeyen Metotlar (void)
             *      Parametreli ve Geriye Değer Döndürmeyen Metotlar
             *      Parametresiz ve geriye değer Döndürmeyen Metotlar
             *      
             *      Belirli bir işlemi yerine getirmek için yazılan ve istenilen yerde çağrılan kod bloklarıdır.
             *      Erişim Belirleyici Niteleyici(varsa) DonusTipi MetotAdı (Varsa Parametre)
            */

            /*  Erişim Belirleyicilerimiz bunlardır (Public, Private, Internal, Protected)
                * Public: Her yerden erişilebilir.
                *   Public-static genel bir değişken tanımlaması olmasına rağmen başka classa gidemez sadece kendi clasında class nesnesi
                * Private: Sadece tanımlandığı sınıf(class) içerisinden erişilebilir.
                *   Private-static private clas özel tanımlama ve static ise classa ait değişken olduğundan dışarıdan çağrıldığında erişilemez.
                * Internal: Sadece bulunduğu projede erişilebilir.
                * Protected: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir
            */
            /*
            küpler metodu ifade eder
                anahtar private olduğunu ifade eder
            */


            //  Topla();
            Program program = new Program();
            //  topla.Ekle2(2,3);
            //  Metotlar metotlar = new Metotlar();
            //  metotlar.Ekle();
            //program.Topla();
            // int sonuc= program.Toplama();
            // Console.WriteLine(sonuc);
            Console.WriteLine(program.Toplama());
            Console.ReadLine();
            Console.WriteLine();
            #endregion
        }
        private void Topla()
        {
            int a = 3;
            int b = 5;
            int c = a + b;
            Console.WriteLine("a+b= {0}", c);
        }
        private void Ekle2(int a, int c)
        {
            int b = 5;

            int toplam = a + b + c;
            Console.WriteLine("Metotlar: {0}", toplam);

        }

        private int Toplama()
        {
            int a = 5;
            int b = 6;

            return a+b;
        }
    }
}
