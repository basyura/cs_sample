using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute {
    private string _name;
    public AuthorAttribute(string name) {
        _name = name;
    }
    public string name {
        get { return _name; }
    }
}
[Author("Ichiro")]
class Sample1 {
}

[Author("Jiro")]
class Sample2 {
}

[Author("Saburo")]
class Class1 {
    public static void dumpAutor(string className) {
        Type type = Type.GetType(className);
        object[] list = type.GetCustomAttributes(typeof(AuthorAttribute),false);
        foreach (AuthorAttribute item in list) {
            Console.WriteLine("class {0} is written by {1}" , className , item.name);
        }
    }
    [STAThread]
    static void Main(string[] args) {
        dumpAutor("Sample1");
        dumpAutor("Sample2");
        dumpAutor("Class1");
    }
}
