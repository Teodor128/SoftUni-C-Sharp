using System;

namespace _02._Summer_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int i = 2; i <= a; i += 2)
            {
                for (int j = 2; j <= b; j++)
                {
                    for (int k = 2; k <= d; k += 2)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            Console.WriteLine($"{j} {i} {k}");
                        }
                    }
                }
            }
        }
    }
}


