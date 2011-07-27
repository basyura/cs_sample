using System;

public delegate void SampleEventHandler(object sender , EventArgs e);

class Class1 {
    public static event SampleEventHandler sampleEvent;
    public static void handler(object o , EventArgs e) {
        Console.WriteLine("handler called");
    }
    static void Main(string[] args) {
        sampleEvent += new SampleEventHandler(handler);
        sampleEvent(null , EventArgs.Empty);
    }
}
