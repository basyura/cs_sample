using System;
using System.Reflection;

class Person {
    public  String pname = null;
    private String name_ = null;
    public Person(String name) {
        name_ = name;
        pname = "p_" + name;
    }
    public String name {
        get { return name_;}
    }
    public String say() {
        return "I'm " + name_;
    }
}

class Class1 {
    static void Main(string[] args) {
        Type   t = Type.GetType("Person");
        Object p = Activator.CreateInstance(t , new String[]{"basyura"});
        //Console.WriteLine(p.GetType());
        //Console.WriteLine(p);
        //Console.WriteLine(((Person)p).name);
        //foreach (FieldInfo f in t.GetFields()) {
            //Console.WriteLine(f);
        //}
        //Console.WriteLine(t.GetField("pname").GetValue(p));


        //FieldInfo finfo = t.GetField("name_" , 
                                //BindingFlags.NonPublic | BindingFlags.Instance);
        //Console.WriteLine(finfo.GetValue(p));
        //Console.WriteLine(t.InvokeMember(
                            //"name_" , 
                            //BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField,
                            //null , p , null));

        Object say_ret = t.InvokeMember(
                            "say" , 
                            BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod , 
                            null , p , null);
        Console.WriteLine(say_ret);
    }
    private static void puts(Object obj) {
        Console.WriteLine(obj);
    }
}
