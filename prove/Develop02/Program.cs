using System;
using System.IO;

class Program
{
    public static void SavetoFile(List<Entry> _entries)
    {
        string filename;

        Console.Write("Enter the name of the file you want to save: ");
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
               outputFile.WriteLine($"{e._date}\n{e._reflection}\n{e._entry}");
            }
        }
    }


    public static List<Entry> LoadFile()
    {
        List<Entry> entries1 = new List<Entry>();
        string filename;

        Console.Write("What file would you like to load: ");
        filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        return entries1;
    }
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        int userInput;

        Console.WriteLine("Finally decided to write a journal?\n");
        do
        {
            Console.WriteLine("Available Options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("\nChoose an option: ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("==========================");
                    myJournal.WriteEntry();
                    Console.WriteLine("\n");
                    break;
                case 2:
                    Console.WriteLine("==========================");
                    myJournal.DisplayEntries();
                    Console.WriteLine("\n");
                    break;
                case 3:
                    SavetoFile(myJournal._entries);
                    break;
                case 4:
                    myJournal._entries = LoadFile();
                    break;
                case 5:
                    Console.WriteLine("Hope you actually commit this time.");
                    return;
                default:
                    Console.WriteLine("Invalid option, choose from the ones given.");
                    break;
            }


        }while (userInput != 5);
    }
}