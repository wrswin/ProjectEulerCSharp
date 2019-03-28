using System;

namespace Problem6 {
    class Program {
        static void Main(string[] args) {
            var sumOfSquares = 0;
            var squareOfSum = 0;

            for(var i = 1; i <= 100; i += 1) {
                sumOfSquares += i * i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            Console.WriteLine(squareOfSum - sumOfSquares);
        }
    }
}
