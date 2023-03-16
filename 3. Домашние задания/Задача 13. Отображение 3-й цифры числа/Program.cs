//Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

int index = 0;

Console.WriteLine("Введите чило: ");
int number = int.Parse(Console.ReadLine());
int digits = number.ToString().Length;

if (digits > 3)
    {
        while (index < digits - 3)
        {
            number = number / 10;
            index++;
        }
        number = number % 10;
        Console.WriteLine(number);
    }
else if (digits == 3)
    {
        Console.WriteLine(number % 10);
    }
else
    {
        Console.WriteLine("Введенное число является 2-х значным");
    }