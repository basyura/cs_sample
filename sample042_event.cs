using System;

public delegate void SampleEventHandler(object sender , EventArgs e);

class Class1 {
    public static event SampleEventHandler sampleEvent {
        add {
            Console.WriteLine("add called");
        }
        remove {
            Console.WriteLine("remove called");
        }
    }
    public static void handler(object o , EventArgs e) {
        Console.WriteLine("handler called");
    }
    static void Main(string[] args) {
        Console.WriteLine("add event handler");
        sampleEvent += new SampleEventHandler(handler);
        Console.WriteLine("remove event handler");
        sampleEvent -= new SampleEventHandler(handler);
        Console.WriteLine("done");
    }
}
