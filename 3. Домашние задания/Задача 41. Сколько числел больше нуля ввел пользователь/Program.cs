// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int number = 0;
int count = 0;
string inpuValue = " ";

while (inpuValue != string.Empty)
{
    System.Console.Write("Введите число: ");
    inpuValue = Console.ReadLine();
    if (inpuValue == string.Empty) break;
    number = int.Parse(inpuValue);
    if (number > 0) count++;
}
System.Console.WriteLine("Количество чисел больше нуля: " + count);