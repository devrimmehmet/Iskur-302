using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek23
{
    internal class Program
    {
        bool varMi(string kelime,string arananKelime)
        {
            int varMiSonuc = kelime.IndexOf(arananKelime);
            bool varMi = true;
            if (varMiSonuc==-1)
            {
                 varMi = false;

            }else
            {
                varMi = true;
            }
            return varMi;

        }
        static void Main(string[] args)
        {
            /* Kendisine parametre olarak gelen cümle içinde
             * yine kendisine parametre olarak gelen kelimeyi arayıp ve eğer kelime var ise geriye true,
             * yok ise false değeri döndüren KelimeVarmi adında metodu yazınız*/

            Program salih = new Program();
            Console.WriteLine(salih.varMi("Devrim Mehmet Pattabanoğlu", "Dsevrim"));
            Console.ReadLine();
        }
    }
}
