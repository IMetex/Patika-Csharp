using System;

namespace While_Forecah_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loops

            // 1 den başlayarak  console dan girilen girilen sayıya kadar(sayı dahil) ortalamayı yazdıran program.
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <=sayi)
            {
                toplam+=sayac;
                sayac++;               
            }
            Console.WriteLine(toplam/sayi);

            // "a" dan "z" ye kadar tüm harfleri  console a yazdır.

            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character++;  
            }

            // Foreach Loops

            string[] arabalar = {"bwm","ford","audi"};
            
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}


