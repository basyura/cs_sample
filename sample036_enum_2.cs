using System;

enum Era {
    明治,
    大正,
    昭和,
    平成
}

class Class1 {
    static void Main(string[] args) {
        Era t = Era.大正;
        Console.WriteLine(t);

        string name = Era.GetName(Type.GetType("Era") , t);
        Console.WriteLine(name);

        string[] names = Era.GetNames(Type.GetType("Era"));
        foreach (string s in names) {
            Console.WriteLine(s);
        }
    }
}
