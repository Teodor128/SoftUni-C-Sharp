using System;

namespace Toy_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice  = double.Parse(Console.ReadLine());

            double puzzleQuantity= double.Parse(Console.ReadLine());

            double dollsQuantity = double.Parse(Console.ReadLine());

            double bearsQuantity = double.Parse(Console.ReadLine());

            double minionsQuantity = double.Parse(Console.ReadLine());

             double trucksQuantity = double.Parse(Console.ReadLine());


            double toysQuantity = puzzleQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;
            double totalPrice = puzzleQuantity*2.6 + dollsQuantity*3 + bearsQuantity*4.1 + minionsQuantity * 8.2 + trucksQuantity *2;

            if (toysQuantity >= 50 )
            {
                totalPrice = totalPrice - totalPrice * 0.25;
            }

            totalPrice = totalPrice - totalPrice * 0.10;

            if (totalPrice >= tripPrice )
            {
                Console.WriteLine($"Yes! {totalPrice - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPrice:F2} lv needed.");
            }

        }
    }
}
