using System;

namespace Problem2 {
    class Program {
        static void Main(string[] args) {
            var previousPreviousNumber = 1;
            var previousNumber = 2;

            var sum = 2;

            while(previousNumber < 4000000) {
                var number = previousPreviousNumber + previousNumber;

                if(number % 2 == 0) {
                    sum += number;
                }

                previousPreviousNumber = previousNumber;
                previousNumber = number;
            }

            Console.WriteLine(sum);
        }
    }
}
