public class Circle
{
    public int Radius;
    public string Color;

    private const double Pi = 3.14;

    public double GetArea()
    {
        return Pi * Radius * Radius;

    }

    public double GetCircumfrence()
    {
        return  2 * Pi * Radius;
    }
}