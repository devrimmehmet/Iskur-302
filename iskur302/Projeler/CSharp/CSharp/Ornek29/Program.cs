using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();   
            
          // Deneme.sali
          
        }
        class Deneme
        {
            private static string salih = "Salih"; //private class özel tanımlama ve static class alt değişken olduğundan dışarıdan çağrıldığından erişilemez.
            public string e = "Elif";
            static int bursa = 15;
            public static string aaa = "mehmet";
            public string a = "Devrimm";
            private static string saliihh = "asdas";
            public void metot()
            {
               
            }
            public static void metot2()
            {

            }
            void denemeFonk()
            {

                Console.WriteLine(salih);
            }
        }
    }
}
