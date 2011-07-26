using System;
using System.Collections.Generic;
using System.Collections;

// http://d.hatena.ne.jp/ogatatsu/20110725/1311590830
class Class1 {
    static void Main(string[] args) {
        IEnumerable<int> emu = func(true);
        IEnumerator e = emu.GetEnumerator();
        while(e.MoveNext()) { 
            Console.WriteLine(e.Current);
        }
    }

    static IEnumerable<int> func(bool b) {
        yield return 1;
        Console.WriteLine("a");
        yield return 2;
        Console.WriteLine("b");
        if (b) {
            yield return 3;
            Console.WriteLine("c");
            yield return 4;
            Console.WriteLine("d");
        }
        yield return 5;
        Console.WriteLine("e");
    }
}
