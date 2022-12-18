using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek17
{
    internal class Program
    {
        void TersSifrele()
        {
            Console.WriteLine("Lütfen bir cümle giriniz.");

            string kelime = Console.ReadLine();
            int sayac = 0;
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                if (kelime[i] == 'a' || kelime[i] == 'A')
                {
                    Console.Write("?");
                    sayac++;
                }
                else if (kelime[i] == 'e' || kelime[i] == 'E')
                {
                    Console.Write("*");
                    sayac++;
                }
                else if (kelime[i] == 'i' || kelime[i] == 'ı' || kelime[i] == 'İ' || kelime[i] == 'I')
                {
                    Console.Write("=");
                    sayac++;
                }
                else if (kelime[i] == 'o' || kelime[i] == 'ö' || kelime[i] == 'O' || kelime[i] == 'Ö')
                {
                    Console.Write("&");
                    sayac++;
                }
                else if (kelime[i] == 'u' || kelime[i] == 'ü' || kelime[i] == 'U' || kelime[i] == 'Ü')
                {
                    Console.Write("+");
                    sayac++;
                }
                else
                {
                    Console.Write(kelime[i]);
                }

            }
            Console.WriteLine();
            Console.WriteLine("Toplam {0} tane karakter değiştirildi.", sayac);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //klavyeden girilen cümleyi yazdırın 
            //kullanıcı enter tuşuna bastığında cümle daha sonra tersten şifreli olarak ekrana yazdırılacaktır.

            //  a yerine ?
            //  e yerine *
            // i veya ı yerine =
            // o veya ö yerine ise & yazılacak 
            //  Console.WriteLine("Lütfen bir cümle giriniz.");
            //string  kelime = Console.ReadLine();
            //int  sayac = 0;
            //  string[] kelime1 = new string[kelime.Length];
            //  for (int i = kelime.Length - 1; i >= 0; i--)
            //  {
            //      if (kelime[i]=='a' || kelime[i] == 'A')
            //      {
            //          kelime1[i] = "?";
            //          sayac++;
            //      }else if (kelime[i] == 'e'|| kelime[i] == 'E')
            //      {
            //          kelime1[i] = "*";
            //          sayac++;
            //      }else if (kelime[i] == 'i' || kelime[i] == 'ı'|| kelime[i] == 'İ' || kelime[i] == 'I')
            //      {
            //          kelime1[i] = "=";
            //          sayac++;
            //      }
            //      else if (kelime[i] == 'o' || kelime[i] == 'ö' || kelime[i] == 'O' || kelime[i] == 'Ö')
            //      {
            //          kelime1[i] = "&";
            //          sayac++;
            //      }
            //      else
            //      {
            //          kelime1[i] = Convert.ToString( kelime[i]);
            //      }
            //      Console.Write(kelime1[i]);
            //  }
            //  Console.WriteLine();
            //  Console.WriteLine("Toplam {0} tane karakter değiştirildi.", sayac);
            //  Console.ReadLine
            //  
            Program program = new Program();
            program.TersSifrele();

        }
    }
}
