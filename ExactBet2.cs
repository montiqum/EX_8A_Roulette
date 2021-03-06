using System;
using System.Collections.Generic;
using System.Text;

namespace EX_8A_Roulette
{
    class ExactBet2:ExactBet
    {
        public static bool ColumnsBet()
        {
            Console.WriteLine("What are the column numbers you'll like to bet on?" +
            " (eg. For the 2nd column enter 2 5 8 11 14 17 20 23 26 29 32 35)");
            string columns = Console.ReadLine();
            string[] columns2 = columns.Split(" ");
            int[] col = new int[columns2.Length];
            for (int i = 0; i < 12; i++)
            {
                col[i] = Int32.Parse(columns2[i]);
                if (col[i] == winnerNumber)
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
            }
            // set the color for the winning number   
            myColor = winnerColor;
            return true;
        }
        public static bool StreetBet()
        {
            Console.WriteLine("What Street/Row? (eg. For 1, 2 and 3 enter 1 2 3");

            string street = Console.ReadLine();
            string[] street2 = street.Split(" ");
            int firstnum = Int32.Parse(street2[0]);
            int secnum = Int32.Parse(street2[1]);
            int thirdnum = Int32.Parse(street2[2]);

            if (firstnum == winnerNumber || secnum == winnerNumber || thirdnum == winnerNumber)
            {
                Console.WriteLine("Winner!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
                return false;
            }
            // set the color for the winning number   
            myColor = winnerColor;
            return true;
        }
        public static bool Numbers6Bet()
        {
            Console.WriteLine("What are the six numbers you'll like to bet on?" +
            " (eg. For 7, 8, 9, 10, 11, and 12 enter 7 8 9 10 11 12)");
            
            string numbers6 = Console.ReadLine();
            string[] numbers6_2 = numbers6.Split(" ");
            int[] nums6 = new int[numbers6_2.Length];
            for (int i = 0; i < 6; i++)
            {
                nums6[i] = Int32.Parse(numbers6_2[i]);
                if(nums6[i] == winnerNumber)
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }
                
            }
            // set the color for the winning number   
            myColor = winnerColor;
            return true;            
        }
        public static bool SplitBet()
        {
            Console.WriteLine("What are the two numbers you'll like to split?" +
            " (eg. For 1 and 2 enter 1 2,  For 4 and 7 enter 4 7)");

            string split = Console.ReadLine();
            string[] split2 = split.Split(" ");
            int firstnum = Int32.Parse(split2[0]);
            int secnum = Int32.Parse(split2[1]);

            if (firstnum == winnerNumber || secnum == winnerNumber)
            {
                Console.WriteLine("Winner!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
                return false;
            }
            // set the color for the winning number   
            myColor = winnerColor;
            return true;
        }
        public static bool CornerBet()
        {
            Console.WriteLine("What are the four numbers you'll like to corner bet on?" +
            " (eg. For 23, 24, 26, 27 enter 23 24 26 27)");
            string corner = Console.ReadLine();
            string[] corner2 = corner.Split(" ");
            int[] cor = new int[corner2.Length];
            for (int i = 0; i < 4; i++)
            {
                cor[i] = Int32.Parse(corner2[i]);
                if (cor[i] == winnerNumber)
                {
                    Console.WriteLine("Winner!");
                }
                else
                {
                    Console.WriteLine("Better luck next time.");
                    return false;
                }

            }
            // set the color for the winning number   
            myColor = winnerColor;
            return true;
        }
    }
}
