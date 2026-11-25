namespace OopInheritance;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Video 12: Clases, Encapsulamiento y Herencia ===");

        var person = new Person("Laura Ríos", 28);
        var dev = new Developer("Pablo Quiroz", 22, "C# / .NET");
        var manager = new Manager("Carlos Méndez", 35, 8);

        Console.WriteLine(person.Describe());
        Console.WriteLine(dev.Describe());
        Console.WriteLine(manager.Describe());

        Console.WriteLine("\n--- Probando validación de encapsulamiento ---");
        try
        {
            dev.Age = -5;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Validación activada correctamente: {ex.Message}");
        }
    }
}
