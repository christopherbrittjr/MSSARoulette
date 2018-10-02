using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roulette
{
    class Program
    {  
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Wheel roulette = new Wheel();
            int[] WheelArray = new int[38];
            for (int i = -1; i <= 36; i++)
            {
                WheelArray[i + 1] = i;
            }
            WelcomeMessage();
            roulette.Winners(roulette.SpinWheel(WheelArray));
        }
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome, Welcome, Welcome!");
            Console.WriteLine("Place your bets!");
            Console.WriteLine("Press the enter key to spin the wheel");
            Console.ReadLine();
        }
    }
    class Wheel
    {
        public int SpinWheel(int[] spin)
        {
            Random rng = new Random();
            int result = rng.Next(0, 36);
            Console.WriteLine($"\nThe wheel landed on {result}!");
            return result;
        }
        public void Winners(int ball)
        {
            if (ball == -1 || ball == 0)
            {
                if (ball == 0)
                {
                    Console.WriteLine("If you placed a bet on {0}.", ball);
                    Console.WriteLine("You would have won 35 to 1 on the payout");
                }
            }
            else
            {
                Console.WriteLine("If you placed a bet on {0}.", ball);
                if (ball % 2 == 0)
                {
                    Console.WriteLine("Evens would be 1 to 1 payout.");
                }
                else
                {
                    Console.WriteLine("Odds would be 1 to 1 payout");
                }
                if (new int[] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 }.Contains(ball))
                {
                    Console.WriteLine("Blacks would be a 1 to 1 payout");
                }
                else
                {
                    Console.WriteLine("Reds would be a 1 to 1 payout");
                }
                if (ball <= 18 && ball > 0)
                {
                    Console.WriteLine("Lows are a 2 to 1 payout");
                }
                else
                {
                    Console.WriteLine("Highs are a 2 to 1 payout");
                }
                if (ball <= 12 && ball > 0)
                {
                    Console.WriteLine("1st Dozen is a 2 to 1 payout");
                }
                else if (ball <= 24 && ball >= 13)
                {
                    Console.WriteLine("2nd Dozen is a 2 to 1 payout");
                }
                else
                {
                    Console.WriteLine("3rd Dozen is a 2 to 1 payout");
                }
                if (new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 }.Contains(ball))
                {
                    Console.WriteLine("1st Column is a 2 to 1 payout");
                }
                else if (new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 }.Contains(ball))
                {
                    Console.WriteLine("2nd Column is a 2 to 1 payout");
                }
                else
                {
                    Console.WriteLine("3rd Column is a 2 to 1 payout");
                }
                if (new int[] { 1, 2, 3 }.Contains(ball))
                {
                    Console.WriteLine("1 through 3 street is a 11 to 1 payout");
                }
                else if (new int[] { 4, 5, 6 }.Contains(ball))
                {
                    Console.WriteLine("4 through 6 street is a 11 to 1 payout");
                }
                else if (new int[] { 7, 8, 9 }.Contains(ball))
                {
                    Console.WriteLine("7 through 9 street is a 11 to 1 payout");
                }
                else if (new int[] { 10, 11, 12 }.Contains(ball))
                {
                    Console.WriteLine("10 through 12 street is a 11 to 1 payout");
                }
                else if (new int[] { 13, 14, 15 }.Contains(ball))
                {
                    Console.WriteLine("13 through 15 street is a 11 to 1 payout");
                }
                else if (new int[] { 16, 17, 18 }.Contains(ball))
                {
                    Console.WriteLine("16 through 18 street is a 11 to 1 payout");
                }
                else if (new int[] { 19, 20, 21 }.Contains(ball))
                {
                    Console.WriteLine("19 through 21 street is a 11 to 1 payout");
                }
                else if (new int[] { 22, 23, 24 }.Contains(ball))
                {
                    Console.WriteLine("22 through 24 street is a 11 to 1 payout");
                }
                else if (new int[] { 25, 26, 27 }.Contains(ball))
                {
                    Console.WriteLine("25 through 27 street is a 11 to 1 payout");
                }
                else if (new int[] { 28, 29, 30 }.Contains(ball))
                {
                    Console.WriteLine("28 through 30 street is a 11 to 1 payout");
                }
                else if (new int[] { 31, 32, 33 }.Contains(ball))
                {
                    Console.WriteLine("31 through 33 street is a 11 to 1 payout");
                }
                else
                {
                    Console.WriteLine("34 through 36 street is a 11 to 1 payout");
                }
                if (new int[] { 1, 2, 3, 4, 5, 6 }.Contains(ball))
                {
                    Console.WriteLine("1 through 6 rows is a 5 to 1 payout");
                }
                else if (new int[] { 4, 5, 6, 7, 8, 9 }.Contains(ball))
                {
                    Console.WriteLine("4 through 9 rows is a 5 to 1 payout");
                }
                else if (new int[] { 7, 8, 9, 10, 11, 12 }.Contains(ball))
                {
                    Console.WriteLine("7 through 12 rows is a 5 to 1 payout");
                }
                else if (new int[] { 10, 11, 12, 13, 14, 15 }.Contains(ball))
                {
                    Console.WriteLine("10 through 15 rows is a 5 to 1 payout");
                }
                else if (new int[] { 13, 14, 15, 16, 17, 18 }.Contains(ball))
                {
                    Console.WriteLine("13 through 18 rows is a 5 to 1 payout");
                }
                else if (new int[] { 16, 17, 18, 19, 20, 21 }.Contains(ball))
                {
                    Console.WriteLine("16 through 21 rows is a 5 to 1 payout");
                }
                else if (new int[] { 19, 20, 21, 22, 23, 24 }.Contains(ball))
                {
                    Console.WriteLine("19 through 24 rows is a 5 to 1 payout");
                }
                else if (new int[] { 22, 23, 24, 25, 26, 27 }.Contains(ball))
                {
                    Console.WriteLine("22 through 27 rows is a 5 to 1 payout");
                }
                else if (new int[] { 25, 26, 27, 28, 29, 30 }.Contains(ball))
                {
                    Console.WriteLine("25 through 30 rows is a 5 to 1 payout");
                }
                else if (new int[] { 28, 29, 30, 31, 32, 33 }.Contains(ball))
                {
                    Console.WriteLine("28 through 33 rows is a 5 to 1 payout");
                }
                else
                {
                    Console.WriteLine("31 through 36 rows is a 5 to 1 payout");
                }
                if (ball == 1 && ball == 2)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 2 && ball == 3)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 4 && ball == 5)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 5 && ball == 6)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 7 && ball == 8)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 8 && ball == 9)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 10 && ball == 11)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 11 && ball == 12)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 13 && ball == 14)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 14 && ball == 15)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 16 && ball == 17)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 17 && ball == 18)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 19 && ball == 20)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 20 && ball == 21)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 22 && ball == 23)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 23 && ball == 24)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 25 && ball == 26)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 26 && ball == 27)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 28 && ball == 29)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 29 && ball == 30)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 31 && ball == 32)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 32 && ball == 33)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 34 && ball == 35)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 35 && ball == 36)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 1 && ball == 4)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 4 && ball == 7)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 7 && ball == 10)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 10 && ball == 13)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 13 && ball == 16)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 16 && ball == 19)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 19 && ball == 22)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 22 && ball == 25)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 25 && ball == 28)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 28 && ball == 31)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 31 && ball == 34)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 2 && ball == 5)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 5 && ball == 8)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 8 && ball == 11)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 11 && ball == 14)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 14 && ball == 17)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 17 && ball == 20)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 20 && ball == 23)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 23 && ball == 26)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 26 && ball == 29)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 29 && ball == 32)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 32 && ball == 35)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 3 && ball == 6)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 6 && ball == 9)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 9 && ball == 12)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 12 && ball == 15)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 15 && ball == 18)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 18 && ball == 21)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 21 && ball == 24)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 24 && ball == 27)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 27 && ball == 30)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else if (ball == 30 && ball == 33)
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                else
                {
                    Console.WriteLine("This split is a 17 to 1 payout");
                }
                if (new int[] { 1, 2, 4, 5 }.Contains(ball))
                {
                    Console.WriteLine("1 2 4 5 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 4, 5, 7, 8 }.Contains(ball))
                {
                    Console.WriteLine("4, 5, 7, 8 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 7, 8, 10, 11 }.Contains(ball))
                {
                    Console.WriteLine("7, 8, 10, 11 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 10, 11, 13, 14 }.Contains(ball))
                {
                    Console.WriteLine("10, 11, 13, 14 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 13, 14, 16, 17 }.Contains(ball))
                {
                    Console.WriteLine("13, 14, 16, 17 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 16, 17, 19, 20 }.Contains(ball))
                {
                    Console.WriteLine("16, 17, 19, 20 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 19, 20, 22, 23 }.Contains(ball))
                {
                    Console.WriteLine("19, 20, 22, 23 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 22, 23, 25, 26 }.Contains(ball))
                {
                    Console.WriteLine("22, 23, 25, 26 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 25, 26, 28, 29 }.Contains(ball))
                {
                    Console.WriteLine("25, 26, 28, 29 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 28, 29, 31, 32 }.Contains(ball))
                {
                    Console.WriteLine("28, 29, 31, 32 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 31, 32, 34, 35 }.Contains(ball))
                {
                    Console.WriteLine("31, 32, 34, 35 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 2, 3, 5, 6 }.Contains(ball))
                {
                    Console.WriteLine(" 2, 3, 5, 6 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 5, 6, 8, 9 }.Contains(ball))
                {
                    Console.WriteLine("5, 6, 8, 9 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 8, 9, 11, 12 }.Contains(ball))
                {
                    Console.WriteLine("8, 9, 11, 12 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 11, 12, 14, 15 }.Contains(ball))
                {
                    Console.WriteLine("11, 12, 14, 15 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 14, 15, 17, 18 }.Contains(ball))
                {
                    Console.WriteLine("14, 15, 17, 18 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 17, 18, 20, 21 }.Contains(ball))
                {
                    Console.WriteLine("17, 18, 20, 21 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 20, 21, 23, 24 }.Contains(ball))
                {
                    Console.WriteLine("20, 21, 23, 24 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 23, 24, 26, 27 }.Contains(ball))
                {
                    Console.WriteLine("23, 24, 26, 27 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 26, 27, 29, 30 }.Contains(ball))
                {
                    Console.WriteLine("26, 27, 29, 30 Corners is a 8 to 1 payout");
                }
                else if (new int[] { 29, 30, 32, 33 }.Contains(ball))
                {
                    Console.WriteLine("29, 30, 32, 33 Corners is a 8 to 1 payout");
                }
                else
                {
                    Console.WriteLine("32 33 35 36 Corners is a 8 to 1 payout");
                }

            }
            Console.ReadLine();
        }
    }
}
