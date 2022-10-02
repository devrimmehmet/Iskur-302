using System;

namespace ConsoleApp1
{
    interface IPersonel
    {
        string Departman { get; set; }
        public void bilgi()
        {
            
        }
    }
    interface IKisi
    {
        string AdSoyad { get; set; }
        string Adres { get; set; }
        string Departman { get; set; }
        double maas { get; set; }
        
    }
    class Robot : IPersonel
    {
        public Robot(string departman)
        {
            this.Departman = departman;
        }

        public string Departman { get; set; }
        public void bilgi()
        {
            Console.WriteLine($"{this.Departman} bölümünde bir robot.");
        }

    }
    class Yonetici : IPersonel,IKisi
    {
        public Yonetici(string adSoyad, string adres, string departman)
        {
            this.AdSoyad = adSoyad;
            this.Adres = adres;
            this.Departman = departman;
        }

        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Departman { get; set; }
        public double maas { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.AdSoyad} isimli personel {this.Departman} bölümünde yöneticidir.");
        }
    }
    class Iscı : IPersonel,IKisi
    {
        public Iscı(string AdSoyad, string Adres, string Departman)
        {
            this.AdSoyad = AdSoyad;
            this.Adres = Adres;
            this.Departman = Departman;

        }
        public string AdSoyad { get; set; }
        public string Adres { get; set; }
        public string Departman { get; set; }
        public double maas { get; set; }

        public void bilgi()
        {
            Console.WriteLine($"{this.AdSoyad} isimli personel {this.Departman} bölümünde işçidir.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonel yonetici = new Yonetici("Devrim","Pattabanoğlu", "Software");
            //IPersonel isci = new Iscı();

            var personeller = new IPersonel[3];
            personeller[0] = new Yonetici("Devrim Pattabanoğlu", "Kastamonu", "Software");
            personeller[1] = new Iscı("Ahmet Dirlik","Nereli", "Üretim");
            personeller[2] = new Robot( "Üretim");

            foreach (var personel in personeller)
            {
                personel.bilgi();
            }
        }
    }
}
