using System;
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrya List
            ArrayList liste = new ArrayList{};
            liste.Add("METE");
            liste.Add(5);
            liste.Add(true);
            liste.Add('a');

            // içerisinde verilere erişme
            Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("******* ADD RANGE ******");
            string[] renkkler = {"mavi", "sari", "beyaz"};
            List<int> sayilar = new List<int>{1,5,7,6,8};
            liste.AddRange(renkkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Sort
            Console.WriteLine("******* SORT ******");
            liste.Sort();

              foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Binary Search
            Console.WriteLine("******* BİNARY SEARCH ******");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse
            Console.WriteLine("******* REVERSE ******");
            liste.Reverse();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Clear
            Console.WriteLine("******* CLEAR ******");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
