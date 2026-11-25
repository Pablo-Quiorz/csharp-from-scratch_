namespace OopInheritance;

public class Manager : Person
{
    public int TeamSize { get; set; }

    public Manager(string name, int age, int teamSize)
        : base(name, age)
    {
        TeamSize = teamSize;
    }

    public override string GetRole() => "Líder Técnico";

    public override string Describe()
    {
        return $"{base.Describe()} | Equipo a cargo: {TeamSize} personas";
    }
}
