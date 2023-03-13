// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] array = new int[3,4] {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
decimal result = 0;
int index = 0;

while (index < array.GetLength(1))
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i,index];
    }
    System.Console.WriteLine(Math.Round(result / array.GetLength(0), 1));
    result = 0;
index++;
}