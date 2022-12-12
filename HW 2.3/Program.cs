using System;
class Programm
{
    public static void MathMethods(int a, int b)
    {
        if (b <= a)
            Console.WriteLine("Введены некорректные границы диапазона чисел!");
        var rnd = new Random();
        var firstValue = rnd.Next(a, b);
        var secondValue = rnd.Next(a, b);
        var thirdValue = rnd.Next(a, b);
        Console.WriteLine($"В заданном Вами диапазоне выбраны 3 случайных числа: {firstValue}, {secondValue}, " +
            $"{thirdValue}.");
        double arithAverage = (double)(firstValue + secondValue + thirdValue) / 3;
        double geomAverage = Math.Sqrt(firstValue * secondValue * thirdValue);
        Console.WriteLine($"Среднее арифметическое выбранных чисел раняется: {arithAverage}." +
            $"\nСреднее геометрическое выбранных чисел равняется: {geomAverage}.");
        double div = (double)firstValue / secondValue / thirdValue;
        Console.WriteLine($"Результат деления числе равен: {div}.");
        Console.WriteLine("До скольки знаков после запятой необходимо округлить значение?");
        var result = int.Parse(Console.ReadLine());
        Console.WriteLine($"Полученный результат:{Math.Round(div, result)}.");
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите нижнюю границу диапазона: ");
        var userValue1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите верхнюю границу диапазона: ");
        var userValue2 = int.Parse(Console.ReadLine());
        MathMethods(userValue1, userValue2);
        Console.ReadKey();
    }
}
