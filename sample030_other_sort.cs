using System;
using System.Collections;

class ClassComparer : IComparer {
    public int Compare(object x , object y) {
        double dx = (double)x;
        double dy = (double)y;
        return (int)dx - (int)dy;
    }
}
class Class1 {
    static void Main(string[] args) {
        ArrayList list = new ArrayList();
        list.Add(2.2);
        list.Add(3.7);
        list.Add(1.5);
        list.Add(2.7);
        list.Add(3.2);
        list.Add(1.1);
        list.Sort(new ClassComparer());
        foreach (double d in list) {
            Console.WriteLine(d);
        }
    }
}
