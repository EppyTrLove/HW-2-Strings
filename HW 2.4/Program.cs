using System;
using System.Text;
class Programm
{
    public static void MathMethod(int a)
    {
        var length = Math.Log10(a);
        var str = a.ToString();
        var s = new StringBuilder(str);
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] % 2 != 0)
                s[i] = (char)((int)s[i] + 1);
        }
        Console.WriteLine($"Количество разрядов введеного целого числа равняется {s.Length}." +
            $"\nПосле замены нечетных чисел на четные получаем: {s}.");
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out var userValue))
            MathMethod(userValue);
        else
            Console.WriteLine("Вы ввели не целое число!");
        Console.ReadKey();
    }
}
