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
                case "1": 
                case "2":
                case "3": 
                case "4": Console.WriteLine("1.Faz"); break;
                case "5": 
                case "6": 
                case "7": 
                case "8": Console.WriteLine("2.Faz"); break;
                case "9": 
                case "10": 
                case "11": 
                case "12": Console.WriteLine("3.Faz"); break;
                default:
                    hata();
                    break;
            }
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

                    break;
            }
        }

        private static void hata()
        {
            Console.WriteLine("lütfen geçerli bir sayı giriniz 1-12");
            Main(null);
        }
    }
}
