using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IKisi kisi = new IKisi();
            // interfaceler newlenemez çünkü soyuttur tek başına işe yaramaz

            MyClass myClass = new MyClass();
           
            Ogrenci ogrenci = new Ogrenci
            {
                Id=3,
                Ad="Devrim",
                Soyad="Pattabanoğlu",
                Bolum="İnşaat Müh."

            };
            Console.WriteLine("Öğrenci Adı: {0} Öğrenci Soyadı: {1} Bölümü : {2}",ogrenci.Ad,ogrenci.Soyad,ogrenci.Bolum);
            Console.ReadLine();
        }

        interface IKisi
        {
            int Id { get; set; }
            string Ad { get; set; }
            string Soyad { get; set; }

        }
        class Calisan : IKisi  //impelement etme işlemi yapıldı 
        {
            public int Id
            {
                get;
                set;
            }
            public string Ad
            {
                get;
                set;
            }
            public string Soyad
            {
                get;
                set;
            }

            public int Maas { 
                get; 
                set; }
        }
        class Ogrenci : IKisi
        {
            public int Id
            {
                get;
                set;
            }
            public string Ad
            {
                get;
                set;
            }
            public string Soyad
            {
                get;
                set;
            }
            public string Bolum { 
                get; 
                set; }
        }
        class Musteri : IKisi
        {
            public int Id
            {
                get;
                set;
            }
            public string Ad
            {
                get;
                set;
            }
            public string Soyad
            {
                get;
                set;
            }
            public string Adres { 
                get; 
                set; }
        }

        class MyClass
        {
            public void Ekle(IKisi kisi)
            {
                Console.WriteLine(kisi);
            }
        }
    }
}
