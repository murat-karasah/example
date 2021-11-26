using System;

namespace ConsoleApp6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("Adınız:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Yaşınız:");
            int yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Yaşınız:");

            int yas2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Adınız {ad} {soyad} \nYaşınız {yas} \nYaşınız {yas2}");
        
        }
    }
}
