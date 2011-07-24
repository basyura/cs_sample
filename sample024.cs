using System;

class Class2 {
    private int number;
    public string Order {
        get {
            switch (number) {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                default :
                    return "unknown";
            }
        }
        set {
            switch (value) {
                case "one":
                    number = 1;
                    break;
                case "two":
                    number = 2;
                    break;
                case "three":
                    number = 3;
                    break;
                default :
                    number = -1;
                    break;
            }
        }
    }
}
class Class1 {
    static void Main(string[] args) {
        Class2 t = new Class2();
        t.Order = "one";
        Console.WriteLine(t.Order);
    }
}
