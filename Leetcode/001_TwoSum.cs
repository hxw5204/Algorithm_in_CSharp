using System.Collections.Generic;
namespace Algorithm_in_CSharp.Leetcode
{
    public static class TwoSum
    {
        //hash table
        /**
            It turns out we can do it in one-pass. While we are iterating and 
            inserting elements into the hash table, we also look back to check 
            if current element's complement already exists in the hash table. 
            If it exists, we have found a solution and return the indices immediately.
        */
        public static int[] twoSum(int[] nums, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>{};
            int[] ret = new int[]{};
            for(int i = 0; i < nums.GetLength(0); i++){
                if(!dict.ContainsKey(target-nums[i])){
                    dict[nums[i]] = i;
                }
                else{
                    ret = new int[]{dict[target-nums[i]], i};
                    return ret;
                }
            }
            return null;
        }
    }
}