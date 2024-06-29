public class Eternal: Game
{
    private int count = 0;

public Eternal()
{

}

public Eternal(string goal, string description, int points)
{
    _goal= goal;
    _description= description;
    _points = points;
}


    public override void CreateGoal()
    {
        Console.Write("What is your goal? ");
        _goal = Console.ReadLine();
        
        Console.WriteLine("Give a brief description: ");
        _description = Console.ReadLine();

        Console.WriteLine("How many points should be awarded? ");
        _points = int.Parse(Console.ReadLine());
    }

    public override void Display()
    {
        Console.WriteLine($"{_checkbox} {_goal} ({_description})");
    }

    public override void GoalComplete()
    {
        count ++;
    }

    public override int AddScore(int score)
    {
        _totalScore = score;
        _totalScore += _points;
        return _totalScore;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goal}~{_description}~{_points}";
    }
}