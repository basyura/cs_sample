using System; 

class Class1 {
    private static void sample1(int x) {
        x++;
    }
    private static void sample2(ref int x) {
        x++;
    }
    private static void sample3(out int x) {
        x = 123;
    }
    [STAThread]
    static void Main(string[] args) {
        int a = 0;
        int b;
        sample1(a);
        sample1(1);
        Console.WriteLine(a);

        int c = 0 , d;
        sample2(ref c);
        Console.WriteLine(c);

        int e = 0 , f;
        sample3(out e);
        sample3(out f);
        Console.WriteLine(e);
        Console.WriteLine(f);
    }
}
