
var values = new double[5];

for (int i=0; i<values.Length; i++)
    values[i] = i;

for (int i=0; i<values.Length; i++)
    Console.WriteLine(values[i]);

values = new double[] {5,6,7,6,8,9};
foreach(var value in values)
    Console.WriteLine(value);

Console.WriteLine("--------------------------------");
double[] values2 = {10,11,12,13,14,15};
foreach(var value in values2)
    Console.WriteLine(value);

Console.WriteLine("--------------------------------");
double[] valueReference = values;
valueReference[0] = 99;
Console.WriteLine(valueReference[0]);
Console.WriteLine(values[0]);

valueReference = (double[])values.Clone(); // now not pointing to the same object.. same as "memcpy()" in C
valueReference[0] = 100;
Console.WriteLine(valueReference[0]);
Console.WriteLine(values[0]);

// Indices
Console.WriteLine("--------------------------------");
values[^1] = 999;
values[^2] = 998;
foreach(var value in values)
    Console.WriteLine(value);

Console.WriteLine("--------------------------------");
Index last = ^1;
values[last] = 1000;
foreach(var value in values)
    Console.WriteLine(value);

Console.WriteLine("--------------------------------");
double[] head = values[..3];
for (int i=0; i<head.Length; i++)
    head[i] = i;

// "head" is a copy.. not a reference to a sub-Array:
foreach(var value in head)
    Console.WriteLine(value);
foreach(var value in values)
    Console.WriteLine(value);

Console.WriteLine("--------------------------------");
Range lastTwoValues = ^2..^0;
double[] tail = values[lastTwoValues];
foreach(var value in tail)
    Console.WriteLine(value);

    