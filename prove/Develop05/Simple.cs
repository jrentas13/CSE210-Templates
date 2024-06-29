public class Simple: Game
{
    private bool _achieved = false;

public Simple()
{

}

public Simple(string goal, string description, int points, bool achieved)
{
    _goal= goal;
    _description  = description;
    _points = points;
    _achieved = achieved;
}

    public override void Display()
    {
        Console.WriteLine($"{_checkbox} {_goal} ({_description})");
    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is your goal? ");
        _goal = Console.ReadLine();

        Console.WriteLine("Give a brief description: ");
        _description = Console.ReadLine();

        Console.WriteLine("How many points should be awarded? ");
        _points = int.Parse(Console.ReadLine());
    }

    public override void GoalComplete()
    {
        _checkbox = "[X]";

        _achieved = true;
    }

    public override int AddScore(int score)
    {
        _totalScore = score;
        _totalScore += _points;
        return _totalScore;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goal}~{_description}~{_points}~{_achieved}";
    }
}