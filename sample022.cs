using System;

class Class2 {
    static Class2() {
        Console.WriteLine("static Class2() called");
    }
    ~Class2() {
        Console.WriteLine("Class2's destructor called");
    }
    public Class2() {
        Console.WriteLine("constructor");
    }
    static public void special() {
        Console.WriteLine("static public special() called");
    }
}
class Class1 {
    static void Main(string[] args) {
        Class2.special();
        new Class2();
    }
}
