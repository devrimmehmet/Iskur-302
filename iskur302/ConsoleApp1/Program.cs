using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classlar
            // Class: Bizim yapmak istediğimiz işlemleri grublara ayırmak Bu grub üzerinde 
            // işlemlerimizi yapmak ve rahatlıkla bu gruba ulaşmak için kullanılır.
            Urunler urunler = new Urunler();
            Musteri musteri = new Musteri();

            urunler.Ekleme();
            musteri.Silme();

            UrunBilgisi urunBilgisi = new UrunBilgisi { Id=5, UrunAdi="Elma", adet=10};
            Console.WriteLine(urunBilgisi.Id);
            MusteriBilgisi musteriBilgisi = new MusteriBilgisi { Id = 1, Adi = "Ahmet", Soyadi = "sos",Adres="Kastamonu" };
            //foreach (var item in urunBilgisi)
            //{
           
            //}
            Console.ReadLine();
            #endregion

        }
        
       

    }
}
