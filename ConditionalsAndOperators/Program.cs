namespace ConditionalsAndOperators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Video 11: Condicionales y Operadores ===");

        // 1. Operadores aritméticos
        int a = 15;
        int b = 4;
        Console.WriteLine($"a = {a}, b = {b}");
        Console.WriteLine($"Suma: {a + b} | Resta: {a - b} | Multiplicación: {a * b}");
        Console.WriteLine($"División entera: {a / b} | Módulo (residuo): {a % b}");
        Console.WriteLine($"División decimal: {(double)a / b:F2}");

        // 2. Operadores de comparación y lógicos + if / else if / else
        Console.WriteLine("\n--- Evaluación de calificación ---");
        double grade = 4.3;
        bool hasAttendance = true;

        if (grade >= 4.5 && hasAttendance)
        {
            Console.WriteLine($"Nota {grade}: Excelente, aprobado con distinción.");
        }
        else if (grade >= 3.0 && hasAttendance)
        {
            Console.WriteLine($"Nota {grade}: Aprobado.");
        }
        else if (grade >= 3.0 && !hasAttendance)
        {
            Console.WriteLine($"Nota {grade}: Reprobado por inasistencia.");
        }
        else
        {
            Console.WriteLine($"Nota {grade}: Reprobado por calificación.");
        }

        // 3. Operador ternario
        int number = 17;
        string parity = (number % 2 == 0) ? "Par" : "Impar";
        Console.WriteLine($"\nEl número {number} es: {parity}");

        // 4. Switch expression (evaluación de día de la semana)
        int dayNumber = 5;
        string dayName = dayNumber switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            4 => "Jueves",
            5 => "Viernes",
            6 => "Sábado",
            7 => "Domingo",
            _ => "Día inválido"
        };
        Console.WriteLine($"Día {dayNumber} corresponde a: {dayName}");

        // 5. Operador OR lógico (||)
        bool isWeekend = (dayNumber == 6 || dayNumber == 7);
        Console.WriteLine($"¿Es fin de semana?: {(isWeekend ? "Sí" : "No")}");
    }
}
