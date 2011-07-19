using System;

namespace Sample001 {
    public class TestClass : ICloneable {
        public int n;
        public object Clone() {
            return MemberwriseClone();
        }
    }
    public struct TestStruct {
        public int n;
    }
    class Class1 {
        [STAThread]
        static void Main(string[] args) {
            int testInt1 = 123;
            int testInt2 = testInt1;
            testInt1 = 456;
            Console.WriteLine("Answer1 testInt1={0}, testInt2={1}" , testInt1 , testInt2);
            TestClass testClass1 = new TestClass();
            TestClass testClass2 = new TestClass();
            testClass1.n = 123;
            testClass2.n = testClass1.n;
            testClass1.n = 456;
            Console.WriteLine("Answer2 testInt1={0}, testInt2={1}" , testClass1.n , testClass2.n);
        }
    }
}
