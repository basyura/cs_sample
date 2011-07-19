using System;

class Class1 {
    public String hello;
    static void Main(string[] args) {
        Class1 c = new Class1();
        c.hello = "Hello!";
        object o = (object)c;
        Class1 c2  = (Class1)o;
        Console.WriteLine("{0},{1}" , c.hello , c2.hello);
    }
}
