
// static bool IsCoolCat(string name)
// {
//     switch (name.ToLower())
//     {
//         case "winter":
//             return true;
//         default:
//             return false;
//     }
// }

// while (true)
// {
//     Console.WriteLine("Enter a cat name: ");
//     string name = Console.ReadLine()!;
//     if (IsCoolCat(name))
//     {
//         Console.WriteLine($"{name} is a cool cat!");
//     }
//     else
//     {
//         Console.WriteLine($"I don't know {name}");
//     }
// }

while (true)
{
    Console.WriteLine("game code...");

    Console.WriteLine("DO you want to play again (Ok)?");
    string prompt = Console.ReadLine()!.ToLower();
    if (prompt != "ok")
    {
        break;
    }
}

Console.Write("Thanks for playing!");
