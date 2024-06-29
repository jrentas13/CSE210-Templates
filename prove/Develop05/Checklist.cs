public class Checklist : Game
{
    private int _totalCompletions;
    private int _bonusPoints;
    private int _completions = 0;
    private bool _achieved;

    public Checklist()
    {

    }

    public Checklist(string goal, string description, int points, int bonusPoints, int totalCompletions, int completions)
    {
        _goal = goal;
        _description= description;
        _points = points;
        _bonusPoints = bonusPoints;
        _totalCompletions = totalCompletions;
        _completions = completions;
    }
    
    public override void Display()
    {
        Console.WriteLine($"{_checkbox} {_goal} ({_description}) -- Completions: {_completions}/{_totalCompletions}");
    }

    public override void CreateGoal()
    {
        Console.Write("What is your goal? ");
        _goal = Console.ReadLine();
        
        Console.WriteLine("Give a brief description: ");
        _description = Console.ReadLine();

        Console.WriteLine("How many points should be awarded? ");
        _points = int.Parse(Console.ReadLine());

        Console.WriteLine("How many times do you want to complete the goal? ");
        _totalCompletions = int.Parse(Console.ReadLine());

        Console.WriteLine("Bonus points awarded upon reaching goal: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override void GoalComplete()
    {
        _completions ++;
        
        if (_completions == _totalCompletions)
        {
            _checkbox = "[X]";
            _achieved = true;
        }
    }

    public override int AddScore(int score)
    {
        _totalScore = score;
        _totalScore += _points;

        if (_completions == _totalCompletions)
        {
            _totalScore += _bonusPoints;
        }
        return _totalScore;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goal}~{_description}~{_points}~{_bonusPoints}~{_totalCompletions}~{_completions}~{_achieved}";
    }
}