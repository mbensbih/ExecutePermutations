using System;
using System.Collections.Generic;

namespace ExecutePermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = ExeccutePermutations(new List<int> { 4, 2, 1, 3 }, new List<int> { 4, 3, 2 });

            foreach (var item in result)
            {
                Console.WriteLine($"{item} \n");
            }
        }

        public static List<int> ExeccutePermutations(List<int> values, List<int> permutations)
        {
            foreach (var p in permutations)
            {
                for (int i = 0; i < p / 2; i++)
                {
                    var pivot = values[i];
                    values[i] = values[p - i - 1];
                    values[p - i - 1] = pivot;
                }
            }

            return values;
        }
    }
}
