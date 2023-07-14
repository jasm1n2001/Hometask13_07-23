public class Shape
{
    public string Name;
    public string Color;
    public int PsitionX;
    public int PsitionY;


    public void GetPosition()
    {
        System.Console.WriteLine($"{PositionX} {PositionY}");

    }

    public void GetFullInfo()
    {
        System.Console.WriteLine($"{Color} {Name} {PositionX} {PositionY}");
    }
}