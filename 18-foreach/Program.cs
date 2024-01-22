Console.WriteLine("FOREACH Examples");

// in strings
foreach(char c in "Hello")
    Console.WriteLine(c);

// in arrays
var primes = new int[]{ 2, 3, 5, 7, 11, 13};
foreach(int prime in primes)
    Console.WriteLine(prime);

// Lists
var names = new List<string> { "Alice", "Bob", "Charlie" };
foreach(var name in names)
    Console.WriteLine(name);

// and other "IEnumerable".. but that's another bedtime story