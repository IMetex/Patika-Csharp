using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parametreler
            string sayi = "999";
            int outSayi;

            bool sonuc = int.TryParse(sayi,out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Basarisiz");
                
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,3,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            // Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Barİs","Mete");

            //Metot Imzası 
            //metotAdi + parametre sayisi + parametere


        }
    }
    
    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a+b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
