using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, department, lesson;
            int number1, number2, average;
            //String değişkenlerin atamaları
            name = "Devrim Mehmet";
            surname = "Pattabanoğlu";
            department = "İŞKUR-MEK";
            lesson = "Algoritma Programlama";
            //Int değişkenlerin atamaları
            number1 = 60;
            number2 = 80;
            average = (number1 + number2) / 2;
            //Yazdırma Komutları
            Console.WriteLine("***** Öğrenci Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine("Öğrenci Adı Soyadı: " + name + " " + surname);
            Console.WriteLine("Bölüm: " + department);
            Console.WriteLine("Ders: " + lesson);
            Console.WriteLine();
            Console.WriteLine("Sınav1: " + number1);
            Console.WriteLine("Sınav2: " + number2);
            Console.WriteLine("Ortalamanız: " + average);
            Console.Read();

        }
    }
}
