    //4+5+6+7+8 = 30
    Console.Write("Введите значение М: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = int.Parse(Console.ReadLine());
      
    int sum = 0;
    int index = 0;
    for (int i=m; i<=n; i++)
      {
        Console.Write(m + index + " ");
        sum += m + index;
      index++;
      }
      Console.WriteLine(" ");
      Console.Write("M = " + m + "; N = " + n + " -> " + sum);