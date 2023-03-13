// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arrayInitial = new int[4,4] {{1, 4, 7, 2}, {5, 9, 2, 3}, {1, 4, 2, 4}, {5, 2, 6, 7}};
int[] arrayFinal = new int[arrayInitial.GetLength(1)];

int sum = 0;

for (int i = 0; i < arrayInitial.GetLength(0); i++)
{
    for (int j = 0; j < arrayInitial.GetLength(1); j++)
    {
        sum  += arrayInitial[i,j];
    }
    arrayFinal[i] = sum;
    //System.Console.WriteLine(sum);
    sum = 0;
}

int minSumIndex = arrayFinal[0];

for (int i = 0; i < arrayFinal.Length; i++)
{
    System.Console.Write(arrayFinal[i]);
    System.Console.Write(" ");
    if (minSumIndex > arrayFinal[i])
    {
        minSumIndex = i+1;
    }
}
System.Console.WriteLine(" ");
System.Console.Write("Строка с наименьшей суммой элементов №: " + minSumIndex);