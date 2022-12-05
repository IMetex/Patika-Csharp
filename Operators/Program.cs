using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama Ve İşlemli Atama

            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);
            
            y += 2;
            Console.WriteLine(y);
            
            y /=1;
            Console.WriteLine(y);

            x *=2;
            Console.WriteLine(x);

            // Mantıksal Operatörler
            // || , && , !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
               Console.WriteLine("Perfect!");
            
             if(isSuccess || isCompleted)
               Console.WriteLine("Great!");

             if(isSuccess && !isCompleted)
               Console.WriteLine("Fine!");
            
            // İlşkisel Operatörler
            // < , > , <= , >= , == , !=

            int a = 4;
            int b = 5;
            bool result = a<b;
            Console.WriteLine(result);

            result = a>b;
            Console.WriteLine(result);

            result = a>=b;
            Console.WriteLine(result);

            result = a<=b;
            Console.WriteLine(result);

            result = a==b;
            Console.WriteLine(result);

            result = a!=b;
            Console.WriteLine(result);
            

            // Aritmetiksel Operatörler
            // + , - , * , / , ** vs

            int sayi1 = 10;
            int sayi2 = 5;
            int result2 = sayi1 / sayi2;
            Console.WriteLine(result2);

            result2 = sayi1 + sayi2;
            Console.WriteLine(result2);

            result2 = sayi1 ++;  
            Console.WriteLine(result2);

            // % Mod alama operatörü
            
            int result3 = 20 % 3;
            Console.WriteLine(result3);


        }
    }

}
    

