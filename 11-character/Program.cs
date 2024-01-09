
Console.WriteLine($"In C#, a character has {sizeof(char)} byte(s)"); // in C# a characted represents a UTF-16 character (2 Bytes)


char newline   = '\n';       // as in C++
char copyright = '\u00a9';   // Unicode character

Console.WriteLine("Line1" + newline + "Line2");
Console.WriteLine($"Copyright {copyright}");
