using System;
using System.Text;

class Class1 {
    static void Main(string[] args) {
        string a = "hello";
        String b = "hello";

        StringBuilder buf = new StringBuilder();
        buf.Append("h");
        buf.Append("ello");
        String c = buf.ToString();

        print(a.GetType());
        print(b.GetType());

        print(a == b);
        print(b == a);

        print(a.Equals(b));
        print(b.Equals(a));
        print(Object.ReferenceEquals(a , b));

        print(a == c);
        print(Object.ReferenceEquals(a , c));
    }
    private static void print(Object obj) {
        Console.WriteLine(obj);
    }
}
