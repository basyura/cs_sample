using System;

class Class1{
    static void Main(string[] args) {
        char[] ar1 = {'A' , 'B' , 'C'};
        foreach (char c in ar1) {
            Console.WriteLine(c);
        }
        string s = new string(ar1);
        Console.WriteLine(s);
        char[] ar2 = s.ToCharArray();
        foreach (char c in ar2) {
            Console.WriteLine(c);
        }
    }
}
