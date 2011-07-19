using System;

namespace Namespace1 {
    public class Class1 {
        public static void hello() {
            Console.WriteLine("Namespace1 の Class1 の hello()");
        }
        public static void test() {
            hello();
            Class1.hello();
            Namespace1.Class1.hello();
            Namespace2.Class1.hello();
        }
        [STAThread]
        static void Main(string[] args) {
            Namespace1.Class1.test();
            Namespace2.Class1.test();
        }
    }
}
namespace Namespace2 {
    class Class1 {
        public static void hello() {
            Console.WriteLine("Namespace2 の Class1 の hello()");
        }
        public static void test() {
            hello();
            Class1.hello();
            Namespace1.Class1.hello();
            Namespace2.Class1.hello();
        }
    }
}
