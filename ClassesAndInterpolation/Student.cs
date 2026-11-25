namespace ClassesAndInterpolation;

/// <summary>
/// Represents a student enrolled in the C# course.
/// </summary>
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Course { get; set; }
    public DateTime EnrolledAt { get; }

    public Student(string name, int age, string course)
    {
        Name = name;
        Age = age;
        Course = course;
        EnrolledAt = DateTime.Now;
    }

    public string GetGreeting()
    {
        return $"Hola, soy {Name}, tengo {Age} años y estoy estudiando {Course}.";
    }

    public string GetSummaryCard()
    {
        return $"""
            ==============================
            Estudiante : {Name}
            Edad       : {Age} años
            Curso      : {Course}
            Registro   : {EnrolledAt:yyyy-MM-dd HH:mm}
            ==============================
            """;
    }
}
