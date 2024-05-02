using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize a list of integers as well as a variable to hold user input.
        List<int> numbers = new();
        int userInput = 0;

        // Inform the user to enter a numeber
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // A do while loop that ask the user to enter a number and adds it
        // to a list.
        do
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
            numbers.Add(userInput);
            }
        }while (userInput != 0);

        // Initialize varibale for operations
        int sum = 0;
        double average = 0;
        double max = 0;

        // A foreach loop that sums up the number in the list.
        foreach (int number in numbers)
        {
         sum += number;
        }

        // Find the average of the list
        average = numbers.Average();

        // Find the maximum value of the list.
        max = numbers.Max();

        // Display the results to the user.
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}