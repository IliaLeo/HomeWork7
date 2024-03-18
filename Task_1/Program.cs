// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNumbers(int n, int m)
{
    if (n > m)
    {
        return;
    }
    Console.Write($"{n} ");
    PrintNumbers(n + 1, m);
}

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

PrintNumbers(n , m);
