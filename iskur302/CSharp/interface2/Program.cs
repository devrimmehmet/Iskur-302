using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iinterface2[] veritabani = new Iinterface2[] {
                new SqlServer(),
                new OracleServer(),
                new MySql()
            };


            foreach (var veri in veritabani)
            {
                veri.Update();
            }
            Console.ReadLine();
        }
        
    }
   
}
