using System;

namespace ConsoleApp1
{
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public bool Otomatik { get; set; }

        public void Start()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Çalıştırıldı.");
        }
        public void Stop()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Stop Edildi.");
        }
        public void Yavasla()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Yavaşlıyor.");
        }
        public void Hizlan()
        {
            Console.WriteLine($"{this.Marka} {this.Model} Hızlanıyor.");
        }
        public void Menu()
        {
            string komut = "";

            do
            {
                Console.WriteLine("1-Start 2-Hızlan 3-Yavaşla 4-Stop Çıkış: Ç");
                Console.Write("Seçiminiz: ");
                switch (komut)
                {
                    case "1":
                        this.Start();
                        break;
                    case "2":
                        this.Hizlan();
                        break;
                    case "3":
                        this.Yavasla();
                        break;
                    case "4":
                        this.Stop();
                        break;
                    default:
                        Console.WriteLine("Uygulamadan Çıkıldı");
                        komut = "Ç";
                        break;
                }
                komut = Console.ReadLine();
            } while (komut!="Ç");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var opel = new Araba();
            opel.Marka = "Opel";
            opel.Model = "Vectra";
            opel.Renk = "Beyaz";
            opel.Otomatik = true;

            //opel.Start();
            //opel.Hizlan();
            //opel.Yavasla();
            //opel.Stop();
          //  opel.Menu();


            var mazda = new Araba();
            mazda.Marka = "Mazda";
            mazda.Model = "CX3";
            mazda.Renk = "Kırmızı";
            mazda.Otomatik = false;
            mazda.Menu();
        }
    }
}
