using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme1
{
    class Program
    {
        static void Main()
        {
            int[] sayilar = { 20, 11, 12, 23, 45, 88, 34, 78, 66, 40, 44, 56, 77, 13, 90, 61, 50, 89, 4, 45 };
            Console.WriteLine("Sıralanmamış Sayılar Dizisi:");
            DiziyiYazdir(sayilar);

            int n = sayilar.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sayilar[j] > sayilar[j + 1])
                    {
                        int gecici = sayilar[j];
                        sayilar[j] = sayilar[j + 1];
                        sayilar[j + 1] = gecici;
                    }
                }
            }

            Console.WriteLine("\nKüçükten Büyüğe Sıralanmış Dizi:");
            DiziyiYazdir(sayilar);
        }

        static void DiziyiYazdir(int[] dizi)
        {
            foreach (var sayi in dizi)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}