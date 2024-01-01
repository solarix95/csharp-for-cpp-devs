
// Example using decimal
decimal decimalNumber = 0.1m;
for (int i = 0; i < 10; i++) {
    decimalNumber += 0.1m;
}

Console.WriteLine("Using decimal: " + decimalNumber);  // "1.1"

// Example using double
double doubleNumber = 0.1;
for (int i = 0; i < 10; i++) {
    doubleNumber += 0.1;
}

Console.WriteLine("Using double: " + doubleNumber);   // "1.0999999999999999"

