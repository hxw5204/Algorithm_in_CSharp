using System;
namespace Algorithm_in_CSharp.Leetcode
{
    public static class ReverseInterger
    {
        /**
            Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

            Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
            Example 1:

            Input: x = 123
            Output: 321
            Example 2:

            Input: x = -123
            Output: -321
            Example 3:

            Input: x = 120
            Output: 21
            

            Constraints:

            -231 <= x <= 231 - 1
        */
        public static int Reverse(int x) {

            if(x == 0){return 0;}
            char[] s = x.ToString().ToCharArray();
            int i = 0;
            if(x < 0){ i++; }
            for(int j = s.GetLength(0)-1; i!=j; j--){
                swap(s, i, j);
                i++;
                if(i==j){break;}
            }
            for(int j = s.GetLength(0)-1; i!=j; j--){
                swap(s, i, j);
                i++;
                if(i==j){break;}
            }
            int ret = int.Parse(string.Join("", s));
            if(-231 <= ret || ret <= 230) {
                return ret;
            }
            else{
                return 0;
            }
        }

        public static void swap(char[] s, int i, int j){
            char tmp = s[i];
            s[i] = s[j];
            s[j] = tmp;
        }
    }
}