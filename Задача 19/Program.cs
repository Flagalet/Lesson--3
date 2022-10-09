//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом;
int Pal(int num)
{    
    int b = num / 10000 % 10;
    int c = num % 10;
    int b1 = num / 1000 % 10;
    int c1 = num / 10 % 10;
    if (b == c && b1 == c1)
        Console.Write($"Число {num} является палиндромом");
    else  
        Console.Write($"Число {num} не является палиндромом");
    return num;
        

}
Console.Clear();
Console.WriteLine("Введите число" );
int a = int.Parse(Console.ReadLine()!);
Pal(a);
