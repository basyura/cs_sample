using System;

class Hi {
}

class Class1 {
    static void Main(string[] args) {
        Console.WriteLine("{0}" , (1 is int));
        Hi hi = new Hi();
        Console.WriteLine("{0}" , (hi is Hi));
    }
}
