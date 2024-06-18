using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing activity1 = new Breathing();
        Reflecting activity2 = new Reflecting();
        Listing activity3 = new Listing();
        int choice;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    activity1.BreatheActivity();
                    break;
                case 2:
                    activity2.ReflectionActivity();
                    break;
                case 3:
                    activity3.ListingActivity();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }

        }while (choice != 4);
    }
}