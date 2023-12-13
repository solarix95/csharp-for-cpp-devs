/*************************************************************************************************\
|                                                                                                 |
|                              Value Types vs Reference Types                                     |
|                                                                                                 |
|                                                                                                 |
\*************************************************************************************************/

using System;

StructPoint p1 = new StructPoint(); // I know there are short forms! We're here still in "hello world" mode
p1.x = 7;
p1.y = 8;
StructPoint p11 = p1; // Deep Copy. C++: *p11 = *p1
p11.x = 8;
Console.WriteLine(p1);
Console.WriteLine(p11);

ClassPoint p2 = new ClassPoint(); 
p2.x = 7;
p2.y = 8;
ClassPoint p22 = p2; // Shallow Copy. C++: pointer1 = pointer2;
p22.x = 8;           // Now p2 is changed.. because its a reference to the same object
Console.WriteLine(p2);
Console.WriteLine(p22);

// But how to clone p2 and make a deep copy?
ClassPoint p23 = p2.Clone();
p23.x = 666;
Console.WriteLine(p2);
Console.WriteLine(p23);

/*
 My first "CS8803" Error.. 
 "In a file with top-level statements, top-level statements must occur prior to any type declarations."
 What? Why..?
*/
public struct StructPoint {
    public int x,y;

    public override String ToString() {
              return String.Format("StructPoint({0}/{1})",x,y);
    }

}

public class ClassPoint {
    public int x,y;

    public override String ToString() {
              return String.Format("ClassPoint({0}/{1})",x,y);
    }

    public ClassPoint Clone() {
        return (ClassPoint)this.MemberwiseClone();
    }
}
