using System;

class Class1 {
    private static int i;
    private static bool flg;
    [STAThread]
    static void Main(string[] args) {
        Console.WriteLine(i);
        Console.WriteLine(flg);
    }
}
