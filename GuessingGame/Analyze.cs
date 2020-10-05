using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GuessingGame
{
    public  class Analyze
    {
        
        public  int GetInput()
        {
            int number;
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter positive integer from 1 to 100:");
            }

            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 100);

            return number;   
        }

        public  bool CompareNumbers(int number, int random)
        {
            if (number > random)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Too high...Guess lower");
                return false;
            }

            if (number < random)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Too low. Guess higher");

                return false;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("You win!");
            return true;
        }
    }
}
