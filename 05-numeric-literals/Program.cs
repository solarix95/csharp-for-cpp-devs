
var x = 1.0;
Console.WriteLine(    x.GetType());

Console.WriteLine(    1.0.GetType());   // Double
Console.WriteLine(    1.0F.GetType());  // Float
Console.WriteLine(    1.0f.GetType());  // F/f ... same

Console.WriteLine(    1.0M.GetType());  // Decimal -> 10-base "double".. good for "manmade values" like "currency": https://csharpindepth.com/articles/Decimal
Console.WriteLine(    1.0m.GetType());  // M/m ... same

Console.WriteLine(             0.GetType());   // int32
Console.WriteLine(             1.GetType());   // int32
Console.WriteLine(    0xF0000000.GetType());   // uint32
Console.WriteLine(   0x100000000.GetType());   // int64
Console.WriteLine(            1L.GetType());   // int64
Console.WriteLine(           1UL.GetType());   // uint64
Console.WriteLine(           1ul.GetType());   // uint64

Console.WriteLine(   0x_9ABC.GetType());   // int32, HEX literal
Console.WriteLine(   0b_0111.GetType());   // int32, binary literal

// implicit cast of 32bit int literal to byte
byte aByte = 42; 
Console.WriteLine(   aByte.GetType()); 

var nInt = (nint)42; // native-sized integer.
Console.WriteLine(   nInt.GetType()); 
Console.WriteLine($"size of nint = {IntPtr.Size}");


