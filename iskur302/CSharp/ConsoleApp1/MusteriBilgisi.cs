using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class MusteriBilgisi
    {
        string _adi; //field
        public int Id { get; set; }
        public string Adi {
            get { return "Dr."+_adi; }
            set { _adi = value; }
        }
        public string Soyadi { get; set; }
        public string Adres { get; set; }



    }
}
