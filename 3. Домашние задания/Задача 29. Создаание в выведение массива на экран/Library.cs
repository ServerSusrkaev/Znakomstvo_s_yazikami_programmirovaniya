public class Library
{
    public static void FillArray(int[] arr, int lenght)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1, lenght + 1);
        }
    }

    public static void PrintArray(int[] arr, int size)
    {
        string arrayLine = "";
        for (int i = 0; i < size; i++)
        {
            if (i != size - 1)
            {
                arrayLine += arr[i] + ", ";
            }
            else
            {
                arrayLine += arr[i];
            }
        }
        System.Console.WriteLine("[" + arrayLine + "]");
    }
}