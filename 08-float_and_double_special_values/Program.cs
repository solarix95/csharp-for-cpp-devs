
/*

    NaN (Not a Number)
    PositiveInfinity
    NegativeInfinity
    -0

*/

// Infinity
Console.WriteLine ( 1.0 /  0.0);                  //  Infinity 
Console.WriteLine (-1.0 /  0.0);                  // -Infinity 
Console.WriteLine ( 1.0 / -0.0);                  // -Infinity 
Console.WriteLine (-1.0 / -0.0);                  //  Infinity

Console.WriteLine ( 0.0 /  0.0);                  //  NaN 
Console.WriteLine ((1.0 /  0.0) - (1.0 / 0.0));   //  Infinity - Infinity = NaN 

// Comparing NaN always false
Console.WriteLine (0.0 / 0.0 == double.NaN);                // False 
Console.WriteLine (object.Equals(0.0 / 0.0, double.NaN));   // True 
Console.WriteLine (double.IsNaN (0.0 / 0.0));               // True 

// Constants
Console.WriteLine (double.NegativeInfinity); 
Console.WriteLine (double.PositiveInfinity); 
Console.WriteLine (double.NegativeZero); 
Console.WriteLine (double.NaN);
