

static void callByValue(int v) { // C++ callByValue(int v)
    v = 23;
}

static void callByRef(ref int v) { // C++ callByRef(int &v)
    v = 23;
}

static void callByOut(out int v) { // C++ callByOut(int *v) (optional Reference.. in C++ a pointer with default "nullptr")
    v = 23;
}

static void callByIn(in int v) { // C++ callByIn(const int &v)
    // v = 23; Compile Error -> v is "const"
}

static void callByParams(out string s, params string[] parts) {
    s = "";
    for (int i=0; i<parts.Length; i++) {
        s += parts[i] + " ";
    }
    s = s.Trim();
}

int x = 1;
Console.WriteLine($"Before callByValue: {x}");
callByValue(x);
Console.WriteLine($"After callByValue: {x}");

Console.WriteLine($"Before callByRef: {x}");
callByRef(ref x);
Console.WriteLine($"After callByRef: {x} (changed)");

x = 1;
Console.WriteLine($"Before callByOut: {x}");
callByOut(out x);
Console.WriteLine($"After callByOut: {x}");

callByOut(out int x2);
Console.WriteLine($"callByOut created new variable x2: {x}");

Console.WriteLine($"callByOut without parameter");
callByOut(out _);

x = 1;
Console.WriteLine($"Before callByIn: {x}");
callByIn(in x);
Console.WriteLine($"After callByIn: {x}");

callByParams(out string result, "one", "two", "three");
Console.WriteLine($"Params: {result}");