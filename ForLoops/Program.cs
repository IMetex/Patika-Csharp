using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            Console.WriteLine("Bir sayı giriniz :");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i < sayac; i++)
            {
                if (i%2==1)
                   Console.WriteLine(i);
            }

            // 1 ile 1000 ile arasıdnaki tek ve çift sayıların kendi içlerindeki toplamı yazdır.
            int tektoplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i%2==1)
                   tektoplam+=i;
                else 
                   ciftToplam+=i;
            }
            Console.WriteLine("Tek Toplam: "+ tektoplam);
            Console.WriteLine("Çift Toplam: "+ ciftToplam);

            // break , contine komutları
            
            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                   break;
                Console.WriteLine(i); 
            }
              for (int i = 1; i < 10; i++)
            {
                if (i==4)
                   continue;
                Console.WriteLine(i); 
            }
        }
    }
}
