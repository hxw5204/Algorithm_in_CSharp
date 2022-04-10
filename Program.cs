using System;
using Algorithm_in_CSharp.C01;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Algorithm_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfInts = 100;
            #region selection sort
            int[] intArr = Helper.listGenerator(numOfInts);
            Console.WriteLine($"\n Selection Sort: ");
            List<long> times = new List<long>();
            for(int i = 0; i<10; i++){
                times.Add(selectionSortTester(intArr, false));
            }

            Console.WriteLine($"Selection sort average time: {Helper.averageTime(times.ToArray())}");
            #endregion

            #region bubble sort
            intArr = Helper.listGenerator(numOfInts);
            Console.WriteLine($"\n Bubble Sort: ");
            List<long> times1 = new List<long>();
            for(int i = 0; i<10; i++){
                times1.Add(bubbleSortTester(intArr, false));
            }

            Console.WriteLine($"Bubble sort average time: {Helper.averageTime(times1.ToArray())}");
            #endregion

            #region getOddTimesNum1
            intArr = Helper.listGenerator(numOfInts);
            Helper.printBefore(intArr,true);
            Console.WriteLine($"\n getOddTimesNum1: ");
            getOddTimesNum1Tester(intArr, true);
            #endregion

            #region getOddTimesNum2
            intArr = Helper.listGenerator(numOfInts);
            Helper.printBefore(intArr,true);
            Console.WriteLine($"\n getOddTimesNum2: ");
            getOddTimesNum2Tester(intArr, true);
            #endregion
        }

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

        public static void getOddTimesNum1Tester(int[] intArr, bool printing){
            EvenTimesOddTimes.getOddTimesNum1(intArr);
        }

        public static void getOddTimesNum2Tester(int[] intArr, bool printing){
            EvenTimesOddTimes.getOddTimesNum2(intArr);
        }
    }
}
