/*************************************************************************************************\
|                                                                                                 |
|                  Explicit/Implicit Conversion of simple data types                              |
|                                                                                                 |
|                                                                                                 |
\*************************************************************************************************/

using System;

int aInt     = 123456;
long aLong   = aInt;        // Implicit type conversion (as in C++)

short aShort = (short)aInt; // Explicit type conversion (as in C++)

Console.WriteLine("Type conversion results: {0} {1} {2}", aInt, aLong, aShort);

