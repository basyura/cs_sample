using System;
using System.Globalization;

class ClassSample : IFormattable {
    public int x;
    public string ToString(string format , IFormatProvider formatProvider) {
        if (formatProvider is CultureInfo) {
            CultureInfo ci = (CultureInfo)formatProvider;
            if (ci.Name == "ja-JP") {
                switch(x) {
                    case 1:
                        return "一";
                    case 2:
                        return "二";
                    case 3:
                        return "三";
                }
            }
        }
        return x.ToString();
    }
}
class Class1 {
    static void Main(string[] args) {
        ClassSample cs = new ClassSample();
        cs.x = 4;
        Console.WriteLine(cs);
    }
}
