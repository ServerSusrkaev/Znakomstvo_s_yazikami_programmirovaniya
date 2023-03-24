// Это класс отвечающий за создание массива.
public static class ArrayCreator
{
    public static int[] Create(this int n)
    {
        
        return new int[n];
    }

    public static string ConvertToStringAndPrintToTerminal(this int[] array)
    {
    string str = $"[{String.Join(',', array)}]";
    System.Console.WriteLine(str);
    return str;
    }

    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0? new Random(): new Random(seed);
        if (seed == 0) random = new Random();
        else random = new Random(seed);
        return array = array.Select(item => Random.Shared.Next(min, max)).ToArray();
    }
}