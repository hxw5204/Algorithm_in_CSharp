using System;

namespace Algorithm_in_CSharp.Algorithm
{
    public class QuickSort
    {
        public static void quickSort(int[] arr, int left, int right) 
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1) {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    quickSort(arr, pivot + 1, right);
                }
            }
        
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true) 
            {

                while (arr[left] < pivot) 
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else 
                {
                    return right;
                }
            }
        }

        public static void testing(){
            int[] arr = new int[] {3,1,45,6,3,56,4,3,5,6};

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