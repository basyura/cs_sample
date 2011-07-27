using System;
using System.Diagnostics;

class Class1 {
    [Conditional("DEBUG")]
    private void test() {
        Console.WriteLine("test called");
    }
    [STAThread]
    static void Main(string[] args) {
        Class1 instance = new Class1();
        Console.WriteLine("call start");
        instance.test();
        Console.WriteLine("call end");
    }
}
