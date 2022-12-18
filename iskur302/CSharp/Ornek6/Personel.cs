using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    internal class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Unvan { get; set; }

        public void Ekle()
        {
            Console.WriteLine("Personel Id:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Personel İsmi:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Personel Soyadı:");
            this.SurName = Console.ReadLine();
            Console.WriteLine("Personel Yaşı:");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Personel Ünvanı:");
            this.Unvan = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Personel Sisteme Eklendi.");
            Console.WriteLine("Personel Id: " + this.Id);
            Console.WriteLine("Personel Adı: " + this.Name);
            Console.WriteLine("Personel Soyadı: " + this.SurName);
            Console.WriteLine("Personel Ünvanı: " + this.Unvan);
        }
    }
}
