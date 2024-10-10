using System;

namespace exellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if ((grade >= 5.50) && (grade<=6))
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Try again");

            }
            
            

            

        }
    }
}
