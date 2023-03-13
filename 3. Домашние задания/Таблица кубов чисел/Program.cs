
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

System.Console.WriteLine("Input rhe number: ");
int number = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 1; i <= number; i++)
{
    result = i * i * i;
    System.Console.Write(result + ", ");
}