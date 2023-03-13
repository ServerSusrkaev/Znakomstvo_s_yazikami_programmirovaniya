// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//System.Console.WriteLine("Input row numbers: ");
int row = 3;//int.Parse(Console.ReadLine());

//System.Console.WriteLine("Input column numbers: ");
int column = 4;//int.Parse(Console.ReadLine());

int[,] array = new int[row,column];

//Заполнение массива случайными числами
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i,j] = new Random().Next(-1, 10);
    }
}
//Печать массива
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
       System.Console.Write(array[i,j] + " ");
    }
    System.Console.WriteLine();
}