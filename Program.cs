using System;

namespace UC1_Gambler
{
    class Program
    {
        static void Main(string[] args)
        {
            int MoneyInDollar = 100;
            int bet=1
           Random random = new Random;
            int result = random.Next(0, 2);
            if (result == 1)
                Console.WriteLine("win");
            else
                Console.WriteLine("losse");
           
        }
    }
}
