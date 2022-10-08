using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev6
{
    internal class Assignment
    {
     
        public void Menu()
        {

        start1:
            Console.WriteLine("Lütfen Seçim Yapınız.");
            Console.WriteLine("1 - Hazır Sınıf Listesini Kullanmak İstiyorum.");
            Console.WriteLine("2 - Hazır Sınıf Listesini Kullanarak Gruplu Atama Yapmak İstiyorum.");
            Console.WriteLine("3 - Yeni Sınıf Listesi Oluşturmak İstiyorum.");
            Console.WriteLine("4 - Yeni Sınıf Listesi Oluşturup Gruplu Atama Yapmak İstiyorum.");
            Console.WriteLine("5 - Çıkış Yap.");
            string selectMenu = Console.ReadLine();
            switch (selectMenu)
            {
                case "1":
                    MyClassList();
                    break;
                case "2":
                    GroupMyClassList();
                    break;
                case "3":
                    NewClassList();
                    break;
                case "4":
                    GroupNewClassList();
                    break;
                case "5":
                    Console.WriteLine("Çıkış Yapılıyor...");
                    Console.WriteLine("Bir Tuşa Basınız...");
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim Yaptınız Lütfen Tanımlı Seçenekler Üzerinden Seçim Yapınız. ( 1 - 2 - 3 - 4 - 5)");
                    goto start1;
                    break;
            }
        }
        public void MyClassList()
        {
            Random random = new Random();

            string[] classList = { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Mısra", "Büşra", "Mert Kutlu", "Mert Tutunmaz", "Sena", "Erhan", "Berkcan" };
            Console.WriteLine();
            Console.WriteLine("Rastgele Atama İşlemi Yapılıyor...");
            Console.WriteLine();
            for (int i = 0; i < classList.Length; i++)
            {
              
                    int select = random.Next(0, classList.Length - i);
                    Console.WriteLine((i + 1) + " " + classList[select]);
                    classList[select] = classList[classList.Length - i - 1];
               
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Menu();
        }
        public void NewClassList()
        {
            Console.WriteLine("Listeniz Kaç Kişiden Oluşacak?");
            int classCapacity = int.Parse(Console.ReadLine());
            string[] classList = new string[classCapacity];
            for (int i = 0; i < classCapacity; i++)
            {
                Console.Write($"Lütfen {i + 1}.kişiyi Giriniz: ");
                classList[i] = Console.ReadLine();
            }
            Random random = new Random();
            Console.WriteLine();
            Console.WriteLine("Rastgele Atama İşlemi Yapılıyor...");
            Console.WriteLine();

            for (int i = 0; i < classList.Length; i++)
            {
                int select = random.Next(0, classList.Length - i);
                Console.WriteLine((i + 1) + " " + classList[select]);
                classList[select] = classList[classList.Length - i - 1];
            }
            Console.WriteLine();
            Console.WriteLine();
            Menu();
        }
        public void GroupMyClassList()
        {
            Random random = new Random();

            string[] classList = { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Mısra", "Büşra", "Mert Kutlu", "Mert Tutunmaz", "Sena", "Erhan", "Berkcan" };
            Console.WriteLine("Listenizi Kaç Kişilik Gruplara Bölmek İstiyorsunuz ?");
            int numberOfGroups;
            
            
                 numberOfGroups = int.Parse(Console.ReadLine());
           
               

            
          
            int numberOfGroups2;
            if ((classList.Length % numberOfGroups) == 0)
            {
                numberOfGroups2 = classList.Length / numberOfGroups;
            }
            else
            {
                numberOfGroups2 = (classList.Length / numberOfGroups) + 1;
            }
            Console.WriteLine();
            Console.WriteLine($"{numberOfGroups} Kişilik Gruplar Halinde Rastgele Atama İşlemi Yapılıyor...");
            Console.WriteLine($"Toplam {numberOfGroups2} Grup Oluşturuldu.");
            Console.WriteLine();

            
            
            Console.WriteLine();
            if ((classList.Length % numberOfGroups) == 0)
            {
                for (int i = 0; i < numberOfGroups2; i++)
                {
                    Console.WriteLine($"{i + 1}.Grup");
                    for (int k = 0; k < numberOfGroups; k++)
                    {
                        int select = random.Next(0, classList.Length - k - (i * numberOfGroups));
                        Console.WriteLine(classList[select]);
                        classList[select] = classList[classList.Length - k - (i * numberOfGroups) - 1];
                    }
                    Console.WriteLine();
                }
            }
            else
            {
               for (int i = 0; i < numberOfGroups2; i++)
            {
                Console.WriteLine($"{i+1}.Grup");
                for (int k = 0; k < numberOfGroups; k++)
                {
                        if (i+1==numberOfGroups2)
                        {
                            if (k + (i * numberOfGroups) < ((numberOfGroups2-1)*numberOfGroups)+(classList.Length % numberOfGroups))
                            {
                                int select = random.Next(0, classList.Length - k - (i * numberOfGroups));
                                Console.WriteLine(classList[select]);
                                classList[select] = classList[classList.Length - k - (i * numberOfGroups) - 1];
                            }
                        }
                        else
                        {
                            int select = random.Next(0, classList.Length - k - (i * numberOfGroups));
                            Console.WriteLine(classList[select]);
                            classList[select] = classList[classList.Length - k - (i * numberOfGroups) - 1];
                        }
                    }
                Console.WriteLine();
            }
            }     
            
            Console.WriteLine();
            Console.WriteLine();
            Menu();
        }
        public void GroupNewClassList()
        {
            Console.WriteLine("Listeniz Kaç Kişiden Oluşacak?");
            int classCapacity = int.Parse(Console.ReadLine());
            string[] classList = new string[classCapacity];
            for (int i = 0; i < classCapacity; i++)
            {
                Console.Write($"Lütfen {i + 1}.kişiyi Giriniz: ");
                classList[i] = Console.ReadLine();
            }
            Random random = new Random();
            Console.WriteLine("Listenizi Kaç Kişilik Gruplara Bölmek İstiyorsunuz ?");
            int numberOfGroups = int.Parse(Console.ReadLine());
            int numberOfGroups2;
            if ((classList.Length % numberOfGroups) == 0)
            {
                numberOfGroups2 = classList.Length / numberOfGroups;

            }
            else
            {
                numberOfGroups2 = (classList.Length / numberOfGroups) + 1;

            }
            Console.WriteLine();
            Console.WriteLine($"{numberOfGroups} Kişilik Gruplar Halinde Rastgele Atama İşlemi Yapılıyor...");
            Console.WriteLine($"Toplam {numberOfGroups2} Grup Oluşturuldu.");
            Console.WriteLine();



            Console.WriteLine();
            if ((classList.Length % numberOfGroups) == 0)
            {
                for (int i = 0; i < numberOfGroups2; i++)
                {
                    Console.WriteLine($"{i + 1}.Grup");
                    for (int k = 0; k < numberOfGroups; k++)
                    {
                        int select = random.Next(0, classList.Length - k - (i * numberOfGroups));
                        Console.WriteLine(classList[select]);
                        classList[select] = classList[classList.Length - k - (i * numberOfGroups) - 1];
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < numberOfGroups2; i++)
                {
                    Console.WriteLine($"{i + 1}.Grup");
                    for (int k = 0; k < numberOfGroups; k++)
                    {
                        if (i + 1 == numberOfGroups2)
                        {
                            if (k + (i * numberOfGroups) < ((numberOfGroups2 - 1) * numberOfGroups) + (classList.Length % numberOfGroups))
                            {
                                int select = random.Next(0, classList.Length - k - (i * numberOfGroups));
                                Console.WriteLine(classList[select]);
                                classList[select] = classList[classList.Length - k - (i * numberOfGroups) - 1];
                            }
                        }
                        else
                        {
                            int select = random.Next(0, classList.Length - k - (i * numberOfGroups));
                            Console.WriteLine(classList[select]);
                            classList[select] = classList[classList.Length - k - (i * numberOfGroups) - 1];
                        }
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Menu();
        }
    }
}
