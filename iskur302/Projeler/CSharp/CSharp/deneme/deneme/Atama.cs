using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    public class Atama
    {
        public void SinifListem()
        {
            Random random = new Random();

            string[] SinifListesi = { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Mısra", "Büşra", "Mert Kutlu", "Mert Tutunmaz", "Sena", "Erhan", "Berkcan" };
            Console.WriteLine();
            Console.WriteLine("Rastgele Atama İşlemi Yapılıyor...");
            Console.WriteLine();
            for (int i = 0; i < SinifListesi.Length; i++)
            {

                int randomsayiSecimi = random.Next(0, SinifListesi.Length - i); // random.Next(0,15) 0 1 2 3 4  12 13 14
                Console.WriteLine((i + 1) + " " + SinifListesi[randomsayiSecimi]);
                SinifListesi[randomsayiSecimi] = SinifListesi[SinifListesi.Length - i - 1];


            }
            Console.WriteLine();
            Console.WriteLine();
            Menu();
        }
     public   void  GrupluSinifListem()
        {
            Random random = new Random();

            string[] SinifListesi = { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Mısra", "Büşra", "Mert Kutlu", "Mert Tutunmaz", "Sena", "Erhan", "Berkcan" };
            Console.WriteLine("Listenizi Kaç Kişilik Gruplara Bölmek İstiyorsunuz ?");
            int kacKisilikGruplaraBolmekIstiyorsun; // 4 kişilik gruplara böl dersem 4 tane grup oluşur


            kacKisilikGruplaraBolmekIstiyorsun = int.Parse(Console.ReadLine());

      



            int GrupSayisi;
            if ((SinifListesi.Length % kacKisilikGruplaraBolmekIstiyorsun) == 0) // 15 % 4 ==3
            {
                GrupSayisi = SinifListesi.Length / kacKisilikGruplaraBolmekIstiyorsun; // Grupsayisi=15/4 = 3,75
            }
            else
            {
                GrupSayisi = (SinifListesi.Length / kacKisilikGruplaraBolmekIstiyorsun) + 1; // (15/4)+1 
            }
            Console.WriteLine();
            Console.WriteLine($"{kacKisilikGruplaraBolmekIstiyorsun} Kişilik Gruplar Halinde Rastgele Atama İşlemi Yapılıyor...");
            Console.WriteLine($"Toplam {GrupSayisi} Grup Oluşturuldu.");
            Console.WriteLine();



            Console.WriteLine();
            if ((SinifListesi.Length % kacKisilikGruplaraBolmekIstiyorsun) == 0)
            {
                for (int i = 0; i < GrupSayisi; i++)
                {
                    Console.WriteLine($"{i + 1}.Grup"); // 1.Grup  5 kişlilik  2.grup grup 5 kişi 3.grup 5 kişilik
                    for (int k = 0; k < kacKisilikGruplaraBolmekIstiyorsun; k++)
                    {
                        int select = random.Next(0, SinifListesi.Length - k - (i * kacKisilikGruplaraBolmekIstiyorsun));
                        Console.WriteLine(SinifListesi[select]);
                        SinifListesi[select] = SinifListesi[SinifListesi.Length - k - (i * kacKisilikGruplaraBolmekIstiyorsun) - 1];
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < GrupSayisi; i++)
                {
                    Console.WriteLine($"{i + 1}.Grup");
                    for (int k = 0; k < kacKisilikGruplaraBolmekIstiyorsun; k++)
                    {
                        if (i + 1 == GrupSayisi)
                               
                        {      
                            if (k + (i * kacKisilikGruplaraBolmekIstiyorsun) < ((GrupSayisi - 1) * kacKisilikGruplaraBolmekIstiyorsun) + (SinifListesi.Length % kacKisilikGruplaraBolmekIstiyorsun))
                            {
                                int select = random.Next(0, SinifListesi.Length - k - (i * kacKisilikGruplaraBolmekIstiyorsun));
                                Console.WriteLine(SinifListesi[select]);
                                SinifListesi[select] = SinifListesi[SinifListesi.Length - k - (i * kacKisilikGruplaraBolmekIstiyorsun) - 1];
                            }
                        }
                        else
                        {
                            int select = random.Next(0, SinifListesi.Length - k - (i * kacKisilikGruplaraBolmekIstiyorsun));
                            Console.WriteLine(SinifListesi[select]);
                            SinifListesi[select] = SinifListesi[SinifListesi.Length - k - (i * kacKisilikGruplaraBolmekIstiyorsun) - 1];
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Menu();
        }
        public void Menu()
        {

        start1:
            Console.WriteLine("Lütfen Seçim Yapınız.");
            Console.WriteLine("1 - Hazır Sınıf Listesini Kullanmak İstiyorum.");
            Console.WriteLine("2 - Hazır Sınıf Listesini Kullanarak Gruplu Atama Yapmak İstiyorum.");
            Console.WriteLine("3 - Yeni Sınıf Listesi Oluşturmak İstiyorum.");
            Console.WriteLine("4 - Yeni Sınıf Listesi Oluşturup Gruplu Atama Yapmak İstiyorum.");
            Console.WriteLine("5 - Çıkış Yap.");
            string selectMenu = Console.ReadLine();
            switch (selectMenu)
            {
                case "1":
                    SinifListem();
                    break;
                case "2":
                    GrupluSinifListem();
                    break;
                case "3":
                //    NewClassList();
                    break;
                case "4":
                //    GroupNewClassList();
                    break;
                case "5":
                    Console.WriteLine("Çıkış Yapılıyor...");
                    Console.WriteLine("Bir Tuşa Basınız...");
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim Yaptınız Lütfen Tanımlı Seçenekler Üzerinden Seçim Yapınız. ( 1 - 2 - 3 - 4 - 5)");
                    goto start1;
                    break;
            }
        }
    }
}
