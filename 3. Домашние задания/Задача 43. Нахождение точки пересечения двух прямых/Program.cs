// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


//System.Console.Write("Введите значение b1: ");
double b1 = 2;//int.Parse(Console.ReadLine());
//System.Console.Write("Введите значение b2: ");
double b2 = 4;//int.Parse(Console.ReadLine());
//System.Console.Write("Введите значение k1: ");
double k1 = 5;//int.Parse(Console.ReadLine());
//System.Console.Write("Введите значение k2: ");
double k2 = 9;//int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

System.Console.WriteLine(x + " " + y);
