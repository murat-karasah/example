using System;

namespace switch_ex
{
    class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Bir sayı giriniz");
            string  enter = Console.ReadLine();
            switch (enter)
            {
                case "1":Console.WriteLine("ocak"); break;
                case "2": Console.WriteLine("şubat"); break;
                case "3": Console.WriteLine("mart"); break;
                case "4": Console.WriteLine("nisan"); break;
                case "5": Console.WriteLine("mayıs"); break;
                case "6": Console.WriteLine("haziran"); break;
                case "7": Console.WriteLine("temmuz"); break;
                case "8": Console.WriteLine("ağustos"); break;
                case "9": Console.WriteLine("eylül"); break;
                case "10": Console.WriteLine("ekim"); break;
                case "11": Console.WriteLine("kasım"); break;
                case "12": Console.WriteLine("aralık"); break;
                default:
                    Console.WriteLine("lütfen geçerli bir sayı giriniz 1-12");
                    Main(null);
                    break;
            }
        }
}
}
