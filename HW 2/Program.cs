using System;
using System.Text;
class Programm
{
    private static StringBuilder BuildFirsWayPyramid(int height)
    {
        var result = new StringBuilder();
        for (var i = 0; i < height; i++)
        {
            for (var j = height - 1; j > i; j--)
            {
                result.Append(" ");
            }
            for (var j = 1; j <= 1; j++)
            {
                result.Append("*");
            }
            for (var j = 1; j <= i; j++)
            {
                result.Append("**");
            }
            result.Append("\n");
        }
        return result;
    }
    private static string BuildSecondWayPyramid(int height)
    {
        for (var i = 0; i < height; i++)
        {
            for (var j = height - 1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (var j = 1; j <= 1; j++)
            {
                Console.Write("*");
            }
            for (var j = 1; j <= i; j++)
            {
                Console.Write("**");
            }
            Console.WriteLine();
        }
        string result = Console.ReadLine();
        return result;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Укажите высоту ёлки: ");
        var height = int.Parse(Console.ReadLine());
        var result = BuildSecondWayPyramid(height);
        Console.WriteLine(result);
    }
}
