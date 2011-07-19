using System;

namespace Sample001 {
    public class Person {
        public virtual string getName() {
            return "私には名前がありません。";
        }
    }
    public class Taro : Person {
        public override string getName() {
            return "私の名前は太郎でオーバーライド";
        }
    }

    class Cls {
        static void Main(string[] args) {
            Console.WriteLine(new Person().getName());
            Console.WriteLine(new Taro().getName());
            Person p = new Taro();
            Console.WriteLine(p.getName());
        }
    }
}
