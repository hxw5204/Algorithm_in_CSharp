using System;
namespace Algorithm_in_CSharp.C01
{
    public static class BubbleSort
    {
        public static int[] bubbleSort(int[] arr){
            if(arr == null || arr.Length < 2){
                return arr;
            }
            // 0 ~ N-1; 0 ~ N-2 ...; we move the largest number to the end
            for (int e = arr.Length - 1; e > 0; e --){ // 0 ~ e
                for(int i = 0; i < e; i++){
                    if(arr[i] > arr[i+1]){
                        Helper.swap2(arr, i, i + 1);
                    }
                }
            }

            return arr;
        }
    }
}