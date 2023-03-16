static uint Akkerman(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}
 
Console.WriteLine("m = 2; n = 3 -> " + Akkerman(2, 3));
Console.WriteLine("m = 3; n = 2 -> " + Akkerman(3, 2));