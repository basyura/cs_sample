using System;

class Class2 {
    public string str;
    public Class2( string s) { str = s; }
    public static Class2 operator -(Class2 x) {
        return new Class2("-" + x.str);
    }
    public static Class2 operator +(Class2 x , Class2 y) {
        return new Class2( x.str + "+" + y.str);
    }
    public static Class2 operator -(Class2 x , Class2 y) {
        return new Class2(x.str + "-" + y.str);
    }
}

class Class1 {
    static void Main(string[] args) {
        Class2 a = new Class2("Hello");
        Class2 b = new Class2("World");
        Class2 c = a + b;
        Console.WriteLine(c.str);

        Class2 d = -c;
        Console.WriteLine(d.str);

        Console.WriteLine((a - b).str);
    }
}
