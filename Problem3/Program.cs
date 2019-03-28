using System;

namespace Problem3 {
    class Program {
        static void Main(string[] args) {
            var number = 600851475143;

            for(long i = number / 2; i > 1; i -= 1) {
                if(number % i == 0) {
                    var prime = true;

                    for(long j = 2; j < i / 2; j += 1) {
                        if(i % j == 0) {
                            prime = false;

                            break;
                        }
                    }

                    if(prime) {
                        Console.WriteLine(i);

                        return;
                    }
                }
            }
        }
    }
}
