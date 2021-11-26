using System;

namespace ortalama
{
    class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            Console.WriteLine("1.Notu Giriniz:");
            bool bl = int.TryParse(Console.ReadLine(),out not1);
            Console.WriteLine("2.Notu Giriniz:");
            bool bl2 = int.TryParse(Console.ReadLine(), out not2);
            Console.WriteLine("3.Notu Giriniz:");
            bool bl3 = int.TryParse(Console.ReadLine(), out not3);
                        if (bl == false || bl2 == false || bl3==false)
                        {
                            Console.Clear();
                        Console.WriteLine("lütfen not girerken rakamları kullanın...");
                        Main(null);
                        }
                        else
                        {
                                            Console.Clear();
                                            if (not1>100 || not2>100 || not3>100)
                                            {
                                                Console.WriteLine("Notları kontrol ediniz");
                                                Main(null);
                                            }
                                            else
                                            {
                                                    int ortalama = (not1 + not2 + not3) / 3;
                                                    if (ortalama >= 45)
                                                    {
                                                        if (ortalama <= 70)
                                                        {
                                                            Console.WriteLine("Derece : ORTA");
                                                        }
                                                        else
                                                        {
                                                            if (ortalama <= 85)
                                                            {
                                                                Console.WriteLine("Derece : İYİ");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Derece : Başarılı");
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("Başarısız... Kaldınız :S");
                                                    }
                                            }
                        }
        }
    }
}
