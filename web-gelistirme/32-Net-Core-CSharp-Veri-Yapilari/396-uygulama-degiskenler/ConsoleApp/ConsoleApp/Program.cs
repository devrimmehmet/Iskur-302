using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //null
            //nullable
            byte? kg = null;



            // Kilo bilgisi tutacak bir değişken   
            byte kilo = 90;

            //Plaka bilgisi tutacak bir değişken
            byte plaka = 81;
            string _plaka = "81";

            //Araç km bilgisini tutan bir değişken
            int km = 100000;

            //Müşteri id'sini tutacak bir değişken
            string musteriId = "A12313113";

            //Bir ürünün satışta olup olmadığını bilgisini tutacak bir değişken
            bool satistami = true;
            bool _satistami = false;

            //Maaş bilgisini tutacak bir değişken
            decimal maaş = 3000.13213m;

            //Öğrenci adını ve soyadını tutacak bir değişken
            string ad = "Devrim Mehmet";
            string soyad = "Pattabanoğlu";
            string fullname = ad +" "+ soyad;
            string adsoyad = "Devrim Mehmet Pattabanoğlu";

            //Şube kodunu tutacak bir değişken
            char sube = 'A';
            string _sube = "10A";

        }
    }
}
