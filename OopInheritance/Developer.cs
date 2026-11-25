namespace OopInheritance;

public class Developer : Person
{
    public string PrimaryLanguage { get; set; }

    public Developer(string name, int age, string primaryLanguage)
        : base(name, age)
    {
        PrimaryLanguage = primaryLanguage;
    }

    public override string GetRole() => "Desarrollador";

    public override string Describe()
    {
        return $"{base.Describe()} | Lenguaje principal: {PrimaryLanguage}";
    }
}
