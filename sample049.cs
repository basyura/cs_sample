using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class SampleAttribute : Attribute {
    public SampleAttribute(){
    }
}

[Sample]
class Sample1 {
}

[SampleAttribute]
class Sample2 {
}

class Class1 {
    public static void dumpAuthor(string className) {
        Type type = Type.GetType(className);
        object[] list = type.GetCustomAttributes(typeof(SampleAttribute),false);
        if (list.Length > 0) {
            Console.WriteLine("class {0} has SampleAttribute attribute" , className);
        }
    }
    [STAThread]
    static void Main(string[] args) {
        dumpAuthor("Sample1");
        dumpAuthor("Sample2");
        dumpAuthor("Class1");
    }
}
