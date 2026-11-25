namespace OopInheritance;

/// <summary>
/// Base class demonstrating encapsulation via private fields and validated properties.
/// </summary>
public class Person
{
    private string _name = string.Empty;
    private int _age;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(value));
            _name = value.Trim();
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0 || value > 130)
                throw new ArgumentOutOfRangeException(nameof(value), "La edad debe estar entre 0 y 130.");
            _age = value;
        }
    }

    protected string Institution { get; } = "Academia .NET";

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string GetRole() => "Persona";

    public virtual string Describe()
    {
        return $"[{GetRole()}] {Name}, {Age} años - {Institution}";
    }
}
