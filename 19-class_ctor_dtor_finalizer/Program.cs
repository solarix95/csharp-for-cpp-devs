using System;

class MyClass : System.IDisposable
{
    // Constructor
    public MyClass(string fname, string ext)
    {
        mFilename = fname;
        mFileExtension = ext;

        Console.WriteLine("Constructor: Object created");
    }

    // Destructor (Finalizer)
    ~MyClass()
    {
        Console.WriteLine($"Destructor: Object {Name()} finalized ");
        Dispose(false);
    }

    // Finalizer
    public void Dispose()
    {
        Console.WriteLine($"Finalizer: Object {Name()} disposed");
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public string Name() {
        return $"{mFilename}.{mFileExtension}";
    }
    

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            // Clean up managed resources (if any)
            Console.WriteLine($"Dispose: Cleaning up managed resources of Object {Name()}");
        }

        // Clean up unmanaged resources (if any)
        Console.WriteLine($"Dispose: Cleaning up unmanaged resources of Object {Name()}");
    }

    private string mFilename;
    private string mFileExtension;
}

class Program
{
    static void Testcase1() {
        Console.WriteLine("Testcase1");
        MyClass myObject = new MyClass("hello","pdf");
        Console.WriteLine($"Constructed: {myObject.Name()}");
    }

    static void Testcase2() {
        Console.WriteLine("Testcase2");
         using(var myObject = new MyClass("world","exe")){ 
            Console.WriteLine($"Constructed: {myObject.Name()}");
        } // Dispose automatically called
    }
    static void Main()
    {
        Testcase1();
        Testcase2();

        // Force garbage collection to demonstrate the finalizer
        Console.WriteLine("GC Cleanup start");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        Console.WriteLine("GC Cleanup end -> end of program");
    }
}
