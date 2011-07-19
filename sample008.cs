using System;

namespace Sample008 {
    class Class1 {
        [STAThread]
        static void Main(string[] args) {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding("Shift_JIS");
            Console.WriteLine(encoding.GetByteCount("A"));
            Console.WriteLine(encoding.GetByteCount("あ"));
            // 該当する文字コードがないので ? が変える
            Console.WriteLine(encoding.GetByteCount("\x4e02"));
            encoding = System.Text.Encoding.GetEncoding("UTF-8");
            Console.WriteLine(encoding.GetByteCount("A"));
            Console.WriteLine(encoding.GetByteCount("あ"));
            Console.WriteLine(encoding.GetByteCount("\x4e02"));

        }
    }
}
