using System;

public class SampleEventArgs : EventArgs {
    public string message;
}

public delegate void SampleEventHandler(object sender , SampleEventArgs e);

class Class1 {
    public event SampleEventHandler sampleEvent;
    public void handler(object o , SampleEventArgs e) {
        Console.WriteLine(e.message);
    }

    static void Main(string[] args) {
        Class1 target = new Class1();
        target.sampleEvent += new SampleEventHandler(target.handler);
        SampleEventArgs sampleEventArgs = new SampleEventArgs();
        sampleEventArgs.message = "in main method";
        target.sampleEvent(target , sampleEventArgs);
    }
}
