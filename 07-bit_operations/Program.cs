
// Ok this is boring... same as in C++

int a = 0x01;
int b = 0x02;
int c = 0x03;

Console.WriteLine(a | b);  // 3
Console.WriteLine(a & c);  // 1
Console.WriteLine(c & ~a); // 2

Console.WriteLine(0x20 << 1); // 32 * 2 = 64
Console.WriteLine(0x20 >> 1); // 32 / 2 = 16

Console.WriteLine(0xff00 ^ 0x0ff0); // XOR: 0xf0f0