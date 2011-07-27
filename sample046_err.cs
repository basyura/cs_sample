using System;

class Class1 {
    static void Main(string[] args) {
        int[] array = {1,2,3,4,5,6};
        foreach (int n in array) {
            try {
                if (n == 3) break;
                Console.WriteLine(n);
            } 
            finally {
                Console.WriteLine(n + "の終了処理が呼び出されました。(その１)");
            }
        }
        foreach (int n in array) {
            try {
                if (n == 3) return;
                Console.WriteLine(n);
            }
            finally {
                Console.WriteLine(n + "の終了処理が呼び出されました。(その２)");
            }
        }
    }
}
