// http://www.atmarkit.co.jp/fdotnet/csharp_abc2/csabc2_020/cs2_020_02.html
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute {
    private string _name;
    private string _organization;
    public AuthorAttribute(string name) {
        _name = name;
        _organization = "(no organization)";
    }
    public string name {
        get {return _name;}
    }
    public string organization {
        get {return _organization;}
        set {_organization = value;
    }
    [Author("Ichiro" , organization="The Program Company")]
    class Sample1 {
    }
    [Author("Jiro")]
    class Sample2 {
    }
    [Author("Saburo" , organization="The SoftwareGroup")]
    class Class1 {
        public static void dumpAuthor(string className) {
            Type type = Type.GetType(className);
            object[] list = type.GetCustomAttributes(typeof(AuthorAttribute),false);
            foreach(AuthorAttribute item in list) {
            Console.WriteLine("class {0} is written by {1} in {2}." ,
                className , item.name , item.organization);
            }
        }
        static void Main(string[] args) {
            dumpAuthor("Sample1");
            dumpAuthor("Sample2");
            dumpAuthor("Class1");
        }
    }
}
