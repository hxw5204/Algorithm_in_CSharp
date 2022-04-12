using System;
namespace Algorithm_in_CSharp.Leetcode
{
    public static class FindMedianSortedArrays
    {
        /**Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

            The overall run time complexity should be O(log (m+n)).

            

            Example 1:

            Input: nums1 = [1,3], nums2 = [2]
            Output: 2.00000
            Explanation: merged array = [1,2,3] and median is 2.
            Example 2:

            Input: nums1 = [1,2], nums2 = [3,4]
            Output: 2.50000
            Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.
            

            Constraints:

            nums1.length == m
            nums2.length == n
            0 <= m <= 1000
            0 <= n <= 1000
            1 <= m + n <= 2000
            -106 <= nums1[i], nums2[i] <= 106
            */
        public static double findMedianSortedArrays(int[] nums1, int[] nums2) {
            
            int size = nums1.Length + nums2.Length;
            if(size == 0){
                return 0;
            }
            bool isEven = size%2 == 0 ? true : false;
            double[] list = new double[size/2 + 1];
            int nums1Index = 0;
            int nums2Index = 0;
            for(int i = 0; i<list.Length; i++){
                if(nums1Index >= nums1.Length){
                    list[i] = nums2[nums2Index];
                    nums2Index++;
                }
                else if(nums2Index >= nums2.Length){
                    list[i] = nums1[nums1Index];
                    nums1Index++;
                }
                else{
                    list[i] = nums1[nums1Index] < nums2[nums2Index] ? nums1[nums1Index] : nums2[nums2Index];
                    if(nums1[nums1Index] < nums2[nums2Index]){
                        list[i] = nums1[nums1Index];
                        nums1Index++;
                    }
                    else{
                        list[i] = nums2[nums2Index];
                        nums2Index++;
                    }
                }
                
            }
            
            double median = isEven? (list[list.Length-1] + list[list.Length-2])/2 : list[list.Length-1];
            Console.WriteLine("result: ");
            return median;
        }
    }
}