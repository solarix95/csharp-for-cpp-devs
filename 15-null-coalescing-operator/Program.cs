


string ?s1 = null;                        // nullable reference
string s2  = s1 == null ? "is null" : s1; // as in cpp
Console.WriteLine($"s1 {s2} (variant 1)");


string s3  = s1 ?? "is null"; // null coalescing operator
Console.WriteLine($"s1 {s2} (variant 2)");

string s4  = s1 == null ? "is null" : s1.ToUpper();
string s5  = s1?.ToUpper();
Console.WriteLine($"s5 {s5 ?? "is null"} (by conditional operator)");
Console.WriteLine($"s4 {s4 ?? "is null"} (by elvis operator)");

int ?length = s1?.Length; // if s1 is null, expression returns "null" and sets nullable int to null :D
Console.WriteLine($"s1 length: {(length != null ? length : 0)}");
