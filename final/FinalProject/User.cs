public class User
{
    private string _userName;
    
    public string CreateUser()
    {
        Console.WriteLine("Enter your name:");
        _userName = Console.ReadLine();
        return _userName;
    }
}