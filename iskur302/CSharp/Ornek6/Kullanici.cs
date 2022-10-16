using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    public class Kullanici
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }

       public void Ekle()
        {
            //Kullanici[] kullanici = new Kullanici[50];
            //Kullanici user;
            Console.WriteLine("Kullanıcı Id:");
            Id =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Kullanıcı İsmi:");
            Name = Console.ReadLine();
            Console.WriteLine("Kullanıcı Soyadı:");
            SurName = Console.ReadLine();
            Console.WriteLine("Kullanıcı Yaşı:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kullanıcı Sisteme Eklendi.");
            Console.WriteLine("Kullanıcı Id: "+Id);
            Console.WriteLine("Kullanıcı Adı: " + Name);
            Console.WriteLine("Kullanıcı Soyadı: " + SurName);
            Console.WriteLine("Kullanıcı Yaşı: " + Age);
        }
    }
}
