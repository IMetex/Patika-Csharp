using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            
            string[] hayvanalar = {"kedi","kopek","kus"};

            int[] dizi;
            dizi = new int[5];

            // Dizilere değer atama ve erişim

            renkler[0] = "Mavi";
            Console.WriteLine(hayvanalar[0]);
            dizi[3] = 10;

            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanalar[2]);

            // Döngülerle dizi kullanımı

            //Klavyeden girilen n tane sayının ortalamasını hesaplayan program.
            Console.WriteLine("Lüften dizinin eleman sayısını giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz", i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach(var sayi in sayiDizisi)
                toplam += sayi;
            Console.WriteLine("Ortalama: "+toplam/diziUzunlugu);



        }
    }
}
