using System;

namespace Extension_Rekursif_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinemeli
            // 3^4

            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));


            // Extension Metotlar
            string ifade = "Baris Mete";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeLowerCase);
            Console.WriteLine(ifade.MakeUpperCase);

            int[] dizi = {9,2,4,5,3,1,4};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int a = 5;
            Console.WriteLine(a.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());

        }
    }

    public class Islemler {

        public int Expo(int sayi, int us)
        {
            if(us<2)
              return sayi;
            return Expo(sayi,us-1)*sayi;
        }
        //Expo(3,4)
        //Expo(3,3) *3;
        //Expo(3,2) * 3 * 3;
        //Expo(3-1) * 3 * 3 * 3;
        //3*3*3*3 = 3^4;

    }
    public static class Extension{

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();

        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();

        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;

        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach(int item in param)
            Console.WriteLine(item);
        }
        public static bool IsEvenNumber(this int param) 
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
    }
}