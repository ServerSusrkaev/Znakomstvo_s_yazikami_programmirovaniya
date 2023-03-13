Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa = 30, ya = 1,
    xb = 1, yb = 25,
    xc = 60, yc = 25; 

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb,  yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;
int index = 0;

while (index < 5000) {
    int position = new Random().Next(0,3); //[0;3] - 0,1,2
    
    if (position == 0) 
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (position == 1) 
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (position == 2) 
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
index++;
}
