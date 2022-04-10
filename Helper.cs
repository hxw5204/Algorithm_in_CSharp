using System;
using Algorithm_in_CSharp.C01;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm_in_CSharp
{
    public static class Helper
    {
        public static void swap(int[] arr, int i, int j){
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        /** 
        * arr[i] and arr[j] have to be allocated independently. 
        * In array, i != j; If i == j, return 0 
        */
        public static void swap2(int[] arr, int i, int j){
            arr[i] = arr[i] ^ arr[j];
            arr[j] = arr[i] ^ arr[j];
            arr[i] = arr[i] ^ arr[j];
            /**
            *   XOR: 10110 ^ 00111 = 10001
            *   0 ^ N = N; N ^ N = 0
            *   a ^ b = b ^ a; (a ^ b) ^ c = a ^ (b ^ c)
            *   =========================================
            *   i = a; j = b
            *   i = i ^ j;  i = a ^ b, j = b
            *   j = i ^ j;  i = i ^ b, j = a ^ b ^ b => a ^ (b ^ b) => a ^ 0 => a
            *   i = i ^ j;  i = a ^ b ^ a => (a ^ a) ^ b => 0 ^ b => b, j = a
            */
        }

        public static int[] listGenerator(int numOfInts){
            Random rand = new Random();
            int[] ints = Enumerable.Range(0, numOfInts)
                                     .Select(i => new Tuple<int, int>(rand.Next(numOfInts), i))
                                     .OrderBy(i => i.Item1)
                                     .Select(i => i.Item2).ToArray();
            return ints;
        }

        public static void printBefore(int[] intArr,bool printing){
            if(printing == false){
                return;
            }
            Console.WriteLine("Before");
            foreach(int i in intArr)
            {
                Console.Write($" {i}");
            }
            Console.Write($"\n");
        }

        public static void printAfter(int[] intArr, bool printing){
            if(printing == false){
                return;
            }
            Console.WriteLine("After");    
            foreach(int i in intArr)
            {
                Console.Write($" {i}");
            }
            Console.Write($"\n");
        }

        public static double averageTime(long[] times){
            return times.Average();
        }
    }
}