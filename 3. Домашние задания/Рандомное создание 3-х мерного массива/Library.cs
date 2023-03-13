public class Library
{
    public static void CreateArray(int[,,] arr)
    {
        int number = 0;
        for (int x = 0; x < arr.GetLength(0); x++)
        {
           for (int y = 0; y < arr.GetLength(1); y++)
           {
                for (int z = 0; z < arr.GetLength(2); z++)
                {
                    number = new Random().Next(10,100);
                    if (arr[x,y,z] != number)
                    {
                        arr[x,y,z] = number;
                    }
                }
           } 
        }
        return;
    }
    public static void PrintArray(int[,,] arr)
    {
       for (int x = 0; x < arr.GetLength(0); x++)
        {
           for (int y = 0; y < arr.GetLength(1); y++)
           {
                for (int z = 0; z < arr.GetLength(2); z++)
                {
                    System.Console.Write(arr[x,y,z] + "(" + x + "," + y + "," + z + ") ");
                }
                System.Console.WriteLine(" ");
           } 
        } 
    }
}  