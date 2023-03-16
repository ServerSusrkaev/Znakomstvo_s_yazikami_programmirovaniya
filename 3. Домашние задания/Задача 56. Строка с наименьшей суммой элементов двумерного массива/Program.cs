// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 8 4 4 8 
// 5 2 6 7
// 1 1 1 1
// 5 9 2 3
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arrayInitial = new int[4,4] {{5, 2, 6, 7}, {8, 4, 4, 8}, {1, 1, 1, 1}, {5, 9, 2, 3}};
int[] arrayFinal = new int[arrayInitial.GetLength(1)];

//Заполненеи массива arrayFinal сумой числе каждой строки массива arrayInitial
int sum = 0;
for (int i = 0; i < arrayInitial.GetLength(0); i++)
{
    for (int j = 0; j < arrayInitial.GetLength(1); j++)
    {
        sum  += arrayInitial[i,j];
    }
    arrayFinal[i] = sum;
    sum = 0;
}

int minSumIndex = 1;
int minSum = arrayFinal[0];

for (int i = 1; i < arrayFinal.Length; i++)
{
    if (minSum > arrayFinal[i])
    {
        minSumIndex = i + 1;
        minSum = arrayFinal[i];
    }
}
System.Console.WriteLine("");
System.Console.Write("Строка с наименьшей суммой элементов №: " + minSumIndex);