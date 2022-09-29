using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    
    internal class Program
    {
        
        
        void BakiyeSorgula(int bakiye,int esnekHesap)
        {
           
            Console.WriteLine("Bakiyeniz: {0} TL, Esnek Hesap Bakiyeniz: {1} TL", bakiye, esnekHesap);
            Console.WriteLine();
            Console.WriteLine();
        }
        void ParaYatir()
        {
           
            if (esnekHesap == 1000)
            {
                bakiye += yatirilan;
            }else if (esnekHesap < 1000)
            {
                esnekHesap += yatirilan;
                if (esnekHesap > 1000)
                {
                    bakiye += (esnekHesap - 1000);
                    esnekHesap = 1000;
                }
            }

            Console.WriteLine("{0} TL Yatırıldı.", yatirilan);
            Console.WriteLine("Bakiyeniz: {0} TL, Esnek Hesap Bakiyeniz: {1} TL", bakiye, esnekHesap);
            Console.WriteLine();
            Console.WriteLine();
        }
        public void hesap()
        {

        }
        static void Main(string[] args)
        {
            int bakiye = 100;
            int esnekHesap = 1000;
            int yatirilan = 0;
            int cekilen = 0;
            Program program=new Program();

            // bakiye
            // para yatırma
            // para çekme
            // çıkış
            

            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz.");
                Console.WriteLine("1-Bakiye Görüntüle");
                Console.WriteLine("2-Para Yatırma");
                Console.WriteLine("3-Para Çekme");
                Console.WriteLine("4-Çıkış");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        { 
                        program.BakiyeSorgula(bakiye,esnekHesap);
                        }
                        break;
                    case 2:
                        {
                        Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz.");
                        yatirilan = int.Parse(Console.ReadLine());
                        program.ParaYatir(bakiye, esnekHesap,yatirilan);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz.");
                            cekilen = int.Parse(Console.ReadLine());
                            if (cekilen <= bakiye)
                            {
                                bakiye -= cekilen;
                            }
                            else if (cekilen > bakiye && cekilen <= (esnekHesap + bakiye))
                            {
                            start:
                                Console.WriteLine("Bakiyeniz Yetersiz. Esnek Hesap Kullanmak İstermisiniz? (e/h)");
                                string onay = Console.ReadLine();
                                if (onay == "e")
                                {


                                    esnekHesap = esnekHesap - (cekilen - bakiye);
                                    bakiye = 0;

                                }
                                else if (onay == "h")
                                {
                                    break;
                                }
                                else
                                {

                                    Console.WriteLine("Yanlış seçim yapıldı (e/h)");
                                    goto start;
                                }
                            }
                            else if (cekilen > (esnekHesap + bakiye))
                            {
                                Console.WriteLine("Bu İşlem İçin Limitiniz Yetersiz Lütfen Bankanız İle Görüşünüz.");
                                break;
                            }



                            Console.WriteLine("{0} TL çekildi.", cekilen);
                            Console.WriteLine("Bakiyeniz: {0} TL, Esnek Hesap Bakiyeniz: {1} TL", bakiye, esnekHesap);
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Sistemden çıkış yapıldı.");
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim yapıldı (1,2,3,4)");
                        break;
                }
            }
        }
    }
}
