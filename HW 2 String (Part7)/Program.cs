using System;
using System.Text;
class Programm
{
    public static string MethodTaskTen(string a, int b)
    {
            int ind = 0;
            while (a.Length < b && (ind = a.IndexOf(" ", ind)) != -1)
            {
                a = a.Insert(ind, " ");
                while (a[ind] == ' ') 
                ind++;
            }
            if (a.Length < b) return MethodTaskTen(a, b);
            return a;
        }
        public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст, содержащий пробелы: ");
        var input1 = Console.ReadLine();
        Console.WriteLine("Введите число: ");
        var input2 = int.Parse(Console.ReadLine());
        Console.WriteLine(MethodTaskTen(input1, input2));
        Console.ReadKey();
    }
}
