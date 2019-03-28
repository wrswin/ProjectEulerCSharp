using System;

namespace Problem7 {
    class Program {
        static void Main(string[] args) {
            var primeCount = 0;
            var i = 2;

            while(true) {
                var prime = true;

                for(var j = 2; j < i / 2; j += 1) {
                    if(i % j == 0) {
                        prime = false;

                        break;
                    }
                }

                if(prime) {
                    if(primeCount == 10001) {
                        Console.WriteLine(i);

                        break;
                    }

                    primeCount += 1;
                }

                i += 1;
            }
        }
    }
}
