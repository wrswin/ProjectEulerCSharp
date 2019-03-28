using System;

namespace Problem5 {
    class Program {
        static void Main(string[] args) {
            var i = 1;
            while(true) {
                var found = true;

                for(var j = 1; j < 20; j += 1) {
                    if(i % j != 0) {
                        found = false;

                        break;
                    }
                }

                if(found) {
                    Console.WriteLine(i);

                    break;
                } else {
                    i += 1;
                }
            }
        }
    }
}
