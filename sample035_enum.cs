using System;

enum Era {
    Meiji ,
    Taisho ,
    Showa ,
    Heisei
}
class Class1 {
    static void WriteEra(Era t) {
        switch (t) {
            case Era.Meiji:
                Console.WriteLine("明治");
                break;
            case Era.Taisho:
                Console.WriteLine("大正");
                break;
            case Era.Showa:
                Console.WriteLine("昭和");
                break;
            case Era.Heisei:
                Console.WriteLine("平成");
                break;
        }
    }
    static void Main(string[] args) {
        Era t = Era.Taisho;
        WriteEra(t);
        Console.WriteLine(t);
    }
}
