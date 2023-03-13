//Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток 
//от деления.

Console.WriteLine("Введите первое число:");
double a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
double b = int.Parse(Console.ReadLine());

if (a % b == 0)
 {
     System.Console.WriteLine("Второе число кратно первому.");
 }
 else
 {
     //result = result % 10;
     System.Console.WriteLine("Второе число не кратно первому. Результат от деления: " + a / b);
}