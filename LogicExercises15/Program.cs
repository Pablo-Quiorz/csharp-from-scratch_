namespace LogicExercises15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Video 14: 15 Ejercicios Prácticos de Lógica en C# ===\n");

        // 1. Par o impar
        Console.WriteLine($"1. Par o Impar: {Exercises.IsEvenOrOdd(42)} | {Exercises.IsEvenOrOdd(17)}");

        // 2. Mayor de tres números
        Console.WriteLine($"2. Mayor de (12, 45, 29): {Exercises.MaxOfThree(12, 45, 29)}");

        // 3. Suma de los primeros N números
        Console.WriteLine($"3. Suma del 1 al 10: {Exercises.SumFirstN(10)}");

        // 4. Tabla de multiplicar
        Console.WriteLine("4. Tabla del 7: " + string.Join(" | ", Exercises.MultiplicationTable(7)));

        // 5. Factorial
        Console.WriteLine($"5. Factorial de 6: {Exercises.Factorial(6)}");

        // 6. Serie de Fibonacci
        Console.WriteLine($"6. Fibonacci (10 términos): {string.Join(", ", Exercises.Fibonacci(10))}");

        // 7. Número primo
        Console.WriteLine($"7. ¿Es primo 29?: {Exercises.IsPrime(29)} | ¿Es primo 21?: {Exercises.IsPrime(21)}");

        // 8. Invertir cadena
        Console.WriteLine($"8. Invertir 'DotNet': {Exercises.ReverseString("DotNet")}");

        // 9. Contar vocales
        Console.WriteLine($"9. Vocales en 'Programación Orientada a Objetos': {Exercises.CountVowels("Programación Orientada a Objetos")}");

        // 10. Palíndromo
        Console.WriteLine($"10. ¿Es palíndromo 'Anita lava la tina'?: {Exercises.IsPalindrome("Anita lava la tina")}");

        // 11. Suma y promedio en arreglo
        int[] sampleArray = [10, 25, 8, 42, 15];
        var (sum, avg) = Exercises.SumAndAverage(sampleArray);
        Console.WriteLine($"11. Arreglo [{string.Join(", ", sampleArray)}] -> Suma: {sum}, Promedio: {avg:F2}");

        // 12. Mínimo y máximo en arreglo
        var (min, max) = Exercises.FindMinAndMax(sampleArray);
        Console.WriteLine($"12. Mínimo: {min}, Máximo: {max}");

        // 13. FizzBuzz
        Console.WriteLine($"13. FizzBuzz (1..15): {string.Join(", ", Exercises.FizzBuzz(15))}");

        // 14. Conversión de temperatura
        Console.WriteLine($"14. 25°C = {Exercises.CelsiusToFahrenheit(25):F1}°F | 77°F = {Exercises.FahrenheitToCelsius(77):F1}°C");

        // 15. Dígitos de un número
        var (digits, digitSum) = Exercises.AnalyzeDigits(2026);
        Console.WriteLine($"15. Número 2026 -> Cantidad de dígitos: {digits}, Suma de dígitos: {digitSum}");
    }
}
