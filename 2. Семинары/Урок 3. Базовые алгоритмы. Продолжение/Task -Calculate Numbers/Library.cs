public class Library
{
    //Создание массива.
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }
    
    //Заполнение массива
    // public static int FillArray(int number)
    // {
    //     for (int i = 0; i < number; i++)
    //     {
    //         number = new Random().Next(1, 10);
    //     }
    //     return number;
    // }
    
    
    //Печать массива
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            
            Console.Write(arr[i] + " ");
        }
    }
}