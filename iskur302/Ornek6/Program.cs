using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kütüphane Yönetim Paneline Hoş Geldiniz");
            Console.WriteLine();
            Console.WriteLine("Yapmak istediğiniz işlemi Seçiniz.");

            bool durum = true;
            while (durum)
            {

                Console.WriteLine();
            Console.WriteLine("1:Kullanıcı Ekle \n2:Personel \n3:Kitap \n4:Çıkış");
            int secim = int.Parse(Console.ReadLine());
           
            
            switch (secim)
            {
                case 1:
                    Kullanici kullanıcı = new Kullanici();
                    kullanıcı.Ekle();
                    break;
                case 2:
                    Personel personel = new Personel();
                    personel.Ekle();
                    break;
                case 3:
                    Kitap kitap = new Kitap();
                    kitap.Ekle();
                    break;
                case 4:
                        durum = false;
                    break;

                default:
                    break;
            }
            }


            Console.ReadLine();
        }
    }
}
