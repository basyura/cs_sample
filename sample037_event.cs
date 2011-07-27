using System;

public delegate void SampleEventHandler(object sender , EventArgs e);

class Class1 {
    public event SampleEventHandler sampleEvent;
    public void handler(object o , EventArgs e) {
        Console.WriteLine("handler called");
    }
    static void Main(string[] args) {
        Class1 target = new Class1();
        target.sampleEvent += new SampleEventHandler(target.handler);
        target.sampleEvent(target , EventArgs.Empty);
        target.sampleEvent(null   , EventArgs.Empty);
    }
}
