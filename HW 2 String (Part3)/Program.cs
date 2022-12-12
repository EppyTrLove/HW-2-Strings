using System;
using System.Text;
class Programm
{
    public static void MethodTaskSix(string a, char x, string y)
    {
        var arr = a.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var countY = 0;                             //определяем число вхождений в него некоторого буквосочетания
        foreach (var item in arr)
            for (int i = 0; i < item.Length; i++)
                if (item.IndexOf(y, i) == i)
                    countY++;
        Console.WriteLine(countY);
        Console.WriteLine(arr.Length);              //определяем количество слов в предложении
        foreach (var item in arr)
            Console.Write(item[0]);
        Console.WriteLine("\n");
        Array.Reverse(arr);   //печатаем слова в обратном порядке (разобраться с запятыми!)
        foreach (var item in arr)
            Console.Write(item + " ");
    }
    public static void MethodTaskSix(string a, string y) //выводим все вхождения в предложение заданных слов
    {
        var arr = y.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var count = 0;
        for (int i = 0; i < arr.Length; i++)
            if (a.Contains(arr[i]))
            {
                count++;
                Console.Write($"{arr[i]}; ");
            }
    }
    public static void MethodTaskSix(string a, char x) 
    {
        var arr = a.ToCharArray();
        var count = 0;                      //определяем долю (в %) букв Х
        var countSum = 0;
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                count++;
            if (a.Substring(i, 1) != " ")
                countSum++;
        }
        Console.WriteLine($"{Math.Round((float)count / countSum * 100, 2)}%");
        char[] vowelArr = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };//определяем кол-во гласных
        count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            int vowelCount = a.IndexOfAny(vowelArr, j);
            if (vowelCount != -1)
            {
                j = vowelCount;
                count++;
            }
        }
        Console.WriteLine(count);
        count = 0;
        for (int i = 0; i < arr.Length-1; i++) //определяем, верно ли, что в нем есть пять идущих подряд одинаковых символов?
        {
            if (arr[i] == arr[i + 1])
                count++;
            else
                count = 1;
        }
            if (count == 5)
                Console.WriteLine("Да, есть.");
            else if (count != 5)
                Console.WriteLine("Нет.");

        for (int i = 1; i < arr.Length; i++) //меняем символы, стоящие на третьем, шестом, девятом и т. д. местах
        {
            if (i != 0 && i % 3 == 0)
                arr[i] = x;
            Console.Write(arr[i]);
        }
    }
        public static void Main(string[] args)
        {
        Console.WriteLine("Введите ваше предложение: ");
        var inputValue1 = Console.ReadLine();
        Console.WriteLine("\nВведите желаемую букву: ");
        var inputValue2 = char.Parse(Console.ReadLine());
        MethodTaskSix(inputValue1, inputValue2);
        Console.WriteLine("\nВведите буквосочетание: ");
        var inputValue3 = Console.ReadLine();
        MethodTaskSix(inputValue1, inputValue2, inputValue3);
        Console.WriteLine("\nВведите слова: ");
        var inputValue4 = Console.ReadLine();
        MethodTaskSix(inputValue1, inputValue4);
        Console.ReadLine();
        }
    }
