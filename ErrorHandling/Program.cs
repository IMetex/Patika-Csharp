using System;

namespace ErorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi :"+ sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata:" +ex.Message.ToString());       
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı");  
            }


            try
            {
                int a = int.Parse(null);
                int b =int.Parse("test");
                int c = int.Parse("-2000000000000");
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya çok küçük değer girdiniz");
                Console.WriteLine(ex);

            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı");
            }
        }
    }
}
