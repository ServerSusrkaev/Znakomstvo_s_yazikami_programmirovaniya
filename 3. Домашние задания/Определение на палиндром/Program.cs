// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

System.Console.Write("Input the number: ");
string textNumber = Console.ReadLine();
int[] array = new int[textNumber.Length];

Library.FillArray(array, textNumber);

for (int i = 0; i < (textNumber.Length - 1) / 2; i++)
{
    if (array[i] != array[(textNumber.Length - i) - 1])
    {
        System.Console.WriteLine("Число не является палиндромом.");
        break;
    } 
    else if (array [i] == (textNumber.Length - 1) / 2)
    {
        System.Console.WriteLine("Число является палиндромом.");
    }
}