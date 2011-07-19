using System;

public struct St1 {}

class Class1 {
    static void Main(string[] args) {
        object[] test = new object[5];
        test[0] = (int)1;
        test[1] = (float)0.1;
        test[2] = (string)"hello";
        test[3] = new St1();
        test[4] = new Class1();
        for (int i = 0 ; i < 5 ; i++) {
            Console.WriteLine("Class={0}, Value={1}" , test[i].GetType().FullName , test[i].ToString());
        }
    }
}
