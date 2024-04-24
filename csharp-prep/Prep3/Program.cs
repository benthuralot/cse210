using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int counter = 0;
            int guess = 0;
            string response = "";

            Console.WriteLine("Welcome to the Number guessing Game.");
            Console.WriteLine("Try guess the magic number from 1 to 100.");
            Console.WriteLine();
            do
            {
                
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                counter++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    
                }
                else
                {
                    Console.WriteLine("Congratulations you guessed the magic number!");
                    Console.WriteLine($"You got it in {counter} guesses.");
                    Console.WriteLine();
                }

            } while (!(guess == magicNumber));
            
            do
            {
                Console.WriteLine("Would you like to play again? ");
                Console.WriteLine("Type 'yes' or 'no'.");
                response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    
                }
                else if (response == "no")
                {
                    Console.WriteLine("Thank you for playing! Goodbye.");
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid response.");
                   
                }
            } while(!(response == "yes" || response == "no"));
            Console.WriteLine();
        } while (playAgain);
    }
}