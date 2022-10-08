using System;

namespace ConsoleApp1
{

    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Year { get; set; }

            public string Intro()
            {
                return $"İsim: {this.Name} Yaş: {this.CalculateAge()}";
            }
            public int CalculateAge()
            {
                return DateTime.Now.Year - this.Year;
            }
        }
        static void Main(string[] args)
        {
            var p1 = new Person { Name = "Ada", Year = 2012 };
            var p2 = new Person { Name = "Yiğit", Year = 2010 };
            var p3 = new Person { Name = "Sena", Year = 1999 };


          var str1=  p1.Intro();
            var str2 = p2.Intro();
            var str3 = p3.Intro();
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }
}
