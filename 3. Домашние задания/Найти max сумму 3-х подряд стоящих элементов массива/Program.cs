using System.Diagnostics;

int[] array = 10000000.Create()
                .Fill(1, 10);
//array.ConvertToStringAndPrintToTerminal();

int m = 100; 
Stopwatch sw = new Stopwatch();
sw.Start();
int max = array.BadGetSum(m);
sw.Stop();
Console.WriteLine($"BadGetSum: {max} => {sw.ElapsedMilliseconds }");
 

sw.Reset();
sw.Start();
max = array.GoodGetSum(m);
sw.Stop();
Console.WriteLine($"GoodGetSum: {max} => {sw.ElapsedMilliseconds}");