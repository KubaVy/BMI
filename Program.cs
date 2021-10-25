using System;

namespace BMI_domácí
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Výpočet BMI");

            Console.ReadLine();

            double hmotnost;
            double výška;
            double BMI;

            Console.WriteLine("Zadej hmotnost");
            hmotnost = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej výšku");
            výška = double.Parse(Console.ReadLine());
            BMI = hmotnost / ((výška / 100) * (výška / 100));
            BMI = Math.Round(BMI, 1);
            Console.WriteLine($"Vaše BMI je {BMI}");
            Console.WriteLine("ŽENY-Podváha = pod BMI 19; normální stav = 19-23,9; mírná obezita = 24-28,9; střední obezita = 29-38,9; těžká obezita = nad 39 ");
            Console.WriteLine("MUŽI-Podváha = pod 20; normální stav = 20-24.9; mirná obezita = 25-29,9; střední obezita = 30-39,9; těžká obezita = nad 40");

            Console.ReadLine();




        }
    }
}
