using System;
using System.Text;
class Programm
{
    public static void MethodTaskNine(string a)
    {
        int count = 0, i;
        for (i = 0; i < a.Length; i++)
            if (a[i] == '(')
                count++;
            else if (a[i] == ')' && --count < 0)
                break;
        Console.WriteLine(count);
        Console.WriteLine(i);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст, содержащий скобки: ");
        var input = Console.ReadLine();
        MethodTaskNine(input);
        Console.ReadKey();
    }
}
