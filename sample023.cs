using System;

namespace Sample001 {
    class Class2 {
        private char [] a = {'A' , 'B' , 'C'};
        public char this[int index] {
            get { return a[index];  }
            set { a[index] = value; }
        }
    }
    class Class1 {
        static void Main(string[] args) {
            Class2 t = new Class2();
            for (int i = 0 ; i < 3 ; i++) {
                Console.WriteLine(t[i]);
            }
            t[0] = 'X';
            t[1] = 'Y';
            t[2] = 'Z';
            for (int i = 0 ; i < 3 ; i++) {
                Console.WriteLine(t[i]);
            }
        }
    }
}
