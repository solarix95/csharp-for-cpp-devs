

//-------------------------------------------------------------------------------------------------
var myInst = new MyClass("D4gobert", "Duçk");

// (var name, var surname) = myInst;
var (name,surname) = myInst;

Console.WriteLine($"Deconstructed: {name} {surname}");



//-------------------------------------------------------------------------------------------------
class MyClass {
    public MyClass(string name, string surname) {
        mName = name;
        mSurname = surname;
        Console.WriteLine($"CTor: {mName} {mSurname}");
    }

    public void Deconstruct(out string n, out string sn) {
        n = mName;
        sn = mSurname;
        Console.WriteLine($"DCTor: {mName} {mSurname}");
    }

    private string mName;
    private string mSurname;
}