using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    static class HelperMethods
    {
        public static string KarakterDuzelt(string str)
        {
            return str
                .Replace("ö", "o")
                .Replace("ü", "u")
                .Replace("ç", "c")
                .Replace(" ", "-")
                .Replace("ğ", "g");
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int StudentNumber { get; set; }
        public static string School = "My School";
        public static string Adress = "My School Adres";
        public Student(string name, int studentNumber)
        {
            this.Name = name;
            this.StudentNumber = studentNumber;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine($"Name: {this.Name} Number: {this.StudentNumber}");
        }
        public static void DisplaySchoolDetails()
        {
            Console.WriteLine($"School Name: {Student.School} School Adress: {Student.Adress}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Çınar",100);
            var s2 = new Student("Sena", 101);
            var s3 = new Student("Yiğit", 102);
            s1.DisplayStudentDetails();

            Student.DisplaySchoolDetails();

            string str = "ölçme ve değerlendirme";
            var result = HelperMethods.KarakterDuzelt(str);
            Console.WriteLine(result);
        }
    }
}
