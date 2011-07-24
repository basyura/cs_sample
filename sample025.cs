using System;

delegate int Sample(int x , int y);

class Class2 {
    public int method(int x , int y) {
        return x * y;
    }
}
class Class1 {
    static void Main(string[] args) {
        Class2 instance = new Class2();
        Sample sample = new Sample(instance.method);
        int result = sample(2 , 3);
        Console.WriteLine(result);
    }
}
