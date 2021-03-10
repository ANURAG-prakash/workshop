using System;

namespace Workshop
{
    class Program
    {
        public const int stack = 100;
        public const int bet = 1;


        static void Main(string[] args)
        {
            int result = ToCheckWinOrLoss();
            int profit = 0, loss = 0;

            while (profit <50 && loss <50)
            {
                if (result == 1)
                    profit += 1;

                else if (result == 0)
                    loss += 1;

            }
            Console.WriteLine(profit);
            Console.WriteLine(loss);


        }
        public static int ToCheckWinOrLoss()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            return result;
        }
    }
}
      
