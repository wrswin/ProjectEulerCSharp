using System;

namespace Problem4 {
    class Program {
        static void Main(string[] args) {
            var largestPalindrome = 0;

            for(var i = 100; i < 1000; i += 1) {
                for(var j = 100; j < 1000; j += 1) {
                    var product = i * j;

                    var productDigits = product.ToString().ToCharArray();

                    var palindrome = true;

                    for(var k = 0; k < productDigits.Length / 2; k += 1) {
                        if(productDigits[k] != productDigits[productDigits.Length - 1 - k]) {
                            palindrome = false;

                            break;
                        }
                    }

                    if(palindrome && product > largestPalindrome) {
                        largestPalindrome = product;
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
        }
    }
}
