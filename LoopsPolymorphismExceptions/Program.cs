namespace LoopsPolymorphismExceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Video 13: Bucles, Polimorfismo y Excepciones ===");

        // 1. Bucles: for, while, do-while
        Console.WriteLine("\n--- 1. Bucles ---");
        Console.Write("for (1..5): ");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        Console.Write("while (cuenta regresiva): ");
        int countdown = 5;
        while (countdown > 0)
        {
            Console.Write($"{countdown} ");
            countdown--;
        }
        Console.WriteLine();

        Console.Write("do-while (al menos una ejecución): ");
        int step = 0;
        do
        {
            step++;
            Console.Write($"paso-{step} ");
        } while (step < 3);
        Console.WriteLine();

        // 2. Polimorfismo + foreach
        Console.WriteLine("\n--- 2. Polimorfismo con figuras geométricas ---");
        List<Shape> shapes =
        [
            new Circle(5),
            new Rectangle(4, 6),
            new RightTriangle(3, 4)
        ];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(
                $"{shape.Name,-20} | Área: {shape.CalculateArea(),6:F2} | Perímetro: {shape.CalculatePerimeter(),6:F2}");
        }

        // 3. Manejo de excepciones (try / catch / finally)
        Console.WriteLine("\n--- 3. Manejo de Excepciones ---");
        TestDivision(10, 2);
        TestDivision(10, 0);
        TestParsing("abc");
        TestInvalidShape();
    }

    static void TestDivision(int numerator, int denominator)
    {
        try
        {
            int result = numerator / denominator;
            Console.WriteLine($"{numerator} / {denominator} = {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error aritmético: No se puede dividir por cero ({ex.Message})");
        }
        finally
        {
            Console.WriteLine("  [finally] Operación de división finalizada.");
        }
    }

    static void TestParsing(string input)
    {
        try
        {
            int number = int.Parse(input);
            Console.WriteLine($"Número convertido: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Error de formato: '{input}' no es un número entero válido.");
        }
    }

    static void TestInvalidShape()
    {
        try
        {
            _ = new Circle(-3);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error de argumento en figura: {ex.Message}");
        }
    }
}
