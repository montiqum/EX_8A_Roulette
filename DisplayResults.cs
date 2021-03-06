using System;
using System.Collections.Generic;
using System.Text;

namespace EX_8A_Roulette
{
    class DisplayResults
    {
        
        public static void Display_Results()
        {
            int num = ExactBet.winnerNumber;
            int mynum = ExactBet.myNumber;
            string color1 = ExactBet.winnerColor;



            Console.WriteLine($"Status of All Bets:\n\r");

            if (num == mynum)//Number Bet
            {
                Console.WriteLine($"Number Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"Number Bet : Loser!");
            }
            if (num % 2 == 0 && num != 0 && num != 37) //Even Bet
            {
                Console.WriteLine($"Even Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"EvenBet : Loser!");
            }
            if (num % 2 != 0 && num != 0 && num != 37) //Odd Bet
            {
                Console.WriteLine($"Odd Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"Odd Bet : Loser!");
            }
            if (color1 == "red") //Red Bet
            {
                Console.WriteLine($"Red Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"Red Bet : Loser!");
            }
            if (color1 == "black") //Black Bet
            {
                Console.WriteLine($"Black Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"Black Bet : Loser!");
            }
            if (num >= 1 && num <= 18) //Low Bet
            {
                Console.WriteLine($"Low Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"Low Bet : Loser!");
            }
            if (num >= 19 && num <= 36) //High Bet
            {
                Console.WriteLine($"High Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"High Bet : Loser!");
            }
            if (num >= 1 && num <= 12) //1st Dozen
            {
                Console.WriteLine($"1st Dozen Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"1st Dozen Bet : Loser!");
            }
            if (num >= 13 && num <= 24) //2nd Dozen
            {
                Console.WriteLine($"2nd Dozen Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"2nd Dozen Bet : Loser!");
            }
            if (num >= 25 && num <= 36) //3rd Dozen
            {
                Console.WriteLine($"3rd Dozen Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"3rd Dozen Bet : Loser!");
            }
            if ((num + 2) % 3 == 0) //1st Column
            {
                Console.WriteLine($"1st Column Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"1st Column Bet : Loser!");
            }
            if ((num + 1) % 3 == 0) //2nd Column
            {
                Console.WriteLine($"2nd Column Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"2nd Column Bet : Loser!");
            }
            if ((num != 0 || num != 37) && num % 3 == 0) //3rd Column
            {
                Console.WriteLine($"3rd Column Bet : Winner!");
            }
            else
            {
                Console.WriteLine($"3rd Column Bet : Loser!");
            }
            int i = num; //Street Bet

            switch (i)
            {
                case int n when (n >= 1 && n <= 3):
                    Console.WriteLine($"1st Street Winner!");
                    break;

                case int n when (n >= 4 && n <= 6):
                    Console.WriteLine($"2nd Street Winner!");
                    break;

                case int n when (n >= 7 && n <= 9):
                    Console.WriteLine($"3rd Street Winner!");
                    break;
                case int n when (n >= 10 && n <= 12):
                    Console.WriteLine($"4th Street Winner!");
                    break;
                case int n when (n >= 13 && n <= 15):
                    Console.WriteLine($"5th Street Winner!");
                    break;
                case int n when (n >= 16 && n <= 18):
                    Console.WriteLine($"6th Street Winner!");
                    break;
                case int n when (n >= 19 && n <= 21):
                    Console.WriteLine($"7th Street Winner!");
                    break;
                case int n when (n >= 22 && n <= 24):
                    Console.WriteLine($"8th Street Winner!");
                    break;
                case int n when (n >= 25 && n <= 27):
                    Console.WriteLine($"9th Street Winner!");
                    break;
                case int n when (n >= 28 && n <= 30):
                    Console.WriteLine($"10th Street Winner!");
                    break;
                case int n when (n >= 31 && n <= 33):
                    Console.WriteLine($"11th Street Winner!");
                    break;
                case int n when (n >= 34 && n <= 36):
                    Console.WriteLine($"12th Street Winner!");
                    break;
                case int n when (n == 0 || n == 37):
                    Console.WriteLine($"Street Bet Loser!");
                    break;
            }
            int j = num; //6 Numbers Bet

            switch (j)
            {
                case int n when (n >= 1 && n <= 6):
                    Console.WriteLine($"1st Double Rows Winner!");
                    break;

                case int n when (n >= 4 && n <= 9):
                    Console.WriteLine($"2nd Double Rows Winner!");
                    break;

                case int n when (n >= 7 && n <= 12):
                    Console.WriteLine($"3rd Double Rows Winner!");
                    break;
                case int n when (n >= 10 && n <= 15):
                    Console.WriteLine($"4th Double Rows Winner!");
                    break;
                case int n when (n >= 13 && n <= 18):
                    Console.WriteLine($"5th Double Rows Winner!");
                    break;
                case int n when (n >= 16 && n <= 21):
                    Console.WriteLine($"6th Double Rows Winner!");
                    break;
                case int n when (n >= 19 && n <= 24):
                    Console.WriteLine($"7th Double Rows Winner!");
                    break;
                case int n when (n >= 22 && n <= 27):
                    Console.WriteLine($"8th Double Rows Winner!");
                    break;
                case int n when (n >= 25 && n <= 30):
                    Console.WriteLine($"9th Double Rows Winner!");
                    break;
                case int n when (n >= 28 && n <= 33):
                    Console.WriteLine($"10th Double Rows Winner!");
                    break;
                case int n when (n >= 31 && n <= 36):
                    Console.WriteLine($"11th Double Rows Winner!");
                    break;
                case int n when (n == 0 || n == 37):
                    Console.WriteLine($"Double Rows Bet Loser!");
                    break;
            }
            for (int k = 1; k < 37; k++)//Split Bet and Corner bet
            {
                if (num == k)
                {
                    Console.WriteLine($"{num} Split Bet : Winner!");
                    Console.WriteLine($"{num} Corner Bet : Winner!");
                    break;
                }
                else
                {
                    Console.WriteLine($"{k} Split Bet : Loser!");
                    Console.WriteLine($"{k} Corner Bet : Loser!");
                }
            }
           








        }
    }
}
