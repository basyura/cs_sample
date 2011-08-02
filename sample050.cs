/*
 * http://www.atmarkit.co.jp/fdotnet/csharp_abc2/csabc2_020/cs2_020_03.html
 */
using System;

[Obsolete("Sample1 は今後サポートされません。Sample2 を使ってください。")]
class Sample1 {
}
class Sample2 {
}
class Class1 {
    static void Main(string[] args) {
        Console.WriteLine(new Sample1());
    }
}
