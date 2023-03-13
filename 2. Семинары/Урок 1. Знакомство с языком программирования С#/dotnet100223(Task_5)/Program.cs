//Программа принимает на вход число N, а на выходе показывает все целые числа
//в диапазоне от -N до N 
Console.Clear();
int value = 0;
string result = "";

Console.WriteLine("Input a number:");
int N = Int32.Parse(Console.ReadLine());

int index = N + 1;

while (index <= N * 2)
 {
     value = N - index;
     result += value.ToString();
     index ++;
 }
 result += " 0";
 index = N - 1;

    while (index >= N - N)
     {
        value = N - index;
        result += " " + value.ToString();
        index --;
     }
Console.WriteLine(result);
//Очередность отрицательных чисел не верная. после 0 в отрицательную сторону
// должен идти -1. Более хороший код: введенное число перевести в отрицательное и к нему
// прибовлять значение index в цикле.