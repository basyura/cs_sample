using System;

namespace systemLibrary {
    abstract class ClassBase {
        public abstract void onEvent();
    }
    class ClassLibrary {
        public static void fireEvent(ClassBase instance) {
            instance.onEvent();
        }
    }
}

namespace userProgram {
    class ClassDerived : systemLibrary.ClassBase {
        public override void onEvent() {
            Console.WriteLine("onEvent called");
        }
    }
}

class Class1 {
    static void Main(string[] args) {
        userProgram.ClassDerived instance = new userProgram.ClassDerived();
        systemLibrary.ClassLibrary.fireEvent(instance);
    }
}
