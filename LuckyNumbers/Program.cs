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
            Console.WriteLine("Please enter a low number to create a minimum range value:");
            int lowestNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a high number to create a maximum range value:");
            int highestNumber = int.Parse(Console.ReadLine());

            int[] userNumbers = new int[6];
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Please enter 6 numbers between " + lowestNumber + " and " + highestNumber + ", each followed by pressing ENTER");
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

            int[] jackpotNumbers = new int[5];

            Random randNum = new Random();
            for (int number = 0; number <=5 ; number++)
            {
                int randomNumber = randNum.Next(lowestNumber, highestNumber);
                Console.WriteLine("{0}", randNum);
            }












        }
    }
}
