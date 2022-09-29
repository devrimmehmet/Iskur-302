using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw(); 

            // interfaceler newlenemez !! 
        }

       public interface IAraba
        {
             string Marka { get; set; }
             string Model { get; set; }

            string Renk { get; set; }
            string MaksHiz { get; set; }
        }
        public class Opel : IAraba  //impelemtasyon
        {
            public string Marka { get; set; }
            public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Renk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string MaksHiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        public class Bmw : IAraba
        {
            public string Marka { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Renk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string MaksHiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public string UstuAcik { get; set; }
        }
        public class Wolswogan : IAraba
        {
            public string Marka { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string Renk { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string MaksHiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string AzYakit { get; set; }
        }
    }
}
