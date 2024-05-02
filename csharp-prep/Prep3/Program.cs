using System;

class Program
{
    static void Main(string[] args)
    {
        // // Create an instance of the Random class and generate a random number between 1 and 100.
        // Random randomGenerator = new Random();
        // int randomNumber = randomGenerator.Next(1, 100);

        // Initialize variable for the do while loop
        string response = "yes";
        // int guess = 0;
        // List<int> guesses = new();

        // Create a do while loop that loops over the guessing game once, and then continues
        // to loop over if the user wants to continue playing.
        do
        {
            // Create an instance of the Random class and generate a random number between 1 and 100.
            Random randomGenerator = new Random();
            int randomNumber = randomGenerator.Next(1, 100);

            // Initialize variables and the for guessing game while loop.
            int guess = 0;
            int count = 0;

            // Create a while loop that will continue to ask the user for a number until
            // they guess the correct answer.
            while (guess != randomNumber)
            {
                // Ask the user to guess the number
                Console.WriteLine("Guess a number between 1 and 100.");
                guess = int.Parse(Console.ReadLine());

                // If the user guesses too high, tell them the number is lower than the one
                // they guessed and add it to the list of numbers they have guessed.
                if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                    count ++;
                }
                // If the user guesses too low, tell them the number is higher than the one
                // they guessed and add it to the list of numbers they have guessed.
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                    count ++;
                }
                else
                {
                // Display to the user that they guessed the correct number and the numbers they
                // guessed.
                Console.WriteLine("\nYou guessed it!");
                count ++;
                Console.WriteLine($"You made {count} guesses.");
                }
            }


            // Ask the user if they want to play again.
            Console.Write("\nWould you like to keep playing? ");
            response = Console.ReadLine();
        } while (response == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}