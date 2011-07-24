using System;
using System.Collections;

class ClassMyEnumerator : IEnumerator {
    private int pointer;
    string[] target;
    object IEnumerator.Current {
        get { return target[pointer]; }
    }
    bool IEnumerator.MoveNext() {
        if (pointer >= target.GetUpperBound(0)) {
            return false;
        }
        pointer++;
        return true;
    }
    void IEnumerator.Reset() {
        pointer = target.GetLowerBound(0) - 1;
    }
    public ClassMyEnumerator(string[] array) {
        target  = array;
        pointer = target.GetLowerBound(0) - 1;
    }
}
class ClassSample : IEnumerable {
    string[] ar = {"ABC" , "DEF" , "GHI"};
    IEnumerator IEnumerable.GetEnumerator() {
        return new ClassMyEnumerator(ar);
    }
}
class Class1 {
    static void Main(string[] args) {
        ClassSample c = new ClassSample();
        foreach(string s in c) {
            Console.WriteLine(s);
        }
    }
}
