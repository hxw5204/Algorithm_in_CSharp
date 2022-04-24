namespace Algorithm_in_CSharp.Algorithm
{
    public class InsertionSort
    {
        //O(N^2)
        public static int[] insertionSort (int[] arr){
            if(arr == null || arr.Length < 2){
                return arr;
            }
            // 0 ~ 1
            // 0 ~ 2
            // ..
            // 0 ~ N-1
            // check backforward and swap if smaller than previous one
            // if greater that previous one, continue
            for (int i = 1; i < arr.Length; i++) {
                for (int j = i -1; j >= 0 && arr[j] > arr[j + 1]; j--){
                    Helper.swap(arr, j, j + 1);
                }
            }
            return arr;
        }
    }
}