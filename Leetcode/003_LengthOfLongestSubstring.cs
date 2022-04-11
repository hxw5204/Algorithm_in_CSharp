using System;
namespace Algorithm_in_CSharp.Leetcode
{
    public static class LengthOfLongestSubstring {

        /**
            Given a string s, find the length of the longest substring without repeating characters.

            

            Example 1:

            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.
            Example 2:

            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.
            Example 3:

            Input: s = "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3.
            Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
            

            Constraints:

            0 <= s.length <= 5 * 104
            s consists of English letters, digits, symbols and spaces.
        */
        public static int lengthOfLongestSubstring(string s) {
            string longestString = "";
            string newString = "";
            foreach(char c in s){
                if(newString.Contains(c)){
                    // update the longest string if new string is longer than longest string
                    if(newString.Length > longestString.Length){
                        longestString = newString;
                    }
                    // get the substring from newString[first index of repeated char + 1, new string length + current char]
                    int pos = newString.IndexOf(c);
                    newString = newString.Substring(pos+1);
                    newString += c;
                }else{
                    // append the current char to new string
                    newString += c;
                    if(newString.Length > longestString.Length){
                        longestString = newString;
                    }
                }
            }
            return longestString.Length;
        }
    }
}