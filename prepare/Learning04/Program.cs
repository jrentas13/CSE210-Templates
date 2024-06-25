using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Samuel Bennet", "Multiplication", "7.3", "8-19");
        WritingAssignment history = new WritingAssignment("Mary Waters", "European History", "The Cause of World War II");

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomewrokList());
        Console.WriteLine(history.GetSummary());
        Console.WriteLine(history.GetWritingInformation());
    }
}