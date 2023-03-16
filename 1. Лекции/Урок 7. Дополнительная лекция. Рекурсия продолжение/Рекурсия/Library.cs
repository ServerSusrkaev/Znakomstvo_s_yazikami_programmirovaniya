public class Library
{
    public static string NumberCount (int a, int b)
    {
        if (a <= b) return  NumberCount(a + 1, b) + $"{a} ";
        else return String.Empty;
    }
}