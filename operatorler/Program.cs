using System;
namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sayi :");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayi :");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşlem seçiniz T-C-B-Ça-M :");
            string c = Console.ReadLine();
            Console.Clear();
            if (c == "T")
            {
                int toplama = s1 + s2;
                Console.WriteLine(toplama.ToString());
            }
            else if (c== "C")
            {
                int cikarma = s1 - s2;
                Console.WriteLine(cikarma.ToString());
            }
            else if (c=="B")
            {
                if (s2==0)
                {
                    Console.WriteLine("Hata...");

                }
                else
                {
                    int bolme = s1 / s2;
                    Console.WriteLine(bolme.ToString());
                }
            }
            else if (c=="Ç")
            {
                int carpma = s1 * s2;
                Console.WriteLine(carpma.ToString());
            }
            else if (c=="M")
            {
                int mod = s1 % 2;
                Console.WriteLine(mod.ToString());

            }
            else
            {
                Main(null);
            }
            //  int mod2 = s2 % 2;
            // Console.WriteLine($"Toplama Sonucu : {toplama}\nÇıkartma Sonucu : {cikarma}\nBölme Sonucu : {bolme}\nÇarpma Sonucu : {carpma}\n1.Sayı mod 2 Sonucu : {mod}\n2.Sayı mod 2 Sonucu : {mod2}");
        }
    }
}