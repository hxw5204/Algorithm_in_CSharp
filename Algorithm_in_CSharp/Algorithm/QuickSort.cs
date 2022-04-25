﻿using System;

namespace Algorithm_in_CSharp.Algorithm
{
    public class QuickSort
    {
        public static void quickSort(int[] arr, int left, int right) 
        {
            if(left < right)
            {
                if (left >= right) return;   //两个指针重合就返回，结束调用
                int pivotIndex = finfNextPivot(arr, left, right);  //会得到一个基准值下标

                quickSort(arr, left, pivotIndex - 1);  //对基准的左端进行排序  递归
                quickSort(arr, pivotIndex + 1, right);   //对基准的右端进行排序  递归
            }
        }

        private static int finfNextPivot(int[] arr, int begin, int end)
        {
            int pivot = arr[begin];   //将首元素作为基准
            int i = begin;
            int j = end;
            while (i < j)
            {
                //从右到左，寻找第一个小于基准pivot的元素
                while (arr[j] >= pivot && i < j) j--; //指针向前移
                arr[i] = arr[j];  //执行到此，j已指向从右端起第一个小于基准pivot的元素，执行替换

                //从左到右，寻找首个大于基准pivot的元素
                while (arr[i] <= pivot && i < j) i++; //指针向后移
                arr[j] = arr[i];  //执行到此,i已指向从左端起首个大于基准pivot的元素，执行替换
            }

            //退出while循环,执行至此，必定是 i= j的情况（最后两个指针会碰头）
            //i(或j)所指向的既是基准位置，定位该趟的基准并将该基准位置返回
            arr[i] = pivot;
            return i;
        }

        public static void testing(){
            int[] arr = new int[] { 3, 1, 45, 6, 3, 56, 4, 3, 5, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);    
            }
            Console.WriteLine();

            quickSort(arr, 0, arr.Length-1);
            
            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
           
		   foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}