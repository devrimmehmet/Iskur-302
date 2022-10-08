using System;

namespace ConsoleApp1
{
    class LoginException : Exception
    {
        public LoginException(string message):base(message)
        {
                
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Login("DevrimMehmet","12345678");
                Console.WriteLine("Login Başarılı");
            }
            catch (LoginException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void Login(string username,string password)
        {
            if (username.Contains(" "))
            {
                throw new LoginException("username boşluk içeremez");
            }
            if (password.Length<8)
            {
                throw new LoginException("Parola minumum 8 karakter olmalıdır.");
            }
        }

    }
}
