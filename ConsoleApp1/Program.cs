using System;
using System.Linq;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {

            int[] ints = {
                754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
                187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
                690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

            var num1 = 0;
            var ElementsCount = 0;
            var average = 0;
            var total = 0;

            foreach (var i in ints) {
                num1 = i;
                total = i + total;
            }
            ElementsCount = ints.Count();
            average = total / ElementsCount;
            Console.WriteLine($"The average of this set is {average}");
        }
        }
}

    /*
            var total = 0;
            var count = 0;
            var average = 0;

            total = ints.Sum();
            count = ints.Count();
            average = total / count;
            Console.WriteLine($"The average of this set is {average}");
    */
