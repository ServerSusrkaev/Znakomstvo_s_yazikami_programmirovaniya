System.Console.WriteLine("Укажите размерность массива");
int arrayLenght = int.Parse(System.Console.ReadLine());
int[] array = new int[arrayLenght];

Library.FillArray(array, arrayLenght);
Library.PrintArray(array, arrayLenght);