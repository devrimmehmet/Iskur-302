using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek20
{
    internal class Program
    {
        void Salih()
        {
        start1:
            Console.Clear();
            Random random = new Random();
            int totalPoint = 0;
            int questionNumber = 0;
        start:
            int number1 = random.Next(0, 100);
            int number2 = random.Next(0, 100);
            Console.WriteLine("1.Sayı: {0}", number1);
            Console.WriteLine("2.Sayı: {0}", number2);
            bool durum = true;
            int result = 0;
            while (durum)
            {
                try
                {
                    Console.WriteLine("{0}+{1}=? Bu toplama işleminin sonucu kaçtır?", number1, number2);
                    result = int.Parse(Console.ReadLine());
                    durum= false;
                }
                catch (Exception)
                {

                    Console.WriteLine("Sadece Sayı giriniz.");
                }
                
            }
         
            if (result == number2 + number1)
            {
                Console.WriteLine("Tebrikler Bildiniz.");
                totalPoint += 5;
            }
            else
            {
                Console.WriteLine("Üzgünüm Yanlış Cevap.");
                totalPoint -= 2;
            }
            questionNumber++;
            Console.WriteLine("Tekrar Oynamak istiyormusunuz(e/E)");
            string answer = Console.ReadLine();
            if (answer == "e" || answer == "E")
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Toplam Puanınız:{0} ve cevapladığınız soru sayısı: {1}", totalPoint, questionNumber);
            }
            Console.ReadLine();
            Console.WriteLine("Devam etmek için bir tuşa basınız.");
            goto start1;
        }
        static void Main(string[] args)
        {
            /* Toplama işlemini öğretmeye çalışan bir oyun programı yazılacaktır. 
             * Oyun başladığı zaman rastgele 2 tane 1-100 arasında sayı tutulacak, tutulan sayılar ekrana gösterilecek ve kullanıcıya bu sayıların toplamı nedir diye sorulacaktır.
             * Eğer kullanıcı doğru cevap verirse “Tebrikler Bildiniz” değil ise “Üzgünüm Bilemediniz” diye mesaj verecektir. 
             * Her cevaptan sonra “Tekrar Oynamak istiyormusunuz(e/E)?” şeklinde bir soru sorulacak ve eğer kullanıcı “e” veya “E” ile karşılık verirse oyun tekrar başlayacaktır.
             * Kullanıcının puanı her doğru cevap için 5 puan artacak,
             * her yanlış cevap için ise 2 puan azalacaktır. 
             * Oyun sonlandığında kullanıcının verdiği doğru cevap sayısı,
             * yanlış cevap sayısı ve puanı ekranda listelenmelidir.
             * Bu işlemleri yapan programın kodlarını yazınız. */

            Program salih = new Program();
            salih.Salih();
            Console.ReadLine();
        }
    }
}
