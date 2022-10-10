// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
int Kor( int kor, int kor2)
{
    int res = (kor2 - kor) * (kor2 - kor);
    return res;
}

Console.WriteLine("Введите координаты точек A");
int x1 = int.Parse(Console.ReadLine()!);
int y1 = int.Parse(Console.ReadLine()!);
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точек B");
int x2 = int.Parse(Console.ReadLine()!);
int y2 = int.Parse(Console.ReadLine()!);
int z2 = int.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Kor(x1, x2)+Kor(y1, y2)+Kor(z1, z2));
Console.WriteLine($"{result:f2}");
