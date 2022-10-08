using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMember;
            Console.Write("Kullanıcı sisteme üye mi: ");
            isMember = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Kullanıcının sistem üyelik durumu: " + isMember);
            Console.ReadLine();
        }
    }
}
