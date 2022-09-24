using System;
using System.Globalization;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mounth = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık" };
            DateTime now = DateTime.Now;
            Console.WriteLine("Tarih,Saat: "+now);
            Console.WriteLine("Ay: "+now.Month);
            Console.WriteLine("Ay: " + mounth[now.Month-1]);
            Console.WriteLine("Gün: "+now.Day);
            Console.WriteLine("Yıl: "+now.Year);
            Console.WriteLine("Saat: " + now.Hour);
            Console.WriteLine("Gün: " + now.DayOfWeek);
            Console.WriteLine("Yılın kaçıncı günü: " + now.DayOfYear);
            Console.WriteLine("Saniye: " + now.Second);

            DateTime dt = new DateTime(1993,8,20,08,00,00);

             dt = dt.AddHours(-22);
            dt = dt.AddYears(1);
            Console.WriteLine(dt);

            Console.WriteLine( ((now - dt).TotalDays)/365);

            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("ddd MMM %d, yyyy"));

            CultureInfo culture = new CultureInfo("en");
            Console.WriteLine(now.ToString("F",culture)) ;

        }   
    }
}
