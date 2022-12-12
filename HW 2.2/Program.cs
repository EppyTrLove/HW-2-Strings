using System;
class Programm
{
    public static int RecursionFactorial(int n)
    {
        if (n == 1) return 1;
        return n * RecursionFactorial(n - 1);
    }
    public static int Factorial(int n)
    {
        var result = 1;
        if (n == 1) return result;
        for (var i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        var userIn = int.Parse(Console.ReadLine());
        var result = $"Факториал числа {userIn} равен {Factorial(userIn)}.";
        Console.WriteLine(result);
    }
}
