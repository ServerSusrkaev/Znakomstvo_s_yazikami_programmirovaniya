System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result =0 ;

while (number > 0)
{
    result += number % 10;
    number = number / 10;
}
System.Console.WriteLine(result);