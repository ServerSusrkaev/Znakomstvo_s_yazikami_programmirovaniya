System.Console.WriteLine("Укажите размер массива: ");
int number = int.Parse(Console.ReadLine());
int [] array = Library.CreateArray(number);

// //Рэндомное заполнение массива
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1 , number + 1);
}
Library.PrintArray(array);
Console.WriteLine();
//Определение количества одинаковых элемнетов массива
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = i; j < array.Length; j++)
    {
        if (array[j] == array[i])
        {
            count++;
        }
    }
    Console.WriteLine(array[i] + " - " + count + " р");
    count = 0;
    //Изъятие из массива отработанного элемента
    array = array.Where(e => e != array[i]).ToArray();
    i--;
}