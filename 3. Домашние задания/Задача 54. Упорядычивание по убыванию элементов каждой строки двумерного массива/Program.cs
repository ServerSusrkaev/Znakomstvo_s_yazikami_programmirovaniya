﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = new int[3,4] {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};
int tempNumber = array[0,0];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i,j] > array[i,k])
            {
                tempNumber = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = tempNumber;
            }
        }
    }
}

for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
        System.Console.Write(array[i,j]);
        System.Console.Write(" ");
       } 
       System.Console.WriteLine();
    }