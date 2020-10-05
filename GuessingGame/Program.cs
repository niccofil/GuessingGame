using System;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //attempt counter

            Random ran = new Random();

            int random = ran.Next(1, 100); //random number between 1 and 100

            Analyze input = new Analyze(); //store user input and compare with random number
            
            bool outcome; //store the outcome of numbers' comparison

            do
            {
                outcome = input.CompareNumbers(input.GetInput(),random); 
                i++;
            }

            while (outcome == false);

            while(outcome == true)
            {
                Console.WriteLine();
                Console.WriteLine($"It took you {i} attempts!");
                Console.WriteLine();
                Console.WriteLine("Would you like to play another game?(yes/no)");
                string answer = Console.ReadLine();

               if(answer == "yes")
               {
                    i = 0;
                    random = ran.Next(1, 100);

                    do
                    {
                        outcome = input.CompareNumbers(input.GetInput(), random);
                        i++;
                    }
                    while (outcome == false);
                }

               if(answer == "no")
                {
                    outcome = false;
                    Console.WriteLine();
                    Console.WriteLine("Ok, bye!");
                    Console.ReadKey();
                }
            }
        }
    }
}

