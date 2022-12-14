using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersiiz Csharp , Hoşgeldiniz !";
            string degiske2="Dersimiz CSharp";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper , ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(degiske2));

            //Compare , CompareTo
            Console.WriteLine(degisken.CompareTo(degiske2));
            Console.WriteLine(String.Compare(degisken,degiske2,true));
            Console.WriteLine(String.Compare(degisken,degiske2,false));

            //Contains
            Console.WriteLine(degisken.Contains(degiske2));
            Console.WriteLine(degisken.EndsWith("Hosgeldinz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf
            Console.WriteLine(degisken.IndexOf("Cs"));
            Console.WriteLine(degisken.LastIndexOf("i"));


            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba"));
        

            //PadLeft, PadRigth
            Console.WriteLine(degisken + degiske2.PadLeft(30));
            Console.WriteLine(degisken + degiske2.PadLeft(30,'*'));

            Console.WriteLine(degisken.PadRight(50) + degiske2);
            Console.WriteLine(degisken.PadRight(50,'_') + degiske2);

            //Remove 
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","Cs"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split
            Console.WriteLine(degisken.Split(' ')[1]);

            //Subtring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));







        }
    }
}