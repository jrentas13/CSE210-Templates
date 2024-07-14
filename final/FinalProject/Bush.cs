public class Bush: Plant
{
    private string _fruitBush;
    private string _fruit;

    public Bush()
    {

    }

    public Bush(string name, string species, string fruitBush, string fruit, string wateringFrequency, int wateringNeeded, int timesWatered, string careInstructions)
    {
        _name = name;
        _species = species;
        _fruitBush = fruitBush;
        _fruit = fruit;
        _wateringFrequency = wateringFrequency;
        _wateringNeeded = wateringNeeded;
        _timesWatered = timesWatered;
        _careInstructions = careInstructions;
    }

    public override void PlantInfo()
    {
        Console.Write("Type of bush: ");
        _name = Console.ReadLine();
        Console.Write("\nBush species: ");
        _species =Console.ReadLine();
        Console.Write("\nDoes it bear fruit? ");
        _fruitBush = Console.ReadLine();  
        Console.Write("\nWhat kind of fruit (None if no fruit): ");
        _fruitBush = Console.ReadLine();

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
        Console.WriteLine("Brief bush care instruction:");
        _careInstructions = Console.ReadLine();
    }

    public override void PlantWatered()
    {
        _timesWatered ++;   
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_species}) \n{_fruitBush} - {_fruit} \n{_wateringFrequency} watering, {_timesWatered}/{_wateringNeeded}");
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}~{_species}~{_fruitBush}~{_fruit}~{_wateringFrequency}~{_wateringNeeded}~{_timesWatered}~{_careInstructions}";
    }
}