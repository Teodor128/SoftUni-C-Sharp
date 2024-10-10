using System;

namespace Godzila_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double priceOfStatist = double.Parse(Console.ReadLine());
            double dekor = budged * 0.10;
            double priceOfDres = priceOfStatist * statisti;

            if (statisti > 150)
            {
                priceOfDres = priceOfDres  - priceOfDres * 0.10;
            }
              if (dekor + priceOfDres  > budged)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {  (dekor + priceOfDres) - budged :F2} leva more.");
            }
              if (dekor + priceOfDres <= budged)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with { budged - (dekor + priceOfDres):F2} leva left.");
            }
        }
    }
}
