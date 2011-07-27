using System;

namespace systemLibrary {
    public delegate void SampleEventHandler(object sender , EventArgs e);
    class ClassLibrary {
        public static event SampleEventHandler sampleEvent;
        public static void fireEvent() {
            sampleEvent(null , EventArgs.Empty);
        }
    }
}

namespace userProgram {
    using systemLibrary;
    class ClassDerived {
        public static void onEvent(object o , EventArgs e) {
            Console.WriteLine("onEvent called");
        }
    }
    class Class1 {
        static void Main(string[] args) {
            systemLibrary.ClassLibrary.sampleEvent += new SampleEventHandler(ClassDerived.onEvent);
            systemLibrary.ClassLibrary.fireEvent();
        }
    }
}
