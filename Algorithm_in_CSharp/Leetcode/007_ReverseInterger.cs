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

            -2^31 <= x <= 2^31 - 1
            -2147483648 ~ 2147483647
        */
        public static int Reverse(int x) {
            if(x <= -2147483648 || x >= 2147483647){ return 0;}

            // prevent overflow
            long num = 0;
            int a = Math.Abs(x);

            while(a != 0){
                int temp = a % 10; // last digit
                num = num * 10 + temp; // push temp to end of int
                a = a/10; // remove last digit, until 0
            }
            Console.WriteLine(Math.Pow(2,31)-1);
            if(x > 0 && num < 2147483647){
                return (int)num;
            }
            else if(x < 0 && num < 2147483648){
                return (int)-num;
            }
            else{
                return 0;
            }
        }
    }
}