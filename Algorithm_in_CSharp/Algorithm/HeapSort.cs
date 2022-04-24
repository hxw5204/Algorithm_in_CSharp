namespace Algorithm_in_CSharp.Algorithm
{
    public class HeapSort
    {
        public static void heapsort(int[] arr){
            if(arr == null || arr.Length < 2){
                return;
            }
            for (int i = 0; i < arr.Length; i++){ // O(N)
                heapInsert(arr, i); //O(logN)
            }
            int heapSize = arr.Length;
            Helper.swap(arr, 0, --heapSize);
            while(heapSize > 0) // O(N)
            {
                heapify(arr, 0, heapSize); // O(logN)
                Helper.swap(arr, 0, --heapSize); // O(1)
            }
        }

        //某个数现在处在index位置， 往上继续移动
        public static void heapInsert(int[] arr, int index){
            while(arr[index]>arr[(index-1) / 2]){
                Helper.swap(arr, index, (index-1)/2);
                index = (index - 1)/2;
            }
        }

        // 某个数在index位置，能否往下移动
        public static void heapify(int[] arr, int index, int heapSize)
        {
            int left = index * 2 + 1; //left child position

            while (left < heapSize) //下方还有child的时候
            {
                //两个孩子中， 谁的之大，把下标给largest
                int largest = left + 1 < heapSize && arr[left + 1] > arr[left] ? left + 1 : left;

                //父和孩子之间， 谁的值大， 把下标给largest
                largest = arr[largest] > arr[index] ? largest : index;
                if(largest == index) { break; }
                Helper.swap(arr, largest, index);
                index = largest;
                left = index * 2 + 1;
            }
        }
    }
}