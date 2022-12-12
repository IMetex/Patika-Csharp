using System;

namespace AlgoritmaTask
{
    class Question4
    {
        static void Main4(string[] args)
        {

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir cümle girin: ");
            string sentence = Console.ReadLine();

            // Kelime ve harf sayısını bulur
            int wordCount = sentence.Split(' ').Length;
            int charCount = sentence.Length;

            // Kelime ve harf sayısını konsol ekranına yazdırır
            Console.WriteLine($"Cümlenizde toplam {wordCount} kelime ve {charCount} harf bulunmaktadır.");

        }
    }
}
