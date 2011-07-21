using System;

class Class2 {}

class Class3 : Class2 {}

class Class1 {
    [STAThread] 
    static void Main(string[] args) {
        object instance1 = new Class3();
        Console.WriteLine(instance1);

        Class2 instance2 = instance1 as Class2;
        Console.WriteLine(instance2);

        Class2 instance3 = (Class2)instance1;
        Console.WriteLine(instance3);

        Class1 instance4 = instance1 as Class1;
        Console.WriteLine(instance4);

        Class1 instance5 = (Class1)instance1;
        Console.WriteLine(instance5);
    }
}
