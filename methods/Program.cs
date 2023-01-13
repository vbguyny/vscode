internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What's your name? ");
        string name = Console.ReadLine();

        bool isCat = IsCat(name);
        if (isCat)
        {
            Console.WriteLine("You are a cat!");
        }
        else
        {
            Console.WriteLine("You are something else...");
        }
    }

    static bool IsCat(string name = "Huh?")
    {
        bool isCat = false;

        switch (name.ToLower())
        {
            case "thor":
            case "winter":
            case "loki":
            case "luna":
            case "binx":
                isCat = true;
                break;
        }

        return isCat;
    }
}