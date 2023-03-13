
//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int[] firstPoint = new int[3] {7, -5, 0};
int[] secondPoint = new int[3] {1, -1, 9};
double value = 0;

for (int i = 0; i < firstPoint.Length; i++)
{
    value = value + Math.Pow(secondPoint[i] - firstPoint[i], 2);
}
System.Console.Write(Math.Round(Math.Sqrt(value), 2));