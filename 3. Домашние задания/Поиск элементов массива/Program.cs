int [] array = new int[11] {8, 1, 2, 3, 2, 1, 7, 7, 8, 9, 1};
int count = 0;
int temp = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+ " ");
}

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > array[i])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();
Console.WriteLine();

int number = -1;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] == array[i]) count++;        
    }
    if (array[i] != number) Console.WriteLine(array[i] + " - " + count + " раз");
    count= 0;
    number = array[i];
}