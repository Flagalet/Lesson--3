// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kyb(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.Write($"{i*i*i}");
        if (i != a)
        Console.Write($", ");
    }
}
Console.Clear();
Console.WriteLine("Введите число");
int res = int.Parse(Console.ReadLine()!);
Kyb(res);

