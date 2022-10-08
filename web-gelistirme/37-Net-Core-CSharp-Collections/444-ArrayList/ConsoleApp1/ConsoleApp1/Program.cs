using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList myList=new ArrayList();
            myList.Add(10.5);
            myList.Add("10");
            myList.Add("abc");
            myList.Add(10.5);
            myList.Insert(1,20);
            IList myList2=new ArrayList { "******","10","abc",10.5};
            Console.WriteLine(myList[0]);
            //int sayi = (int)myList[0];
            myList.InsertRange(3,myList2);
            // remove
            myList.Remove(10.5);
            myList.Remove("abc");
            myList.Remove("abc");
            myList.RemoveRange(0,2); // index nosuna göre silme 0dan sonraki 2 elemanı siler
            myList.RemoveAt(0); // 0.indexteki elemanı siler.
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myList.Contains(10.5));
            ArrayList sayilar = new ArrayList() { 5,4,10,15,3};
            sayilar.Sort();
            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }

        }
    }
}
