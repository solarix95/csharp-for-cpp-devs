

int a = 1000000, b = 1000000;

Console.WriteLine("Unchecked operation");
int c = a * b; // Overflow (as in C++)
Console.WriteLine(c);

Console.WriteLine("Cecked operation");
try {
    int d = checked(a*b);
    Console.WriteLine(d); // we'll never reach this point..
}
catch (OverflowException e) {
    Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
}

// Also nice for checked casts:
Console.WriteLine("Unchecked operation");
double f = double.MaxValue;
int g = (int)f;
Console.WriteLine(g);  // output: -2147483648

Console.WriteLine("Checked operation");
try {
    int h = checked((int)f);
    Console.WriteLine(h); // we'll never reach this point..
}
catch (OverflowException e) {
    Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
}

// unchecked for checked bodies

Console.WriteLine("Unchecked operation in checked body");
checked {
    int x = 1000000, y = 1000000;
    // int z = x * y; // would throw an exception
    int z = unchecked(x*y);
    Console.WriteLine(z);
}