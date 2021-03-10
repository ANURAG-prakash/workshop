using System;

namespace Workshop
{
    class Program
    {
        public const int stack = 100;
        public const int bet = 1;


        static void Main(string[] args)
        {
            ToCheckWinOrLoss();
           ToWinOrLoss();
            WinLoss20Days();
          
        }
        public static int ToCheckWinOrLoss()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            return result;
        }
        public static int ToWinOrLoss()
        {
            int STACK = stack;
            int result = ToCheckWinOrLoss();
            while (STACK < 150 && STACK > 50)
            {
                if (result == 0)
                    STACK = STACK - bet;
                else if (result == 1)
                    STACK = STACK + bet;
            }
            return STACK;
        }
        public static void WinLoss20Days()
        {
            int days= ToWinOrLoss();
            for (int i=1;i<=20;i++)
            {
               
                if (days == 150)
                    Console.WriteLine(ToWinOrLoss());
                else if ( days == 50) 
                    Console.WriteLine(ToWinOrLoss());
            }

        }
    }
}
      
