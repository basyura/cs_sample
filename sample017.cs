using System;
using System.Collections.Generic;


class ExtensionSample {
    public static void Run() {
        var data = new []{1 , 2 , 3 , 4 , 5};
        var squared = data.Select(x => x * x);
        foreach (var x in squared) {
            Console.WriteLine(x);
        }
    }
}

static class Extensions {
    public static IEnumerable<U> Select<T,U>
        (this IEnumerable<T> data, Func<T,U> selector) {
        foreach(var x in data) {
            yield return selector(x);
        }
    }
}
