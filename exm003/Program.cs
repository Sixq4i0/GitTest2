﻿Console.Clear();
int xa = 1, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;


Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
    int w = new Random().Next(0,3);
    if (w == 0)
    {
      x = (x + x) / 2;
      y = (y + y) / 2;  
    }
    
    if (w == 1)
    {
        
    }
    
    if (w == 2)
    {
        
    }
}

