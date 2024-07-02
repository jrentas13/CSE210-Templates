public abstract class Game
{
    protected int _totalScore = 0;

    protected int _points = 0;

    protected string _goal;

    protected string _description;

    protected string _checkbox = "[ ]";

    public abstract void Display();

    public abstract void CreateGoal();

    public abstract int AddScore(int score);

    public abstract void GoalComplete();

    public abstract string GetStringRepresentation();

}