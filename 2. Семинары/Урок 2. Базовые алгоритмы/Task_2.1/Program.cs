//Напишите программу, которая выводит случайное трехзначное число и удаляет
//вторую цифру этого числа.

int number = new Random().Next(100 , 999);
Console.WriteLine(number);
int a = number / 100;
int c = number % 10;

int result = a * 10 + c;

Console.WriteLine(result);