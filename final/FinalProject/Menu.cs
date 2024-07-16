using System.Data;
using System.Dynamic;
using System.Xml.Serialization;

public class Menu
{
    public void ProgramMenu()
    {
        User username = new User();
        string user;
        int userInput;
        List<Plant> plants = new List<Plant>();
        List<Reminder> reminders = new List<Reminder>();
        SaveLoad garden = new SaveLoad();

        Console.WriteLine("Welcome to the Plant Reminder app\n");

        user = username.CreateUser();

        do
        {
            Console.Clear();
            Console.WriteLine(" 1. Add Plant");
            Console.WriteLine(" 2. Display Plants");
            Console.WriteLine(" 3. Add Reminder");
            Console.WriteLine(" 4. Display Reminders");
            Console.WriteLine(" 5. Record Plant Watering");
            Console.WriteLine(" 6. Save");
            Console.WriteLine(" 7. Load");
            Console.WriteLine(" 8. Quit");
            Console.Write("\nWhat would ou like to do? ");
            userInput = int.Parse(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" 1. Tree");
                    Console.WriteLine(" 2. Bush");
                    Console.WriteLine(" 3. Flower");
                    Console.WriteLine("\nWhat kind of plant do you want to add: ");
                    int plantChoice = int.Parse(Console.ReadLine());

                    switch(plantChoice)
                    {
                        case 1:
                            Console.Clear();
                            Tree newTree = new Tree();
                            newTree.PlantInfo();
                            newTree.PlantCareInstructions();
                            plants.Add(newTree);
                            break;
                        case 2:
                            Console.Clear();
                            Bush newBush = new Bush();
                            newBush.PlantInfo();
                            newBush.PlantCareInstructions();
                            plants.Add(newBush);
                            break;
                        case 3:
                            Console.Clear();
                            Flower newFlower = new Flower();
                            newFlower.PlantInfo();
                            newFlower.PlantCareInstructions();
                            plants.Add(newFlower);
                            break;
                        default:
                            Console.WriteLine("\nInvalid choice\n");
                            break;
                    }
                    break;
                case 2:
                    int i = 1;
                    Console.WriteLine("\nPlants currently being cared for:");

                    foreach(Plant plant in plants)
                    {
                        Console.Write(i + ". ");
                        plant.Display();
                        Console.Write("\n");
                        i++;
                    }
                    Thread.Sleep(5000);
                    break;
                case 3:
                    Reminder newReminder = new Reminder();
                    newReminder.AddReminder();
                    reminders.Add(newReminder);
                    break;
                case 4:
                    int j = 1;
                    Console.WriteLine("Reminders Set-up:");
                    
                    foreach(Reminder reminder in reminders)
                    {
                        Console.Write(j + ". ");
                        reminder.DisplayReminder();
                        j++;
                    }
                    Thread.Sleep(5000);
                    break;
                case 5:
                    Console.Clear();
                    if (plants.Count() != 0)
                    {
                        i = 1;
                        Console.WriteLine("\nPlants currently being cared for:");

                        foreach(Plant plant in plants)
                        {
                            Console.Write(i + ". ");
                            plant.Display();
                            i++;
                        }

                        Console.WriteLine("\nWhat plant has been watered: ");
                        int watered = int.Parse(Console.ReadLine());

                        plants[watered - 1].PlantWatered();
                    }

                    else
                    {
                        Console.WriteLine("\nNo plants to be watered.\n");
                    }
                    break;
                case 6:
                    garden.Save(plants, reminders, user);
                    break;
                case 7:
                    garden.Load(plants, reminders);
                    break;
                case 8:
                    Console.WriteLine("\nHave a great day!\n");
                    break;
                default:
                    Console.WriteLine("\nPlease choose a valid option.\n");
                    break;
            }

        }while (userInput != 8);


    }
}