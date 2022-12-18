using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        //İnterface ile inheritance(kalıtım) arasındaki fark

        /*
         * 1-nesne oluşturulabilir(new) inheritance interface de yapılamaz
         * 2-inheritance bir classtan miras alır sadece, interface birden fazla imlementasyon yapabilir.
         */



        public  class User
        {
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }


        class Calisan:User
        {
            public string Department { get; set; }
        }
        class Student : User
        {
           // public string Department { get; set; }
        }
        class Customer : User
        {
            public string Adress { get; set; }
        }

        
        static void Main(string[] args)
        {
            User[] user = new User[] {
            new Student { FirstName="Salih"},
            new Student { LastName="TORAMAN"},
            new Customer { FirstName="Cihat"},
        };
           
           Student ogrenci =new Student();
            ogrenci.FirstName = "";
            
            foreach (var item in user)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            Console.ReadLine();
            }
    }
}
