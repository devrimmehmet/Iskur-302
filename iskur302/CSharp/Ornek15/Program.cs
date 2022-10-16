using System;

namespace Ornek15
{
    internal class Program
    {
        void Hesapla()
        {
            int toplam = 0;
            int kisi = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    try
                    {
                        Console.WriteLine($"{i + 1}.kat {k + 1}.dairede kaç kişi kalıyor?");
                        kisi = int.Parse(Console.ReadLine());
                        toplam += kisi;
                    }
                    catch (Exception)
                    {
                        k--;
                    }
                }
            }
            Console.WriteLine("Toplam {0} kişi kalıyor.", toplam);
        }
        
        void HesaplaDiziyle()
        {
            int toplam = 0;
            int[,] dizi = new int[4,3];
            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int k = 0; k < dizi.GetLength(1); k++)
                {
                    try
                    {
                        Console.WriteLine($"{i + 1}.kat {k + 1}.dairede kaç kişi kalıyor?");
                        dizi[i, k] = int.Parse(Console.ReadLine());
                        toplam += dizi[i, k];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message.ToString());
                        k--;
                    }
                  
                }
            }
            Console.WriteLine("Bu binada toplam {0} kişi kalmaktadır.",toplam);
            
        }
        static void Main(string[] args)
        {
            // 4 katlı bir binanın her katında 3 daire vardır klavyede her dairede bulunan kişi sayısını girdikten sonra binada kaç kişi olduğunu hesaplayınız 
            Program program = new Program();
            program.Hesapla();
            Console.ReadLine();
        }
    }
}
