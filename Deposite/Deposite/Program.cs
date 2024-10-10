using System;

namespace Deposite
{
    class Program
    {
        static void Main(string[] args)
        {
            double depozit = double.Parse(Console.ReadLine());
            
            int srok = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double natrupanaLihva = depozit * (procent/100);
            double lihvaMesec = natrupanaLihva / 12;
            double obshtaSuma = depozit + srok * lihvaMesec;
            Console.WriteLine(obshtaSuma);

        }
    }
}
