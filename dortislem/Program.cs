using System;

namespace dortislem
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen İşlem Seçiniz :\n1-Toplama\n2-Çıkartma\n3-Bölme\n4-Çarpma \nYapmak istediğiniz işlemin kodunu giriniz...");
            string enter = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("1.Sayı : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (enter)
            {
                case "1":
                    int toplama = sayi1 + sayi2;
                    Console.WriteLine("Sonuç : " +toplama);
                    break;
                case "2":
                    int cikartma = sayi1 -sayi2;
                    Console.WriteLine("Sonuç : " + cikartma);
                    break;
                case "3":
                    if (sayi2==0)
                    {
                        Console.WriteLine("Hat");

                    }
                    else
                    {
                        int bolme = sayi1 / sayi2;
                        Console.WriteLine("Sonuç : " + bolme);
                    }
                    
                    break;
                case "4":
                    int carpma = sayi1*sayi2;
                    Console.WriteLine("Sonuç : " + carpma);
                    break;
                default:
                    Main(null);
                    break;
            }

        }

       
    }
}
