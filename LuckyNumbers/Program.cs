using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs

            string playAgain;
            do
            {
                int jackpotAmount = 10000000;
                Console.WriteLine("Welcome to the Lucky Number game! Where you have a chance to win $" + jackpotAmount + "!");
                Console.WriteLine("Please enter a low number to create a minimum range value:");
                int lowestNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a high number to create a maximum range value:");
                int highestNumber = int.Parse(Console.ReadLine());

                //User input array

                int[] userNumbers = new int[6];
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Please enter 6 unique numbers between " + lowestNumber + " and " + highestNumber + ", each followed by pressing ENTER");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                    while (userNumbers[i] < lowestNumber)
                    {
                        Console.WriteLine("Outside of range! Please enter a new number between " + lowestNumber + " and " + highestNumber + ".");
                        userNumbers[i] = int.Parse(Console.ReadLine());
                    }
                    while (userNumbers[i] > highestNumber)
                    {
                        Console.WriteLine("Outside of range! Please enter a new number between " + lowestNumber + " and " + highestNumber + ".");
                        userNumbers[i] = int.Parse(Console.ReadLine());
                    }

                }

                //Random number generator into array

                Random randNum = new Random();
                int[] jackpotNumbers = new int[6];
                for (int j = 0; j <= 5; j++)
                {
                    jackpotNumbers[j] = randNum.Next(lowestNumber, highestNumber);
                    Console.WriteLine("Lucky Number: " + jackpotNumbers[j]);

                }

                //Array matching

                double correctAnswers = 0;
                foreach (int i in userNumbers)
                {
                    if (jackpotNumbers.Contains(i))
                    {
                        correctAnswers += 1;
                    }
                }
                Console.WriteLine("You guessed " + correctAnswers + " numbers correctly!");

                //End results

                double userWinnings = ((correctAnswers / 6) * jackpotAmount);

                
                Console.WriteLine("You won $" + userWinnings.ToString("#.##") + "!");
                Console.WriteLine("Would you like to play again? (YES/NO)");
                playAgain = Console.ReadLine().ToUpper();
            }
            while (playAgain == "YES");
            Console.WriteLine("Thanks for playing!");
        }
    }
}
