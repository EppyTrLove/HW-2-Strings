using System;
using System.Text;
class Programm
{
    public static void MethodTaskFive(string a, int x, int y)
    {
        var arr = a.ToCharArray(); 
        Console.WriteLine(arr.Reverse().ToArray()); //Выводим слово наоборот
        Console.WriteLine(arr[x - 1]);  //Выводим на экран символ под выбранным номером.Вычитаем единицу т.к. нумерация в массиве с 0
        if (arr[x - 1] == arr[y - 1])
            Console.WriteLine($"Символы {x} и {y} в слове {a} равны!");
        else
            Console.WriteLine($"Символы {x} и {y} в слове {a} не равны!");//Определяем одинаковы ли символы под номерами X и Y
        Console.WriteLine($"{arr[x - 1]}{arr[y - 1]}");  //Выводим на экран буквосочетание
        //степень сделать!!!!!!!!!!!!!!!!
        Console.WriteLine(arr.Distinct().Count());  //Определяем сколько различных букв в слове
        var count = 0; //Определяем сколько соседних одинаковых букв в слове
        for (int i = 0; i < arr.Length ; i++)
            if (arr[i] == arr[i + 1])
                count++;
        Console.WriteLine(count); 
        Console.WriteLine(a.Substring(0, a.Length/2)); //выводим на экран первую половину слова
        Console.WriteLine($"{a.Substring(a.Length / 2)}{a.Substring(0, a.Length / 2)}");//меняем местами первую и вторую половины слова
        var result = a.Substring(a.Length - x) + a.Substring(x, a.Length-x*2) + a.Substring(0, x); //переставляем первые Х и последние Х буквы
        Console.WriteLine(result);
        var arr1 = arr.Reverse().ToString(); //проверяем, является ли слово «перевертышем»
        Console.WriteLine(String.Compare(a, arr1));
    }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите слово: ");
            var inputValue1 = Console.ReadLine();
            Console.WriteLine("Введите номер первого выбранного символа: ");
            var inputValue2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер второго выбранного символа: ");
            var inputValue3 = int.Parse(Console.ReadLine());
            MethodTaskFive(inputValue1, inputValue2, inputValue3);
            Console.ReadLine();
        }
    }

