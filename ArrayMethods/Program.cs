using System;

namespace ArraysMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short Metodu

            int[] sayiDizisi = {23,12,4,8,72,5,1,17};

            Console.WriteLine("*** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("*** Sıralı Dizi *****");
            Array.Sort(sayiDizisi); //Küçükten büyüğe doğru sıralar
             foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear Metodu

            Console.WriteLine("*** Clear Method *****");
            Array.Clear(sayiDizisi,2,2); // 2 indekten itaberen 2 elemanı sıfırlar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse Metodu

            Console.WriteLine("*** Reverse Method *****"); 
            Array.Reverse(sayiDizisi); // diziyi tersten alır ayni aynalar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // IndexOf  Metodu

            Console.WriteLine("*** IndexOf Method *****"); 
            Console.WriteLine( Array.IndexOf(sayiDizisi,23));  // elemanın kaçıncı indekste olduğunu gösterir.

            // Resize Metodu
            
            Console.WriteLine("*** Resize Method *****"); 
            Array.Resize<int>(ref sayiDizisi,9); // dizimizin boyutunu artırır.
            sayiDizisi[8] =15;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }
}