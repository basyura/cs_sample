using System;

class Test1 {
    public int x = 1;
    public Test1() {
        Console.WriteLine(x);
    }
}
class Test2 {
    public int x;
    public Test2() {
        Console.WriteLine(x);
        x = 2;
        Console.WriteLine(x);
    }
}
class Test3 {
    public int x = 1;
    public Test3() {
        Console.WriteLine(x);
        x = 2;
        Console.WriteLine(x);
    }
}
class Class1 {
    [STAThread]
    static void Main(string[] args) {
        Test1 t1 = new Test1();
        Test2 t2 = new Test2();
        Test3 t3 = new Test3();
    }
}
