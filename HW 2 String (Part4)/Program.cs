using System;
using System.Text;
using System.Text.RegularExpressions;
class Programm
{
    public static void MethodTaskSeven(string a)
    {
        a.ToCharArray();
        var count = 0;
        var strb = new StringBuilder();
            for(var j = 0; j < a.Length; j++) // выводим все цифры
            if (char.IsDigit(a[j]))
            {
                Console.Write(a[j]);
                count++;
                strb.Append(a[j]);
            }
        Console.WriteLine($"\n{count}");// определяем кол-во цифр
        Console.WriteLine(strb.ToString().Max());//получаем максимальное значение
        //count = 1;
       // var count1 = 0;
       // for (var j = 0; j < strb.Length - 1; j++)
         //   if (strb[j] - strb[j + 1] == 0)
          //      count++;
         //   else if (count > count1)
          //      count1 = count;
      //  Console.WriteLine(count1);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст: ");
        var input = Console.ReadLine();
        MethodTaskSeven(input);
        Console.ReadKey();
    }
}
