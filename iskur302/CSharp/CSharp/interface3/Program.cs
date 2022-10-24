using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] calis = new IWorker[]
            {
                new Workers(),
                new Managers(),
                new Robots()
            };
            foreach (var item in calis)
            {
                item.Work();

                
            }
            //foreach (var item in calis)
            //{
            //  //  item.();

            //}
            Console.ReadLine();
            
        }
        interface IWorker
        {
            void Work();
            
            
        }
        interface IEat
        {
            void Eat();
        }
        interface IGetSalary
        {
            void GetSalary();
        }
        class Robots : IWorker
        {
          

            public void Work()
            {
                Console.WriteLine("Robotum Köpek Gibi Çalışırım.");
            }
        }
        class Workers : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("İşçiyim kuru ekmek Yerim.");
            }

            public void GetSalary()
            {
                Console.WriteLine("İşçiyim maaş diye birşey verdiklerini idda ederler.");
            }

            public void Work()
            {
                Console.WriteLine("İşçiyim Köpek Gibi Çalışırım.");
            }
        }
        class Managers : IWorker, IEat, IGetSalary
        {
            public void Eat()
            {
                Console.WriteLine("Yöneticiyim Köpek Gibi Yerim.");
            }

            public void GetSalary()
            {
                Console.WriteLine("Yöneticiyim maaş alırım.");
            }

            public void Work()
            {
                Console.WriteLine("Yöneticiyim Yatarak Çalışırım.");
            }
        }
    }
}
