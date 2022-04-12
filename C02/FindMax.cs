using System;
namespace Algorithm_in_CSharp.C02
{
    public static class FindMax
    {
        public static int findMax_1(int[] arr){
            if(arr.Length == 0){
                return 0;
            }
            int max = arr[0];
            for(int i = 1; i < arr.Length; i++){
                if(max < arr[i]){
                    max = arr[i];
                }
            }
            return max;
        }

        // 7 times slower
        public static int findMax_2(int[] arr){
            if(arr.Length == 0){
                return 0;
            }
            return process(arr, 0, arr.Length-1);
        }

        public static int process(int[] arr, int L, int R){
            if(L == R){
                return arr[L];
            }
            int mid = L + ((R - L) >> 1);
            int leftMax = process(arr, L, mid);
            int rightMax = process(arr, mid + 1, R);
            return Math.Max(leftMax, rightMax);
        }
    }
}