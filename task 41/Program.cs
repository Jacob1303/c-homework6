// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

using System;

class Programm
{
    static int[] CreatArray(string Array)
    {
        string[] nums = Array.Split(",", StringSplitOptions.RemoveEmptyEntries);
        int[] numb = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            numb[i] = int.Parse(nums[i]);
        }
        return numb;
    }

    static int PositiveNumb(int[] array)
    {
        int count = 0;
        foreach (var item in array)
        {
            if (item > 0) count++;
        }
        return count;
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую. По окончании ввода нажмите Enter");
        string elements = Console.ReadLine();
        Console.WriteLine("Количество чисел больше нуля = " + PositiveNumb(CreatArray(elements)));
    }
}
