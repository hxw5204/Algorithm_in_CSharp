using System;
namespace Algorithm_in_CSharp.Leetcode

{
    public static class LongestPalindrome
    {
        /**
        Given a string s, return the longest palindromic substring in s.

        Example 1:
        Input: s = "babad"
        Output: "bab"
        Explanation: "aba" is also a valid answer.

        Example 2:
        Input: s = "cbbd"
        Output: "bb"
        */
        public static string longestPalindrome(string s) {
            string palindrome = "";
            for(int i = 0; i < s.Length; i++){
                string s1 = getLongestPalindrome(s, i, i);
                if(s1.Length > palindrome.Length){
                    palindrome = s1;
                }
                if((i+1<s.Length) && s[i] == s[i+1]){
                    s1 = getLongestPalindrome(s, i, i+1);
                    if(s1.Length > palindrome.Length){
                        palindrome = s1;
                    }
                }
            }
            return palindrome;
        }

        public static string getLongestPalindrome(string s, int left, int right){
            
            while(left > 0 && right < s.Length-1 && s[left-1] == s[right+1]){
                left--;
                right++;
            }
            
            return s.Substring(left,right-left+1);
        }
    }
}