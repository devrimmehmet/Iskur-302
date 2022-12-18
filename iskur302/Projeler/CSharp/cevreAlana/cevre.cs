using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cevreAlana
{
    public class cevre
    {
        public void alanHesapla(int birkenar)
        {
            int alan = 0;
            alan = birkenar * birkenar;
            Console.WriteLine("Alan: {0} Alan: {1} Alan {2} Alan {0}", alan, alan, alan);
        }




        public void cevreHesapla(int birkenar)
        {
            int cevre = 0;
            cevre = birkenar *4;
            Console.WriteLine("Çevre: {0} ", cevre );
        }
    }

    public class Arabalar
    {
        private string deneme;
        private int dogumtarihi;
        public string DENEME {
            get { return deneme; }
            set { deneme = value.ToUpper();} //value = devrim
        }
        public int DogumTarihi {
            get { return dogumtarihi; }
            set { dogumtarihi =DateTime.Now.Year- value; } 
            //value=1993   doğumtarihi=  2022-1993=29
            // DateTime.Now.Year
        }
    }
}
