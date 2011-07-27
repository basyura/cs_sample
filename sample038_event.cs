using System;

public delegate void SampleEventHandler(object sender , EventArgs e);

class Class1 {
    class Class2 {
        public void startHandler(object o , EventArgs e) {
            Console.WriteLine("start handler called");
        }
        public void endHandler(object o , EventArgs e) {
            Console.WriteLine("end handler called");
        }
    }
    public event SampleEventHandler startEvent;
    public event SampleEventHandler endEvent;
    Class2 target1 = new Class2();
    Class2 target2 = new Class2();
    Class2 target3 = new Class2();
    public Class1() {
        startEvent += new SampleEventHandler(target1.startHandler);
        endEvent   += new SampleEventHandler(target1.endHandler);
        startEvent += new SampleEventHandler(target2.startHandler);
        endEvent   += new SampleEventHandler(target2.endHandler);
        startEvent += new SampleEventHandler(target3.startHandler);
        endEvent   += new SampleEventHandler(target3.endHandler);
    }
    public void process() {
    }
    static void Main(string[] args) {
        Class1 main = new Class1();
        main.startEvent(main , EventArgs.Empty);
        main.process();
        main.endEvent(main , EventArgs.Empty);
    }
}
