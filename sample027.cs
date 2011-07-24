using System;

interface ISample1 {
    void task();
}
interface ISample2 {
    void task();
}
class Class2 : ISample1 {
    public void task() {
        Console.WriteLine("task() in class2 called");
    }
}
class Class3 : ISample1 , ISample2 {
    void ISample1.task() {
        Console.WriteLine("ISample1.task() in class3 called");
    }
    void ISample2.task() {
        Console.WriteLine("ISample2.task() in class3 called");
    }
}
class Class1 {
    static void Main(string[] args) {
        Class2 c2 = new Class2();
        c2.task();
        Class3 c3 = new Class3();
        ISample1 i1 = (ISample1)c3;
        i1.task();
        ISample2 i2 = (ISample2)c3;
        i2.task();
    }
}
