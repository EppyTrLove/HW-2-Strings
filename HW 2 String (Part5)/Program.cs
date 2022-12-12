using System;
using System.Text;
class Programm
{
    public static void MethodTaskEight(string a, string b)
    {
        a = a.ToLower();
        b = b.ToLower();
        var count = 0;
        while (count < b.Length && a.Contains(b[count]))
            count++;                                 
        if (count == b.Length)
            Console.WriteLine("Да, можно.");
        else
            Console.WriteLine("Нет, нельзя.");          
        for (int i = 0; i < b.Length; i++)
            if(a.Contains(b[i]))
                Console.Write(b[i]);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите первое слово: ");
        var input1 = Console.ReadLine();
        Console.WriteLine("Введите второе слово: ");
        var input2 = Console.ReadLine();
        MethodTaskEight(input1, input2);
        Console.ReadKey();
    }
}
