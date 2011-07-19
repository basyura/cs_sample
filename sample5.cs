using System;

//public class Test {
public struct Test {
    public int v;
}

class Class1 {
    [STAThread]
    static void Main(string[] args) {
        Console.WriteLine(DateTime.Now);
        int count = 10000000;
        Test[] test = new Test[count];
        for (int i = 0 ; i < count ; i++) {
            //test[i] = new Test();
            test[i].v = i;
        }
        int sum = 0;
        for (int i = 0 ; i < count ; i++) {
            sum += test[i].v;
        }
        Console.WriteLine(DateTime.Now);
    }
}
