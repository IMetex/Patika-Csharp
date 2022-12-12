using System;

namespace AlgoritmaTask
{
    class Question3
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Bir pozitif sayi girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Kullanıcıdan n adet kelime girmesini ister
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir kelime girin: ");
                words[i] = Console.ReadLine();
            }

            // Kelimeleri sondan başa doğru yazdırır
            foreach (var word in words.Reverse())
            {
                Console.WriteLine(word);
            }

        }
    }
}
