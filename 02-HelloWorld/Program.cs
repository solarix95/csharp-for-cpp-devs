/*************************************************************************************************\
|                                                                                                 |
|                        Classic Hello-World - Including main-body                                |
|                                                                                                 |
|                                                                                                 |
\*************************************************************************************************/

using System;

class Program {
    static int Main(string [] args)
    {
        Console.WriteLine("Hello, World #2!");
    
        if (args.Length > 0)
            Console.WriteLine("Argument Count: {0}", args.Length);
        else   
            Console.WriteLine("No arguments given.");

        return 0; // the Programs exit value... as in... all programming language :)
    }
}
