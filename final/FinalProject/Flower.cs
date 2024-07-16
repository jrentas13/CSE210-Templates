public class Flower : Plant
{
    private string _color;

    public Flower()
    {

    }

    public Flower(string name, string species, string color, string wateringFrequency, int wateringNeeded, int timesWatered, string careInstructions)
    {
        _name = name;
        _species = species;
        _color = color;
        _wateringFrequency = wateringFrequency;
        _wateringNeeded = wateringNeeded;
        _timesWatered = timesWatered;
        _careInstructions = careInstructions;
    }

    public override void PlantInfo()
    {
        Console.Write("Type of flower: ");
        _name = Console.ReadLine();
        Console.Write("\nFlower species: ");
        _species =Console.ReadLine();
        Console.Write("\nColor is the flower: ");
        _color = Console.ReadLine();

        Console.WriteLine("How often should the plant be watered?");
        Console.WriteLine(" -Daily");
        Console.WriteLine(" -Weekly");
        Console.WriteLine(" -Monthly");
        Console.Write(">");
        _wateringFrequency = Console.ReadLine();

        Console.Write("How many times should it be watered: ");
        _wateringNeeded = int.Parse(Console.ReadLine());
    }

    public override void PlantCareInstructions()
    {
        Console.WriteLine("Brief flower care instruction:");
        _careInstructions = Console.ReadLine();
    }

    public override void PlantWatered()
    {
        _timesWatered ++;
    }

    public override void Display()
    {
        Console.WriteLine($"{_name} ({_species}): {_color} \n- {_wateringFrequency} watering, {_timesWatered}/{_wateringNeeded}\n-{_careInstructions}-");
    }

    public override string GetStringRepresentation()
    {
        return $"{_name}~{_species}~{_color}~{_wateringFrequency}~{_wateringNeeded}~{_timesWatered}~{_careInstructions}";
    }
}