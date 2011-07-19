using System;

public interface Person {
    string getName();
}

public class A {}

public class Taro : Person {
    public string getName() {
        return "my name is taro.";
    }
}

class Class1 {
    [STAThread]
    static void Main(string[] args) {
        Taro taro = new Taro();
        Console.WriteLine(taro.getName());
        Person someone = new Taro();
        Console.WriteLine(someone.getName());
    }
}
