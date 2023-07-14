Rectangle rt1 = new Rectangle()

{
    Whidth = Convert.ToInt32(Console.ReadLine()),
     Height = Convert.ToInt32(Console.ReadLine()),
};

System.Console.WriteLine($"Getarea: ",rt1.GetArea());
System.Console.WriteLine(rt1.GetParimetr());


Shape sh1 = new Shape()
{
    System.Console.WriteLine($"Shape: "),
    System.Console.WriteLine($"Name: "),
    sh1.Name = Console.ReadLine(),
    System.Console.Write($"Color: "),
    sh1.Color = Console.ReadLine(),
    System.Console.Write($"PositionX: "),
    sh1.PsitionX = Console.ReadLine(),
    System.Console.Write($"PositionY: "),
    sh1.PsitionY = Console.ReadLine(),   
};

System.Console.WriteLine(sh1.GetPosition());
System.Console.WriteLine(sh1.GetFullInfo());

Circle c1 = new Circle()
{
    System.Console.WriteLine($"Circle: "),
    System.Console.Write($"Radius: "),
    c1.Radius = Console.ReadLine(),
    System.Console.Write($"Color: "),
    c1.Color = Console.ReadLine(),
    System.Console.Write($"Pi: "),
    c1.Pi = Console.ReadLine(),

};

System.Console.WriteLine(c1.GetArea);
System.Console.WriteLine(c1.GetCircumfrence);