using System;

delegate int Sample(int x , int y);

class Class2 {
    public static int methodMult(int x , int y) {
        return x * y;
    }
    public static int methodPlus(int x , int y) {
        return x + y;
    }
}
class Class1 {
    public static void calc(int x , int y , Sample calcMethod) {
        int result = calcMethod(x , y);
        Console.WriteLine(result);
    }
    static void Main(string[] args) {
        calc(2 , 3 , new Sample(Class2.methodMult));
        calc(2 , 3 , new Sample(Class2.methodPlus));
    }
}
