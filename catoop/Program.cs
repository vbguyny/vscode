// .w.
Cat firstCat = new Cat();
firstCat.Name = "Thor";
firstCat.Age = 5;
firstCat.Sleep();

Cat secondCat = new Cat();
secondCat.Name = "Winter";
secondCat.Age = 6;
secondCat.Sleep();

Cat cat1 = new Cat();
Console.WriteLine("What is the name of the cat? ");
cat1.Name = Console.ReadLine()!;
Console.WriteLine($"How old is {cat1.Name}?");
cat1.Age = Convert.ToInt32(Console.ReadLine());
cat1.Sleep();

class Cat
{
    public string Name = string.Empty;
    public int Age;

    public void Sleep()
    {
        Console.WriteLine($"Shh! {Name} is sleeping. It is {Age} years old!");
    }
}


