
static bool testAndReset() {
    Console.WriteLine("Reset");
    return false;
}

bool a = true;
bool b = false;


Console.WriteLine((a == b) == true);
Console.WriteLine((a != b) == false);

// Shortcut
Console.WriteLine(testAndReset() && testAndReset()); // 1x "Reset"

// No shortcut
Console.WriteLine(testAndReset() & testAndReset());  // 2x "Reset"

// Condition Operator
Console.WriteLine(a ? "TRUE" : "FALSE");
Console.WriteLine(b ? "TRUE" : "FALSE");
