System.Console.WriteLine("Введите основание степени: ");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите показатель степени: ");
int stepen = int.Parse(Console.ReadLine());
int result = number;
for (int i = 0; i < stepen - 1; i++)
 {
     result *= number;
  }
System.Console.Write(result);