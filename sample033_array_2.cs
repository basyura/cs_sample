using System;

class Class1 {
    static public int[] makeArray(bool select) {
        if (select) {
            int[] ar = {0,1,2,3};
            return ar;
        }
        else {
            int[] ar = {0,1};
            return ar;
        }
    }
    static public void dumpArray(int[] ar) {
        foreach(int n in ar) {
            Console.WriteLine(n);
        }
    }
    static void Main(string[] args) {
        int[] ar = makeArray(false);
        dumpArray(ar);
        Console.WriteLine();
        ar = makeArray(true);
        dumpArray(ar);
    }
}
