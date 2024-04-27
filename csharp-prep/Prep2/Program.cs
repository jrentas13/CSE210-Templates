using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int gradePercentage = int.Parse(valueFromUser);
        string letter;
        string sign;

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if ((gradePercentage % 10) >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
            else
            {
            sign = "+";
            }
        } 
        else if ((gradePercentage % 10) < 3)
        {
            if (letter == "F")
            {
                sign = "";
            }
            else
            {
            sign = "-";
            }
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Try again, you got this!");
        }
    }
}