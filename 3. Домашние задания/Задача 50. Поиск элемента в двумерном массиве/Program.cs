// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[3, 4] {{1,4,7,2}, {5,9,2,3}, {8,4,2,6}};
System.Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
bool flag = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i,j] == number)
        {
            System.Console.WriteLine("Искомое число находится на позиции строка: " + (i+1) + " столбец: " + (j+1));
            flag = true;
        }
    }
}
if (flag == false) {System.Console.WriteLine("Искомое число в массиве отсутствует");};