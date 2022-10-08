using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            string _name;
            public string  Name {
                get { return _name; }
                set {
                    if (value.Length > 15)
                    {
                        throw new Exception("Name için en fazla 15 karakter girmelisin.");
                    }
                    _name = value;

                }
            }
        }

        static void Main(string[] args)
        {
            // Exception Handling

            //int sayi = 10;
            //if (sayi > 5)
            //{
            //    throw new Exception("Sayı 5ten büyük olamaz.");
            //}
            string parola = "aaaaaaaa2";

            //try
            //{
            //    check_password(parola);
            //    Console.WriteLine("Parola Geçerli");
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}

            var p = new Person();
            try
            {
                p.Name = "Sadık                    ";
            }
            catch (System.Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        static void check_password(string password)
        {
            if (password.Length<8 || password.Length>15)
            {
                throw new Exception("Parola 7-15 karakter arasında olmalıdır.");
            }
            if (!password.Any(char.IsDigit))
            {
                throw new Exception("Parola en az bir rakam içermelidir.");
            }
            if (!password.Any(char.IsLetter))
            {
                throw new Exception("Parola en az bir harf içermelidir.");
            }
        }
    }
}
