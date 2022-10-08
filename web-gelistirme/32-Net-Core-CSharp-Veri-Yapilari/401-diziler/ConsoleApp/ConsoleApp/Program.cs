using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msj = "Devrim Mehmet Pattabanoğlu";
            Console.WriteLine(msj[0]);
            Console.WriteLine(msj[7]);

            var result=msj.Split();
            Console.WriteLine(result[0]);
            Console.WriteLine(result[2]);

            string[] isimler = new string[5];

            isimler[0] = "Devrim";
            isimler[1] = "Mehmet";
            isimler[2] = "Ahmet";
            isimler[3] = "Ada";
            isimler[4] = "Sena";

            int[] numaralar = new int[5];
            numaralar[0] = 101;
            numaralar[1] = 102;
            numaralar[2] = 103;
            numaralar[3] = 104;
            numaralar[4] = 105;
            Console.WriteLine($"Öğrenci Adı: {isimler[0]} Öğrenci Numarası: {numaralar[0]}");
            Console.WriteLine($"Öğrenci Adı: {isimler[1]} Öğrenci Numarası: {numaralar[1]}");
            Console.WriteLine($"Öğrenci Adı: {isimler[2]} Öğrenci Numarası: {numaralar[2]}");
            Console.WriteLine($"Öğrenci Adı: {isimler[3]} Öğrenci Numarası: {numaralar[3]}");
            Console.WriteLine($"Öğrenci Adı: {isimler[4]} Öğrenci Numarası: {numaralar[4]}");
        }
    }
}
