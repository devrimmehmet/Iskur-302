using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region math sınıfı
            //double sayi;
            //Console.WriteLine("Lütfen bir sayı giriniz:");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mutlak Değeri : "+Math.Abs(sayi));
            //Console.WriteLine("Aşağı Yuvarla : " + Math.Floor(sayi));
            //Console.WriteLine("Yukarı Yuvarla : " + Math.Ceiling(sayi));
            //Console.WriteLine("Yuvarla : " + Math.Round(sayi));
            #endregion
            #region random 
            //Random rastgele = new Random();
            //int b;
            //b = rastgele.Next(0,10);
            //Console.WriteLine(b);
            /*
                        string[] liste = {"Kastamonu","Kütahya","İstanbul","Ankara","İzmir" };

                        Random rastgele = new Random();

                        int a;
                        a = rastgele.Next(0,liste.Length);
                        Console.WriteLine(liste[a]);

                        Console.ReadLine();
            */
            #endregion

            //   string[,] dizi = new string[1,2];
            //string[,] dizi = { {"mehmet","salih" },{"ali","veli" }};
            //string[,] dizi1 =new string[2,2];
            //Console.WriteLine(dizi[0, 1]);
            //dizi1[0, 0] = "mehmet";
            //dizi1[0, 1] = "salih";
            //dizi1[1, 0] = "ali";
            //dizi1[1, 1] = "veli";
            //foreach (var item in dizi1)
            //{
            //    Console.WriteLine(item);
            //}
            //int i=0, j=0;
            //Console.WriteLine("Satır Sayısı Giriniz");
            // i=int.Parse(  Console.ReadLine());
            //Console.WriteLine("Sütun Sayısı Giriniz");
            // j = int.Parse( Console.ReadLine());
            //string[,] dizi = new string[i,j];

            //int[,] dizi2 = new int[2, 2];
            //dizi2[0, 0] = 11;
            //dizi2[0, 1] = 12;
            //dizi2[1, 0] = 13;
            //dizi2[1, 1] = 14;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write("[{0},{1}]:{2} ", i, j,  dizi2[i,j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();

            //}


            //int[,] dizi2 = { {14,17,18,19,12},{13,17,11,13,19 },{15,18,10,14,20 } };

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("{0} ", dizi2[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();

            //}

            //Console.ReadLine();


            //int[,] dizi5 = { { 14, 17, 18, 19, 12 }, { 13, 17, 11, 13, 19 }, { 15, 18, 10, 14, 20 } };
            //int[,] dizi6 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            //int[,] dizi7 =new int [3,5];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        dizi7[i, j] = dizi5[i, j] + dizi6[i, j];
            //        Console.Write(dizi7[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();

            //}

            //Console.ReadLine();


            #region Klavyeden bilgileri girilen iki matrisin toplamını veren program.


            //int satir, sütun;

            //Console.WriteLine("Lütfen Matris satır sayısını Yazınız.");
            //satir = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen Matris sutün sayısını Yazınız.");
            //sütun = int.Parse(Console.ReadLine());
            //int[,] matris1 = new int[satir,sütun];
            //int[,] matris2 = new int[satir,sütun];
            //int[,] matris3 = new int[satir, sütun];
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sütun; j++)
            //    {
            //        Console.WriteLine("Birinci Matrisin {0},{1} değerini yazınız : ", i, j);
            //        matris1[i, j] =int.Parse( Console.ReadLine());

            //    }
            //}Console.WriteLine("***************");
            //Console.WriteLine("***************");
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sütun; j++)
            //    {
            //        Console.WriteLine("İkinci Matrisin {0},{1} değerini yazınız : ", i, j);
            //        matris2[i, j] = int.Parse(Console.ReadLine());

            //    }
            //}
            //Console.WriteLine("***************");
            //Console.WriteLine("***************");
            //Console.WriteLine("Matris 1");
            //Console.WriteLine("***************");
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sütun; j++)
            //    {

            //        Console.Write(matris1[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("***************");
            //Console.WriteLine("***************");
            //Console.WriteLine("Matris 2");
            //Console.WriteLine("***************");
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sütun; j++)
            //    {

            //        Console.Write(matris2[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("***************");
            //Console.WriteLine("***************");
            //Console.WriteLine("Matris 1 ve Matris 2 Toplamı");
            //Console.WriteLine("***************");
            //for (int i = 0; i < satir; i++)
            //{
            //    for (int j = 0; j < sütun; j++)
            //    {
            //        matris3[i, j] = matris1[i, j] + matris2[i, j];
            //        Console.Write(matris3[i,j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            //int[,] dizi5 = { { 14, 17, 18, 19, 12 }, { 13, 17, 11, 13, 19 }, { 15, 18, 10, 14, 20 } };
            //int[,] dizi6 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            //int[,] dizi7 = new int[3, 5];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        dizi7[i, j] = dizi5[i, j] + dizi6[i, j];
            //        Console.Write(dizi7[i, j]);
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();

            //}

            #region metotlara

            #endregion



            Console.ReadLine();
        }
    }
}
