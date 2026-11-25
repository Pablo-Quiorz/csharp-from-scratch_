namespace LogicExercises15;

public static class Exercises
{
    // 1. Determinar si un número es par o impar
    public static string IsEvenOrOdd(int number)
    {
        return number % 2 == 0 ? $"{number} es Par" : $"{number} es Impar";
    }

    // 2. Encontrar el mayor de tres números
    public static int MaxOfThree(int a, int b, int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }

    // 3. Suma de los primeros N números naturales
    public static int SumFirstN(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    // 4. Tabla de multiplicar de un número (1 al 10)
    public static string[] MultiplicationTable(int number)
    {
        string[] lines = new string[10];
        for (int i = 1; i <= 10; i++)
        {
            lines[i - 1] = $"{number} x {i} = {number * i}";
        }
        return lines;
    }

    // 5. Calcular el factorial de un número
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("El factorial no está definido para negativos.");
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    // 6. Serie de Fibonacci (primeros N términos)
    public static int[] Fibonacci(int count)
    {
        if (count <= 0) return [];
        int[] series = new int[count];
        series[0] = 0;
        if (count > 1) series[1] = 1;

        for (int i = 2; i < count; i++)
        {
            series[i] = series[i - 1] + series[i - 2];
        }
        return series;
    }

    // 7. Verificar si un número es primo
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // 8. Invertir una cadena de texto
    public static string ReverseString(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }

    // 9. Contar vocales en una cadena
    public static int CountVowels(string text)
    {
        int count = 0;
        string vowels = "aeiouáéíóúAEIOUÁÉÍÓÚ";
        foreach (char c in text)
        {
            if (vowels.Contains(c)) count++;
        }
        return count;
    }

    // 10. Verificar si una palabra es palíndromo
    public static bool IsPalindrome(string text)
    {
        string normalized = new string(text.ToLowerInvariant().Where(char.IsLetterOrDigit).ToArray());
        string reversed = ReverseString(normalized);
        return normalized == reversed;
    }

    // 11. Suma y promedio de un arreglo de enteros
    public static (int Sum, double Average) SumAndAverage(int[] numbers)
    {
        if (numbers.Length == 0) return (0, 0);
        int sum = 0;
        foreach (int n in numbers) sum += n;
        return (sum, (double)sum / numbers.Length);
    }

    // 12. Encontrar mínimo y máximo en un arreglo
    public static (int Min, int Max) FindMinAndMax(int[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("El arreglo no puede estar vacío.");
        int min = numbers[0];
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n < min) min = n;
            if (n > max) max = n;
        }
        return (min, max);
    }

    // 13. FizzBuzz del 1 al N
    public static string[] FizzBuzz(int n)
    {
        string[] result = new string[n];
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0) result[i - 1] = "FizzBuzz";
            else if (i % 3 == 0) result[i - 1] = "Fizz";
            else if (i % 5 == 0) result[i - 1] = "Buzz";
            else result[i - 1] = i.ToString();
        }
        return result;
    }

    // 14. Conversión de temperatura (Celsius <-> Fahrenheit)
    public static double CelsiusToFahrenheit(double celsius) => (celsius * 9.0 / 5.0) + 32.0;
    public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32.0) * 5.0 / 9.0;

    // 15. Contar dígitos y sumar los dígitos de un número entero
    public static (int DigitCount, int DigitSum) AnalyzeDigits(int number)
    {
        int value = Math.Abs(number);
        if (value == 0) return (1, 0);

        int count = 0;
        int sum = 0;
        while (value > 0)
        {
            sum += value % 10;
            value /= 10;
            count++;
        }
        return (count, sum);
    }
}
