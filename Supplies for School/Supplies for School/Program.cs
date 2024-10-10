using System;

namespace Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount= int.Parse(Console.ReadLine());
            int preparationCount = int.Parse(Console.ReadLine());
            double pensPrice = pensCount * 5.80;
            double markersPrice = markersCount * 7.20;
            double preparationPrice = preparationCount * 1.20;

        }
    }
}
