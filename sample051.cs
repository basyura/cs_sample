/*
 * http://www.atmarkit.co.jp/fdotnet/csharp_abc2/csabc2_020/cs2_020_03.html
 */

using System;
using System.Runtime.InteropServices;

class Class1 {
    [DllImport("user32.dll")]
    public static extern int MessageBeep(uint uType);

    [STAThread]
    static void Main(string[] args) {
        MessageBeep(0);
    }
}
