

Alerts alert = Alerts.Thor;

switch (alert)
{
    case Alerts.Red:
        Console.WriteLine("WOMEN AND CHILDREN FIRST!!");
        break;
    case Alerts.Green:
        Console.WriteLine("EVERYTHING IS A-OK :)");
        break;
    default:
        break;
}

enum Alerts
{
    Green,
    Yellow,
    Thor
}

