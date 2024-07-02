using System.IO;

public class LoadSave
{

    private string _filename;
    public void SaveGoals(List<Game> goalList, int score)
    {
        Console.WriteLine("What file would you like to save to (example.txt): ");
        _filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            outputFile.WriteLine(score);

            foreach (Game goal in goalList)
            {
                outputFile.WriteLine($"{goal.GetType()}~{goal.GetStringRepresentation()}");
            }
        }
    }

    public int LoadGoals(List<Game> goalList)
    {
        Console.WriteLine("What file would you like to load (example.txt): ");
        _filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(_filename);
        
        if (lines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
        }

        goalList.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('~');

            string type = parts[0];
            if (type == "Simple")
            {
                goalList.Add(new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type == "Eternal")
            {
                goalList.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "Checklist")
            {
                goalList.Add(new Checklist(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
        int score = int.Parse(lines[0]);
        return score;
    }
}