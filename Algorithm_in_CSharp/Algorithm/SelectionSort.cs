
namespace Algorithm_in_CSharp.Algorithm
{
    public static class SelectionSort
    {
        // O(N^2)
        public static int[] selectionSort(int[] arr){

            if(arr == null || arr.Length < 2){
                return arr;
            }

            for(int i = 0; i < arr.Length - 1; i++){
                int minIndex = i;
                for(int j = i+1; j < arr.Length; j++){
                    minIndex = arr[j]<arr[minIndex] ? j : minIndex;
                }
                Helper.swap(arr,i, minIndex);
            }
            return arr;
        }
    }
}