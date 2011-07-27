using System;

class Item : IComparable {
    public string name;
    public int price;
    public Item(string name , int price) {
        this.name  = name;
        this.price = price;
    }
    public int CompareTo(object obj) {
        return price - ((Item)obj).price;
    }
}

class Class1 {
    static void Main(string[] args) {
        int[] ar = {0 , 1 , 2 , 3 , 4};
        for (int i = ar.GetLowerBound(0) ; i <= ar.GetUpperBound(0) ; i++) {
            Console.WriteLine(ar[i]);
        }
        foreach (int n in ar) {
            Console.WriteLine(n);
        }
        int[] ar2 = {3 , 1 , 4 , 5 , 0 , 2};
        Array.Sort(ar2);
        foreach (int n in ar2) {
            Console.WriteLine(n);
        }
        
        int index = Array.BinarySearch(ar2 , 3);
        Console.WriteLine("index of 3 is {0}" , index);

        Item[] ar3 = {
            new Item("チョコ" ,  50),
            new Item("煎餅"   , 200),
            new Item("飴"     ,  10),
            new Item("ポテチ" , 100)
        };
        Array.Sort(ar3);
        foreach (Item it in ar3) {
          Console.WriteLine("{0} , {1}" , it.name , it.price);
        }
    }
}
