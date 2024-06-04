using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scrip = new Scripture();
        string userInput;

        scrip.DisplayScripture();
        do 
        {
            if (scrip.AllWordsHidden())
            {
                break;
            }

            Console.WriteLine("Please hit enter to continue. Type 'quit' to stop the program.");
            userInput= Console.ReadLine();

            if (userInput != "quit")
            {
                Console.Clear();

                scrip.HideWords();
                scrip.DisplayScripture();
            }

        } while (userInput != "quit");
    }
}