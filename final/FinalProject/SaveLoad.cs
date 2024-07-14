using System.IO;

public class SaveLoad
{
    private string _filename;

    public void Save(List<Plant> plantList, List<Reminder> reminderList, string user)
    {
        Console.WriteLine("What file would you like to save to (example.txt):");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(user);

            foreach (Plant plant in plantList)
            {
                outputFile.WriteLine($"{plant.GetType()}~{plant.GetStringRepresentation()}");
            }

            foreach (Reminder reminder in reminderList)
            {
                outputFile.WriteLine($"{reminder.GetType()}~{reminder.GetStringRepresentation()}");
            }
        }
    }

    public void Load(List<Plant> plantList, List<Reminder> reminderList)
    {
        Console.WriteLine("What File would you like to load (example.txt):");
        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
        }

        plantList.Clear();
        reminderList.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('~');

            string type = parts[0];
            if (type == "Tree")
            {
                plantList.Add(new Tree(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], int.Parse(parts[7]), int.Parse(parts[8]), parts[9]));
            }
            if (type == "Bush")
            {
                plantList.Add(new Bush(parts[1], parts[2], parts[3], parts[4], parts[5], int.Parse(parts[6]), int.Parse(parts[7]), parts[8]));
            }
            if (type == "Flower")
            {
                plantList.Add(new Flower(parts[1], parts[2], parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), parts[7]));
            }
            if (type == "Reminder")
            {
                reminderList.Add(new Reminder());
            }
        }
    }
}