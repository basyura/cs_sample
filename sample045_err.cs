using System;
using System.IO;
using System.Text;

class Class1 {
    static void Main(string[] args) {
        try {
            StreamReader reader = new StreamReader("存在しない.txt" , 
                                                   Encoding.GetEncoding("Shift_JIS"));
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        } catch (FileNotFoundException e) {
            Console.WriteLine("ファイル" + e.FileName + "が見つかりません");
        } finally {
            Console.WriteLine("終了");
        }
    }
}
