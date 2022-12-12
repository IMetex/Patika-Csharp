using System;

namespace AlgoritmaTask
{
    class Question2
    {
        static void Main(string[] args)
        {
            
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Birinci pozitif sayıyı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci pozitif sayıyı girin: ");
            int m = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan n adet sayı girmesini ister
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Bir pozitif sayı girin: ");
                int num = Convert.ToInt32(Console.ReadLine());

                // Girdiği sayı m'e tam bölünüyorsa konsol ekranına yazdırır
                if (num % m == 0)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
