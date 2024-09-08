using System;

struct Point
{
    public int X;
    public int Y;
    public int Z;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point({X}, {Y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point point = new Point(2,3);
        point.Display();
    }
}
