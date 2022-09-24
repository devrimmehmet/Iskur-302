using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet", "Mehmet", "Devrim", "Ali", "Veli" };
            int[] numaralar = { 5, 3, 6, 1, 2 };

            //isimler[0]="Ali";
            isimler.SetValue("Ali",0);

            //Console.WriteLine(isimler.GetValue(0));
            Console.WriteLine(Array.IndexOf(isimler,"Devrim"));
            Console.WriteLine(isimler.Length);

            Array.Sort(isimler); //alfabetik sıralama
            Array.Sort(numaralar); // küçükten büyüğe sıralama
            Console.WriteLine(isimler.GetValue(0));
            Console.WriteLine(isimler.GetValue(1));
            Console.WriteLine(isimler.GetValue(2));
            Array.Reverse(isimler);// diziyi ters çevir

            Console.WriteLine(isimler.GetValue(0));
            Console.WriteLine(isimler.GetValue(1));
            Console.WriteLine(isimler.GetValue(2));
            Console.WriteLine(numaralar.GetValue(0));
            Console.WriteLine(numaralar.GetValue(1));
            Console.WriteLine(numaralar.GetValue(2));

            Array.Clear(isimler, 0, 2);// string 0 ile 2 arasını sil dedik yerine "" koydu.
            Console.WriteLine(isimler.GetValue(0));
            Array.Clear(numaralar, 0, 2);// int 0 ile 2 arasını sil dedik yerine 0 koydu.
            Console.WriteLine(numaralar.GetValue(0));
            string[] isimler1 = { "Ahmet", "Mehmet", "Devrim", "Ali", "Veli" };

            var result = isimler1[1..3];
             result = isimler1[1..];
             result = isimler1[..3];

            foreach (var isim in isimler1)
            {
                Console.WriteLine(isim);
            }


        }
    }
}
