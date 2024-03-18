// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

﻿void PrintReversArray(int[] array, int size)
{
    if (size < 1)
    {
        return;
    }
    Console.Write($"{array[size - 1]} ");
    PrintReversArray(array, size - 1);
}

int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 9);
    };
    foreach(int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();

PrintReversArray(array, array.Length);