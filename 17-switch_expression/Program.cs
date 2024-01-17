

using System.Security.Cryptography;

string ToString(int i) {
    return i switch {
        23  => "a mystical number",
        42  => "the answer to life, the universe and everything",
        187 => "MDK - murder,death,kill",
        _ => $"{i}"
    };
}

Console.WriteLine(ToString(1));
Console.WriteLine(ToString(11));
Console.WriteLine(ToString(23));
Console.WriteLine(ToString(42));
Console.WriteLine(ToString(187));
Console.WriteLine(ToString(666));