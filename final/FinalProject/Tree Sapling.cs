public class Tree : Plant
{
    private string _fruitTree;
    private string _treeStatus;
    private string _fruit;

    public Tree()
    {

    }

    public Tree(string name, string species, string fruitTree, string fruit, string treeStatus, string wateringFrequency, int wateringNeeded,int timesWatered, string careInstructions)
    {
        _name = name;
        _species = species;
        _fruitTree = fruitTree;
        _fruit = fruit;
        _treeStatus = treeStatus;
        _wateringFrequency = wateringFrequency;
        _wateringNeeded = wateringNeeded;
        _timesWatered = timesWatered;
        _careInstructions = careInstructions;

    }

    public void UpdateTreeStatus()
    {
        Console.WriteLine("What is the current status of the tree:");
        Console.WriteLine(" 1. Newly Planted");
        Console.WriteLine(" 2. Established");
        Console.WriteLine(" 3. Native");
        int treeChoice = int.Parse(Console.ReadLine());

        switch(treeChoice)
        {
            case 1:
                _treeStatus = "NewlyPlanted";
                break;
            case 2:
                _treeStatus = "Established";
                break;
            case 3:
                _treeStatus = "Native";
                break;   
        }
    }
    public override void PlantInfo()
    {
        Console.Write("Type of tree: ");
        _name = Console.ReadLine();
        Console.Write("\nTree species: ");
        _species = Console.ReadLine();
        Console.Write("\nIs it a fruit tree? ");
        _fruitTree = Console.ReadLine();
        Console.Write("\nWhat kind of fruit (None if no fruit): ");
        _fruit = Console.ReadLine();

        UpdateTreeStatus();

        Console.WriteLine("How often should the plant be watered?");
        Console.WriteLine(" -Daily");
        Console.WriteLine(" -Weekly");
        Console.WriteLine(" -Monthly");
        _wateringFrequency = Console.ReadLine();

        Console.Write("How many times should it be watered: ");
        _wateringNeeded = int.Parse(Console.ReadLine());
    }

    public override void PlantCareInstructions()
    {
        Console.WriteLine("Brief tree care instruction:");
        _careInstructions = Console.ReadLine();
    }
    public override void PlantWatered()
    {
        _timesWatered ++;
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_species}) \n{_fruitTree} - {_fruit} \n{_wateringFrequency} watering, {_timesWatered}/{_wateringNeeded}");
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}~{_species}~{_fruitTree}~{_fruit}~{_treeStatus}~{_wateringFrequency}~{_wateringNeeded}~{_timesWatered}~{_careInstructions}";
    }

    public string GetCareInstructions()
    {
        return _careInstructions;  
    }
}