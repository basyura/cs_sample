/*
 * http://ufcpp.net/study/csharp/lib_forms.html
 *
 * csc /r:System.Drawing.dll /r:System.Windows.Forms.dll /target:winexe sample053.cs
 */

using System;
using System.Drawing;
using System.Windows.Forms;

class Program {
    static void Main(string[] args) {
        Form f = new Form();
        f.Width  = 200;
        f.Height = 200;
        f.Text = "サンプルプログラム";
        Application.Run(f);
    }
}
