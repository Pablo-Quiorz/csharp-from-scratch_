namespace ClassesAndInterpolation;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Video 10: Clases e Interpolación de Cadenas ===");

        var pablo = new Student("Pablo Quiroz", 22, "C# y .NET desde Cero");
        var mateo = new Student("Mateo Gómez", 25, "Programación Orientada a Objetos");

        Console.WriteLine(pablo.GetGreeting());
        Console.WriteLine(pablo.GetSummaryCard());
        Console.WriteLine();
        Console.WriteLine(mateo.GetGreeting());
        Console.WriteLine(mateo.GetSummaryCard());

        // Interpolación con expresiones y formato numérico
        double progress = 0.75;
        Console.WriteLine($"Progreso actual del curso: {progress:P0} (Video 10 de 15)");
    }
}
