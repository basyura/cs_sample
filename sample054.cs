/*
 * http://ufcpp.net/study/csharp/lib_forms.html
 */
using System;
using System.Drawing;
using System.Windows.Forms;

class Program {
    static void Main(string[] args) {
        Application.Run(new Form1());
    }
}

class Form1 : Form {
    /** */
    private Button button1_ = null;
    /** */
    private int count_ = 0;
    /*
     *
     */
    public Form1() {
        this.Width  = 200;
        this.Height = 200;
        this.Text   = "サンプルプログラム";

        button1_ = new Button();
        button1_.Location = new Point(10,10);
        button1_.Size     = new Size(170,30);
        button1_.Text     = "ここを押して";
        button1_.Click += new EventHandler(button1_click);

        this.Controls.Add(button1_);
    }
    /*
     *
     */
    void button1_click(object sender , EventArgs e) {
        count_ ++;
        button1_.Text = count_.ToString();
    }
}
