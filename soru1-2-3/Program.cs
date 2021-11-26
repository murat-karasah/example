using System;

namespace soru1_2_3
{
    class Program
    {
        static void Main(string[] args)
        {

           string metin = "false";
           bool a = bool.Parse(metin);
           Console.WriteLine("Soru 1 : "+a);

            int sayi = 100;
            byte b = (byte)sayi;
            float f = sayi;
            Console.WriteLine($"Soru 2:\n-int sayi :{sayi} \n-Byte b: {b}\n-Float f : {f}");


            byte by = 3;
            decimal d = by;
            Console.WriteLine("Soru 3 : " + d);


        }
    }
}
