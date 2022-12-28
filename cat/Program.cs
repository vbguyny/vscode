internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Who is your favorite cat?");
        var name = Console.ReadLine()!.ToLower();
        var response = "";
        
        switch (name)
        {
            case "thor":
                response = "But he is stinky!";
                break;
            default:
                response = $"I am not familiar with a cat named \"{name}\"";
                break;
        }

        Console.WriteLine(response);
    }
}