using System;
using Algorithm_in_CSharp.Algorithm;
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

        public static int[] listGenerator(int numOfInts, int min, int max){
            int[] ints = new int[numOfInts]; 
            Random rand = new Random();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.Next(min, max);
            }
            return ints;
        }

        public static void printIntList(int[] intArr){
            Console.WriteLine("int list: ");
            foreach(int i in intArr)
            {
                Console.Write($" {i}");
            }
            Console.Write($"\n");
        }

        public static void print(object item){
            Console.WriteLine(item);
        }

        public static double averageTime(long[] times){
            return times.Average();
        }
    }
}