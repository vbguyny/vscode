
try
{
    int a = 0;
    int b = a / a;
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


int age = -1;
while (age == -1)
{
    try
    {
        age = AskForAge();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Invalid input: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("Moving on...");
    }
}

try
{
    if (age > 10)
    {
        throw new Exception($"I'm sorry, {age} is too old!");
    }
    Console.WriteLine($"You are {age} years old!");
}
catch
{
    Console.WriteLine("An error occurred!");
}

static int AskForAge()
{
    Console.Write("Please enter your age: ");
    return Convert.ToInt32(Console.ReadLine());
}

