namespace LoopsPolymorphismExceptions;

public abstract class Shape
{
    public abstract string Name { get; }
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("El radio debe ser mayor a cero.", nameof(radius));
        Radius = radius;
    }

    public override string Name => "Círculo";
    public override double CalculateArea() => Math.PI * Radius * Radius;
    public override double CalculatePerimeter() => 2 * Math.PI * Radius;
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Ancho y alto deben ser mayores a cero.");
        Width = width;
        Height = height;
    }

    public override string Name => "Rectángulo";
    public override double CalculateArea() => Width * Height;
    public override double CalculatePerimeter() => 2 * (Width + Height);
}

public class RightTriangle : Shape
{
    public double Base { get; }
    public double Height { get; }

    public RightTriangle(double @base, double height)
    {
        if (@base <= 0 || height <= 0)
            throw new ArgumentException("Base y altura deben ser mayores a cero.");
        Base = @base;
        Height = height;
    }

    public override string Name => "Triángulo Rectángulo";
    public override double CalculateArea() => (Base * Height) / 2.0;

    public override double CalculatePerimeter()
    {
        double hypotenuse = Math.Sqrt(Base * Base + Height * Height);
        return Base + Height + hypotenuse;
    }
}
