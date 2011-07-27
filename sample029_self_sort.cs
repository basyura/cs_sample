using System;
using System.Collections;

class ClassSample : IComparable {
    public string number;
    public int CompareTo(object obj) {
        string s = ((ClassSample)obj).number;
        if (number == "one"   && s == "two")   return -1;
        if (number == "one"   && s == "three") return -1;
        if (number == "two"   && s == "one")   return  1;
        if (number == "two"   && s == "three") return -1;
        if (number == "three" && s == "one")   return  1;
        if (number == "three" && s == "two")   return  1;
        return 0;
    }
    public ClassSample(string s) {
        number = s;
    }
}
class Class1 {
    [STAThread]
    static void Main(string[] args) {
        ArrayList list = new ArrayList();
        list.Add(new ClassSample("two"));
        list.Add(new ClassSample("three"));
        list.Add(new ClassSample("one"));
        list.Sort();
        foreach (ClassSample cs in list) {
            Console.WriteLine(cs.number);
        }
    }
}
