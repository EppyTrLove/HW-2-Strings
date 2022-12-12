using System;
using System.Text;
class Programm
{
    public static void MethodTaskOne(string a)
    {
        var wordOne = a[2..^3];
        var wordTwo = a[7..^1];
        Console.WriteLine($"Получаем <{wordOne}> и <{wordTwo}>.");
    }
    public static void MethodTaskTwo(string a)
    {
        var result = a.Replace("вир", "фок");
        Console.WriteLine(result);
    }
    public static void MethodTaskThree(string a)
    {
        var sb = new StringBuilder(a);
        sb
            .Insert(a.Length, a[0])
            .Remove(0, 1);
        Console.WriteLine($"Абра кадабра и получаем {sb}!");
    }
    public static void MethodTaskFour(string a)
    {
        var str = a.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"Столица государства {str[0]} — город {str[1]}.");
        Console.WriteLine(String.Format("Столица государства {0} — город {1}.", str[0], str[1]));
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите слово 'информатика': ");
        var inputValue = Console.ReadLine();
        MethodTaskOne(inputValue);
        Console.WriteLine("\nВведите слово 'вирус': ");
        inputValue = Console.ReadLine();
        MethodTaskTwo(inputValue);
        inputValue = "рпроцессо";
        Console.WriteLine($"\nДано непонятное слово '{inputValue}'.");
        MethodTaskThree(inputValue);
        Console.WriteLine("\nВведите название государтсва и его столицы через пробел: ");
        inputValue = Console.ReadLine();
        MethodTaskFour(inputValue);    
    }
}
