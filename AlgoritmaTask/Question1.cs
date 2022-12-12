using System;

namespace AlgoritmaTask
{
    class Question2
    {
        static void Main(string[] args)
        {
            
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            // Kullanıcıdan n adet sayı girmesi
            Console.Write("Bir pozitif sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan n adet sayı girmesini ister
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Bir pozitif sayı girin: ");
                int num = Convert.ToInt32(Console.ReadLine());

                // Girdiği sayı çiftse konsol ekranına yazdırır
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
