int number = new Random().Next(10,99);
Console.WriteLine(number);

int firstNumber = number / 10;
int secondNumber = number %10;

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}