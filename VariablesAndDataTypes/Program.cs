using System;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static void Main(string[] arg)
        {
            // Değişken yazma şekilleri
            int deger = 2;
            string degisken = null;
            string degisken4 = null;
            string Desigken = null;
            string degisken_veri = null;
            string degisken2 = " ";

            // veri tipleri 

            byte b = 5;   // 1 byte yer kaplar bellekte 
            sbyte c = 3;  // 1 byte yer kaplar bellekte 

            short s = 4;   // 2 byte yer kaplar bellekte
            ushort us =5;  // 2 byte yer kaplar bellekte

            // Tam Sayılar için kullanılır

            Int16 i16 =2;   // 2 byte yer kaplar 
            int i = 2;      // 4 byte yer kaplar
            Int32 i32 = 2;  // 4 byte yer kaplar
            Int64 i64 = 2;  // 8 byte yer kaplar

            uint ui = 2;    // 4 byte yer kaplar
            long l = 4;     // 8 byte yer kaplar 
            ulong ul =4;    // 8 byte yer kaplar
            
            // Reel Sayılar için kullanılır

            float f = 4;    // 4 byte yer kaplar
            double d = 4;   // 8 byte yer kaplar
            decimal de= 4;  // 16 byte yer kaplar

            // Yazı ifadeleri için kullanılır

            char ch = '2';    // 2 byte yer kaplar
            string str = "4"; // sınırsız yer kaplar
 
            // Zaman Metodu

            DateTime dt = DateTime.Today; 
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.2;

            // String ifadeler

            string str1 = string.Empty;
            str1 = "Barış Mete";
            string ad = "Barış";
            string soyad = "Mete";
            string tamIsim = ad + " " + soyad;

            // Integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 2;
            int integer3 = integer1 * integer2;

            // boolean

            bool bool1 = 10>2;

            //Değişkenler Dönüşümleri
            
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);  // Çıktısı 40 dır.

            // DateTime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");  // Tarihi alıyoruz
            Console.WriteLine(datetime2);
            string datetime3 = DateTime.Now.ToString("HH:mm"); // Saat alırız
            Console.WriteLine(datetime3);






    

        












 
        }
    }
}
