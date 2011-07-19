using System;

class Class1 {
    static void Main(string[] args) {
        float a = 0.3f;
        float b = 0.1f;
        float c = a - b;
        Console.WriteLine("{0}" , c); //=> 0.2

        decimal a2 = 0.3m;
        decimal b2 = 0.1m;
        Console.WriteLine("{0}" , a2 - b2); //=> 0.2
    }
}
