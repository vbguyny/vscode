using System.IO;

var filename = "username.txt";
var username = "";
if (File.Exists(filename))
{
    username = File.ReadAllText(filename);
    DisplayUser(username);
}
else
{
    username = PromptUser();
    File.WriteAllText(filename, username);
}

string PromptUser()
{
    Console.Write("What is your user name? ");
    return Console.ReadLine()!;
}

void DisplayUser(string username)
{
    Console.WriteLine($"Welcome back, {username}");
}