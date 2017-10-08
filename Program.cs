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

            Console.WriteLine("Welcome to the Lucky Number game!");
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
                    Console.WriteLine("Please enter a new number between " + lowestNumber + " and " + highestNumber + ".");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                }
                while (userNumbers[i] > highestNumber)
                {
                    Console.WriteLine("Please enter a new number between " + lowestNumber + " and " + highestNumber + ".");
                    userNumbers[i] = int.Parse(Console.ReadLine());
                }
            }
            Array.Sort(userNumbers);

            //Random array generator

            Random randNum = new Random();
            int[] jackpotNumbers = new int[6];
            for (int j = 0; j <=5 ; j++)
            {
                jackpotNumbers[j] = randNum.Next(lowestNumber, highestNumber);
                Console.WriteLine("Lucky Number: " + jackpotNumbers[j]);
                
            }
            Array.Sort(jackpotNumbers);

            //Array matching

            int correctAnswers = 0;
            foreach (int i in userNumbers)
            {
                if (jackpotNumbers.Contains(i))
                {
                    correctAnswers += 1;
                }
            }


            Console.WriteLine("You guessed " + correctAnswers + " numbers correctly!");








        }
    }
}
