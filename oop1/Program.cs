Fruit Apple = new Fruit();
Fruit Banana = new Fruit();
Fruit Mango = new Fruit();

Apple.DaysOld = 9;
Banana.DaysOld = 1;
Mango.DaysOld = 200;

Apple.Color = "Red";
Apple.Eat();

internal class Fruit
{
    //string? Color = default(string);
    private string Color = "";

    public int DaysOld { get; set; }
    public void Eat()
    {
        Console.WriteLine($"Nom Nom, what a nice {Color} fruit!");
    }
}

file class Cat
{
    public Cat()
    {
    }
}

