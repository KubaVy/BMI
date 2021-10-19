using System;

namespace BMI
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
            Console.ReadLine();
            









        }   

    }
}
