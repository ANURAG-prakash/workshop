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

        }
        public static int ToCheckWinOrLoss()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            return result;
        }
    }
}
      
