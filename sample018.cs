
using System;
using System.Collections;
using System.Text;
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
        Console.WriteLine(p.GetType());
        Console.WriteLine(p);
        Console.WriteLine(((Person)p).name);
        foreach (FieldInfo f in t.GetFields()) {
            Console.WriteLine(f);
        }
        Console.WriteLine(t.GetField("pname").GetValue(p));


        FieldInfo finfo = t.GetField("name_" , 
                                BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(finfo.GetValue(p));
        Console.WriteLine(t.InvokeMember(
                            "name_" , 
                            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.GetField,
                            null , p , null));

        Object say_ret = t.InvokeMember(
                            "say" , 
                            BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod , 
                            null , p , null);
        Console.WriteLine(say_ret);


        String msg2 = "hello";
        Console.WriteLine(msg2);

        IList list = new ArrayList();
        list.Add("a");
        list.Add("b");
        list.Add("c");

        foreach (String msg in list) {
            Console.WriteLine(msg);
        }

        ArrayList list2 = new ArrayList();
        list2.Add("a2");
        list2.Add("b2");
        list2.Add("c2");


        for (int i = 0 ; i < list2.Count ; i++) {
            Console.WriteLine(list2[i]);
        }

        IDictionary hash = new Hashtable();
        hash.Add("a" , "A");
        hash.Add("b" , "B");

        foreach (DictionaryEntry o in hash) {
            Console.WriteLine(o.Key);
            Console.WriteLine(o.Value);
        }

        StringBuilder buf = new StringBuilder();
        buf.Append("a");
        buf.Append("b");
        buf.Append("c");
        buf.Append("d");
        Console.WriteLine(buf.ToString());
        
    }
}

