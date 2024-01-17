/*
     C# provides CPP-Standard switch case..
     .... but ...:
*/


void typeSwitchDemo(object printMe) {
    switch (printMe) {
        case int answer when answer == 42:
            Console.WriteLine("The answer to life, the universe, and everything");
            break;
        case int i:
            Console.WriteLine($"Int Value is {i}");
            break;
        case string s:
            Console.WriteLine($"String Value is \"{s}\"");
            break;
        case bool enabled:
            Console.WriteLine($"flag is {(enabled ? "enabled":"disabled")}");
            break; 
    }
}


typeSwitchDemo(23);
typeSwitchDemo(42);
typeSwitchDemo("As a CPP programmer... I'm jealous..");
typeSwitchDemo(true);
typeSwitchDemo(false);