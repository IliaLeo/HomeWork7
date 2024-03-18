// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunkAkkerman(int m, int n)
{
if (m == 0) 
{
    return n + 1;
}
else if (n == 0)
{
    return FunkAkkerman(m - 1, 1);
} 
else 
{
    return FunkAkkerman(m - 1, FunkAkkerman(m, n - 1));
}
}
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{FunkAkkerman(m, n)} ");