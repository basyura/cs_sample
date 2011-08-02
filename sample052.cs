/*
 * http://www.atmarkit.co.jp/fdotnet/csharp_abc2/csabc2_020/cs2_020_03.html
 */

using System;
using System.Runtime.InteropServices;

class Class1 {
    [DllImport("user32.dll" , CallingConvention=CallingConvention.Winapi,
        CharSet=CharSet.Ansi , EntryPoint="MessageBoxA" ,
        ExactSpelling=false , PreserveSig=true , SetLastError=false)]
    
    public static extern int MyMessageBox1(
        uint hWnd ,
        [MarshalAs(UnmanagedType.LPStr)] string lpText ,
        [MarshalAs(UnmanagedType.LPStr)] string lpCaption ,
        uint uType
    );

    [DllImport("user32.dll" , CallingConvention=CallingConvention.Winapi ,
        CharSet=CharSet.Unicode , EntryPoint="MessageBoxW" ,
        ExactSpelling=false , PreserveSig=true , SetLastError=false)]
    
    public static extern int MyMessageBox2(
        uint hWnd ,
        [MarshalAs(UnmanagedType.LPWStr)] string lpText ,
        [MarshalAs(UnmanagedType.LPWStr)] string lpCaption ,
        uint uType
    );

    static void Main(string[] args) {
        MyMessageBox1(0 , "by ANSI"    , "Hello!" , 0);
        MyMessageBox2(0 , "by Unicode" , "Hello!" , 0);
    }
}
