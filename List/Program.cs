using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List class
            //System.Colletion.Generic
            // T -> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(5);
            sayiListesi.Add(19);
            sayiListesi.Add(7);
            sayiListesi.Add(55);
            sayiListesi.Add(8);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("mavi");
            renkListesi.Add("yesil");
            renkListesi.Add("sari");

            //Count 
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(55);
            renkListesi.Remove("mavi");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste icerisinde arama

            if (sayiListesi.Contains(5))
            {
                Console.WriteLine("5 liste içerisinde bulundu");
            }

            // Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("sari"));

            // Diziyi Listeye cevirme
            string[] hayvanlar = { "kedi", "köpek", "kuş" };
            List<string> hayvannListesi = new List<string>();

            //Listeyi nasıl temizleriz
            hayvannListesi.Clear();

            // List içerisinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Baris";
            kullanici2.Soyisim = "Mete";
            kullanici2.Yas = 24;

            kullaniciListesi.Add(kullanici2);

        }
        public class Kullanicilar
        {
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim
            {
                get => isim;
                set => isim = value;
            }
            public string Soyisim
            {
                get => soyisim;
                set => soyisim = value;
            }
            public int Yas
            {
                get => yas;
                set => yas = value;
            }

        }
    }
}
