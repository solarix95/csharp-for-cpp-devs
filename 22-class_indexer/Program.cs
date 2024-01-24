

//-------------------------------------------------------------------------------------------------
var myInst = new MyClass();

for (int i=0; i<myInst.Size; i++)
    Console.WriteLine(myInst[i]);

//-------------------------------------------------------------------------------------------------
class MyClass {
    private string[] words = "Trying to fix a bug in this code is like trying to find a needle in a stack overflow".Split(" ");

    public int Size 
        => words.Length;
    
    public string this[int i] {
        get { return words[i]; }
    }
}