using System;
using Algorithm_in_CSharp.C01;
using Algorithm_in_CSharp.C02;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using Algorithm_in_CSharp.Leetcode;

namespace Algorithm_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int numOfInts = 1000000000;
            int min = 0;
            int max = 1000000;
            
            #region selection sort
            int[] intArr = Helper.listGenerator(numOfInts, min, max);
            Console.WriteLine($"\n Selection Sort: ");
            //Helper.printBefore(intArr,true);
            List<long> times = new List<long>();
            for(int i = 0; i<10; i++){
                times.Add(selectionSortTester(intArr, false));
            }

            Console.WriteLine($"Selection sort average time: {Helper.averageTime(times.ToArray())}");
            #endregion

            #region bubble sort
            intArr = Helper.listGenerator(numOfInts, min, max);
            Console.WriteLine($"\n Bubble Sort: ");
            //Helper.printBefore(intArr,true);
            List<long> times1 = new List<long>();
            for(int i = 0; i<10; i++){
                times1.Add(bubbleSortTester(intArr, false));
            }

            Console.WriteLine($"Bubble sort average time: {Helper.averageTime(times1.ToArray())}");
            #endregion

            #region InsertionSort
            intArr = Helper.listGenerator(numOfInts, min, max);
            Console.WriteLine($"\n Insertion Sort: ");
            //Helper.printBefore(intArr,true);
            List<long> times2 = new List<long>();
            for(int i = 0; i<10; i++){
                times2.Add(insertionSortTester(intArr, false));
            }

            Console.WriteLine($"Insertion sort average time: {Helper.averageTime(times2.ToArray())}");
            #endregion
            */
            /*
            #region findmax
            int[] intArr = Helper.listGenerator(numOfInts, min, max);
            //int[] intArr = new int[] {1,3,2,4,6,8,244,9};
            Console.WriteLine($"\n find max: ");
            //Helper.printBefore(intArr,true);
            List<long> times = new List<long>();
            List<long> times2 = new List<long>();
            for(int i = 0; i<10; i++){
                times.Add(findMax01Tester(intArr, false));
                times2.Add(findMax02Tester(intArr, false));
            }

            Console.WriteLine($"find max 1 average time: {Helper.averageTime(times.ToArray())}");
            Console.WriteLine($"find max 2 average time: {Helper.averageTime(times2.ToArray())}");
            #endregion
            */
              
            
            IsPalindrome.testing();
        }
        /*
        public static long selectionSortTester(int[] intArr, bool printing){
            Helper.printBefore(intArr, printing);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Helper.printAfter(SelectionSort.selectionSort(intArr), printing);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            if(printing){Console.WriteLine($"\nTime: {elapsed_time}");}
            return elapsed_time;
        }

        public static long bubbleSortTester(int[] intArr, bool printing){
            Helper.printBefore(intArr, printing);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Helper.printAfter(BubbleSort.bubbleSort(intArr), printing);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            if(printing){Console.WriteLine($"\nTime: {elapsed_time}");}
            return elapsed_time;
        }

        public static long insertionSortTester(int[] intArr, bool printing){
            Helper.printBefore(intArr, printing);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Helper.printAfter(InsertionSort.insertionSort(intArr), printing);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            if(printing){Console.WriteLine($"\nTime: {elapsed_time}");}
            return elapsed_time;
        }

        public static long findMax01Tester(int[] intArr, bool printing){
            Helper.printBefore(intArr, printing);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"01 max: {FindMax.findMax_1(intArr)}");
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            if(printing){Console.WriteLine($"\nTime: {elapsed_time}");}
            return elapsed_time;
        }

        public static long findMax02Tester(int[] intArr, bool printing){
            Helper.printBefore(intArr, printing);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine($"02 max: {FindMax.findMax_2(intArr)}");
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            if(printing){Console.WriteLine($"\nTime: {elapsed_time}");}
            return elapsed_time;
        }
        */
    }
}
