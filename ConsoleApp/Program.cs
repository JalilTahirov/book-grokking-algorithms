using System;
using System.Collections.Generic;
//using grokking;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result  = BinarySearch(new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14}, 1  );
            //Console.WriteLine(result);
            var sort = new Sorting();
            var result = sort.SelectionSort(new List<int> { 4, 2, 1, 7, 3, 9, 0, 8 });

            Console.WriteLine("Hello World!");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
