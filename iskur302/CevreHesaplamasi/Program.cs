﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CevreHesaplamasi
{
    internal class Program
    {
        private int CevreHesaplama(int uzunluk,int genislik)
        {
            
            return (uzunluk + genislik) * 2;
        }
        private int AlanHesaplama(int uzunluk, int genislik)
        {
            
            return (uzunluk * genislik);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            
            int uzunluk=0, genislik=0;
            Console.WriteLine("Lütfen Uzunluğu Yazınız: ");
            uzunluk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen Genişliği Yazınız: ");
            genislik = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();
            Console.WriteLine("Çevre: "+ program.CevreHesaplama(uzunluk, genislik));
            Console.ReadLine();
            Console.WriteLine("Alan: " + program.AlanHesaplama(uzunluk, genislik));
            Console.ReadLine();
        }
    }
}
