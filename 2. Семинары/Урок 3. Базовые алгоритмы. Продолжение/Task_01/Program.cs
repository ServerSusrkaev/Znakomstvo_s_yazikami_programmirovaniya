//Задача 1.
//Перемешивание элементов массива

Console.WriteLine("Укажите размерность массива");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];
int index = 0;

while (index < array.Length)
{
    Console.Write("Введите элемент массива: ");
    array[index] = int.Parse(Console.ReadLine());
    index ++;
}
int oldValue = 0;
int newValue= 0;

for (int i = 0; i < array.Length; i++)
{
    newValue = new Random().Next(i, array.Length);
    
    oldValue = array[i];
    array[i] = array[newValue];
    array[newValue] = oldValue;

    Console.Write(array[i] + " ");
}