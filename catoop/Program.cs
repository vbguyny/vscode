Cat binx = new Cat("Binx", 2);
binx.Gender = "boy";
Console.WriteLine($"{binx.Name} is a {binx.Age} year old {binx.Gender} cat.");

Cat firstCat = new Cat("Thor", 5);
firstCat.Sleep();

Cat secondCat = new Cat("Winter", 6);
secondCat.Sleep();

Console.WriteLine($"What is the name of the cat? ");
string name = Console.ReadLine()!;
Console.WriteLine($"How old is {name}?");
int age = Convert.ToInt32(Console.ReadLine());
Cat cat1 = new Cat(name, age);
cat1.Sleep();

class Cat
{
    public string Name = string.Empty;
    public int Age;

    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Sleep()
    {
        Console.WriteLine($"Shh! {Name} is sleeping. It is {Age} years old!");
    }

    private string gender;
    public string Gender 
    {
        get
        {
            return gender;
        }
        set
        {
            gender = value;
        }
    }
}


