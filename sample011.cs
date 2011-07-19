using System;

class Class1 {
    static void Main(string[] args) {
        sbyte b = 123;
        short s = b;
        int   i = s;
        long  l = i;
        Console.WriteLine("{0},{1},{2},{3}" , b , s , i , l);
    }
}
