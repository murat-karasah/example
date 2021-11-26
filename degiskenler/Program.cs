using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sayı 1: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sayı 2: ");
            int sayi2 = int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.Clear();
            Console.WriteLine("Toplamı : " +toplam);

        }
    }
}
