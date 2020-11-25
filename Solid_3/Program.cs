using System;

interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public virtual int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        square.Side = 5;

        Console.WriteLine(square.GetArea());
        Console.ReadKey();
    }
}