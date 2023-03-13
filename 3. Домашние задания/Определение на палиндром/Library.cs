public class Library
{   
    public static void FillArray(int[] arr, string txtNum)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(txtNum[i].ToString());
        }
    }
}