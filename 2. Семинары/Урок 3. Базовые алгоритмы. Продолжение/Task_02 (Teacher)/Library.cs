public class Library
{
    //Создать массив
    public static int[] CreateArray(int size)
    {
        return new int[size];
    }

    //Рапечатать массив
    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}


