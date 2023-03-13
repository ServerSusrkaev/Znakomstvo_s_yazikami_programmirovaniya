int number = new Random().Next(10,99);
Console.WriteLine("Число: " + number);

int firstNumber = number / 10;
int secondNumber = number % 10;

if (firstNumber > secondNumber)
{
    Console.WriteLine("Максимальная цифра в числе: " + firstNumber);
}
else
{
    Console.WriteLine("Максимальная цифра в числе: " + secondNumber);
}
