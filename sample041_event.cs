
using System;

public delegate void SampleEventHandler(object sender, EventArgs e);
class Class1 {
    public event SampleEventHandler sampleEvent;
}
class Class2 {
    public void handler( object o, EventArgs e ) {
        Console.WriteLine("handler called");
    }
    [STAThread]
    static void Main(string[] args) {
        Class1 target1 = new Class1();
        Class2 target2 = new Class2();
        target1.sampleEvent += new SampleEventHandler(target2.handler);
        target1.sampleEvent(null , EventArgs.Empty);
        // イベント 'Sample005.Class1.sampleEvent' は += 、-= の左辺にのみ使用できます。
        // ただし、 'Sample005.Class1' 型内から使用されている場合を除きます。
        //target1.sampleEvent( target2, EventArgs.Empty );
    }
}

