using System.Drawing;
using System.Net.NetworkInformation;
public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = Color;
    }

    public string Color { get; set; }

    public abstract double GetArea();
}

public class Square : Shape
{
    public double Side { get; set; }

    public Square(string color, double side) : base(color)
    {
        Side = side;
    }

    public override double GetArea()
    {
        double area = Side * Side;
        return area;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }
    public override double GetArea()
    {
        double area = Length * Width;
        return area;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        double area = Math.PI;
        return area;
    }
}