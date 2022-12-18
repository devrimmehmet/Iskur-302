using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    internal class Kitap
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }

        public string Publisher { get; set; }

        public void Ekle()
        {
            Console.WriteLine("Kitap Id:");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kitap İsmi:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Kitabın Yazarı:");
            this.Author = Console.ReadLine();
            Console.WriteLine("Kitabın Türü:");
            this.Type = Console.ReadLine();
            Console.WriteLine("Kitabın Yayınevi:");
            this.Publisher = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Kitap Sisteme Eklendi.");
            Console.WriteLine("Kitap Id: " + this.Id);
            Console.WriteLine("Kitap Adı: " + this.Name);
            Console.WriteLine("Kitabın Yazarı: " + this.Author);
            Console.WriteLine("Kitabın Türü: " + this.Type);
            Console.WriteLine("Kitabın Yayınevi: " + this.Publisher);
        }

    }
}
