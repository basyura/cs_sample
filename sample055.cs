/* 2005/09, 2009/07, 2010/07
csc /debug+ TestButtonEvent1.cs
TestButtonEvent1.exe

・Button のサンプル
・プロパティの記述方法、イベント処理の記述方法、
*/

using System;
using System.Windows.Forms;
using System.Drawing;

class TestButtonEvent1 : Form {

	[STAThread] //おまじない
	public static void Main() {
		Application.EnableVisualStyles(); //おまじない
		Application.SetCompatibleTextRenderingDefault(false); //おまじない
		Application.Run( new TestButtonEvent1());
	}

	public TestButtonEvent1(){
		Text = GetType().ToString();
		ClientSize = new Size(280, 140);

		Button b1 = new Button();
		b1.Location = new Point(20, 50);
		b1.Text = "押すべし１";

		Button b2 = new Button();
		b2.Location = new Point(100, 50);
		b2.Text = "押すべし２";

		Button b3 = new Button();
		b3.Location = new Point(180, 50);
		b3.Text = "押すべし３";

/*  参考:C# 3.5 で下のようにも書ける。
		Button b3 = new Button(){
			Location = new Point(180, 50),
			Text = "押すべし３",
		};
*/

		Controls.AddRange(new Control[] { b1, b2, b3 });

		/*
		 * ボタンのハンドラの記述方法
		 */

		//C# 1.1の書き方
		b1.Click += new EventHandler(button_Click1);

		//C# 2.0からは new EventHandlerを省略できる。
		b2.Click += button_Click2;

        string name = "hello world";

		//匿名のデリゲートにするとこうなる。
		b3.Click += delegate(object sender, System.EventArgs e){
			MessageBox.Show(name , "見出し");
		};
	}

	void button_Click1(object sender, System.EventArgs e) {
		MessageBox.Show("ようこそ１", "見出し");
	}
	void button_Click2(object sender, System.EventArgs e) {
		MessageBox.Show("ようこそ２", "見出し");
	}
}


