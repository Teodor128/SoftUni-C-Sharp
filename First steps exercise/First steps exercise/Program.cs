using System;

namespace First_steps_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double radiani = double.Parse(Console.ReadLine());
            double degrees = radiani * 180 / Math.PI;
            Console.WriteLine(degrees);


        }
    }
}
