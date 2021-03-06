using System;
using System.Collections.Generic;
using System.Text;

namespace EX_8A_Roulette
{
    class Roulette
    {

        private static int[] numbers = new int[38];
        int end = numbers.Length - 1;
        public static string[] colors = new string[38];
        int _end = colors.Length - 1;
        private Random _random = new Random();
        public int winner { get; set; }
        public int Color { get; set; }

        public Roulette()
        {
            numbers = GetNumbers();
            colors = GetColors();
        }

        private int[] GetNumbers()
        {
            for (int i = 0; i < end; i++)
            {
                numbers[i] = i;
            }
            numbers[end] = 37; //for 00

            return numbers;
        }
        public string[] GetColors()
        {
            colors[0] = "green";
            colors[37] = "green";
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    colors[i] = "black";
                }
                else
                {
                    colors[i] = "red";
                }
            }
            for (int i = 11; i < 19; i++)
            {
                if (i % 2 == 0)
                {
                    colors[i] = "red";
                }
                else
                {
                    colors[i] = "black";
                }
            }
            for (int i = 19; i < 29; i++)
            {
                if (i % 2 == 0)
                {
                    colors[i] = "black";
                }
                else
                {
                    colors[i] = "red";
                }
            }
            for (int i = 29; i < 37; i++)
            {
                if (i % 2 == 0)
                {
                    colors[i] = "red";
                }
                else
                {
                    colors[i] = "black";
                }
            }
            return colors;
        }

        public void PrintBetTable()
        {
            Console.WriteLine("\tRoulette Board");
            Console.Write("     ");
            PrintHorizontalLines(20);
            Console.WriteLine($"     |{numbers[0]} {colors[0]} | {"00"} {colors[_end]}|");
            PrintHorizontalLines(32);
            for (int i = 0; i < 36; i += 3)
            {
                Console.WriteLine(String.Format("|{0,-2} {1,-5} | {2,-2} {3,-5} | {4,-2} {5,-5}|", numbers[i+1], colors[i+1], numbers[i + 2], colors[i + 2], numbers[i + 3], colors[i + 3]));
                PrintHorizontalLines(32);
            }

        }


        private void PrintHorizontalLines(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public (int number, string color) SpinWheel() //return a Tuple
        {
            winner = _random.Next(0, 37);

            int _0 = 0;
            string win_color = colors[winner];

            if (winner == 0)
            {
                return (_0, win_color);
            }
            return (winner, win_color);
        }


    }
}
