

var example = new Example();

Console.WriteLine(nameof(example));              // nameof... a variable
Console.WriteLine(nameof(example.aString));      // nameof... a member
Console.WriteLine(nameof(Example));              // nameof... a type

class Example {
    public Example() {
        aString = "Hello World";
    }
    public string aString;
}