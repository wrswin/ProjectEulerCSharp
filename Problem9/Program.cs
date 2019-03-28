using System;

namespace Problem9 {
    class Program {
        static void Main(string[] args) {
            for(var a = 1; a < 1000; a += 1) {
                for(var b = a + 1; b < 1000; b += 1) {
                    for(var c = b + 1; c < 1000; c += 1) {
                        if(a * a + b * b == c * c && a + b + c == 1000) {
                            Console.WriteLine(a * b * c);

                            return;
                        }
                    }
                }
            }
        }
    }
}
