using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YasHesapla1
{
    class YasHesapla
    {
        private string adSoyad;
        //private int yas;
        private DateTime dtarihi;

        private int dt;
        public int DT
        {
            get { return dt; }
            set { dt = DateTime.Now.Year - value; }
        }

        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }
        public int Yas
        {
            get { return DateTime.Now.Year-dtarihi.Year; }
           // set { yas = value; }
        }
        public DateTime DTarihi
        {
            get { return dtarihi; }
            set { dtarihi = value; }
        }
    }
        internal class Program
    {
        
        static void Main(string[] args)
        {
            YasHesapla yasHesapla = new YasHesapla {DT=1993};
           

           // Console.WriteLine("Yaşınız: "+yasHesapla.DT);



            DateTime a = DateTime.Parse("2000-11-25");
            //DateTime b = DateTime.Parse("2000");
            YasHesapla kisi = new YasHesapla();
            kisi.AdSoyad = "void";
            kisi.DTarihi = a;

            Console.WriteLine(kisi.Yas);
            Console.WriteLine(kisi.AdSoyad);








            Console.ReadLine();



        }
    }
}
