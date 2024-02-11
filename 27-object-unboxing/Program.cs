// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

SimpleStack stack = new SimpleStack(10);

stack.Push("Hello World"); // Boxing a string-reference to a object -> implicit..
stack.Push(1);
stack.Push(true);

while (stack.Count > 0) {
    Console.WriteLine($"Stack-State: {stack.Count}/{stack.Size}");
    Object next = stack.Pop();
    switch (next) {
        case string s:
            Console.WriteLine($"It's a string: {s}");
            break;
        case int i:
            Console.WriteLine($"It's a int: {i}");
            break;   
        case bool b:
            Console.WriteLine($"It's a bool: {b}");
            break; 
    }
}

class SimpleStack {

    public SimpleStack(int size) {
        Debug.Assert(size > 0);
        mStack = new object[size];
        mCurrentPosition = -1;
    }

    public void Push(Object o) {
        Debug.Assert(mCurrentPosition < (mStack.Length-1));
        mStack[++mCurrentPosition] = o;
    }

    public Object Pop() {
        Debug.Assert(mCurrentPosition >= 0);
        return mStack[mCurrentPosition--];
    }

    public int Count { get { return mCurrentPosition+1; }}
    public int Size  { get { return mStack.Length; } }

    private int      mCurrentPosition;
    private Object[] mStack;
}

    