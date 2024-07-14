public abstract class Plant
{
    protected string _name;
    protected string _species;
    protected string _wateringFrequency;
    protected string _careInstructions;
    protected int _wateringNeeded;
    protected int _timesWatered = 0;

    public abstract void PlantInfo();

    public abstract void PlantCareInstructions();

    public abstract void PlantWatered();

    public abstract void Display();

    public abstract string GetStringRepresentation();
}