char[] s = {'a', 'и', 'с', 'в'};
int count  = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++, -5}{s[i]}");
}