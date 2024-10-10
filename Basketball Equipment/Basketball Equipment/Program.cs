using System;

namespace Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double gCena = double.Parse(Console.ReadLine());
            double kecove =  gCena - gCena * (40/100.0);
            double outfit = kecove - kecove * (20 / 100.0);
            double ball = outfit / 4;
            double acc = ball / 5;
            double sum = gCena + kecove + outfit + ball + acc;
            Console.WriteLine(sum);

        }
    }
}

