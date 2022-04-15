using System;
namespace Algorithm_in_CSharp.Leetcode
{
    public static class ZigzagConversion
    {
        /**
        13579
        24680

        1 5 9
        24680
        3 7

        1  7
        2 68
        35 9
        4  0

        1   9
        2  80
        3 7
        46
        5
        */
        public static string Convert(string s, int numRows) {
            if(s.Length <= 1 || numRows == 1){
                return s;
            }
            int index = 0;
            bool down = true;
            string[] ret = new string[numRows];
            foreach(char c in s){
                ret[index] += c;
                if(down == true){
                    if(index == numRows - 1){
                        index--;
                        down = false;
                    }
                    else{
                        index++;
                    }
                }
                else{
                    if(index == 0){
                        index++;
                        down = true;
                    }
                    else{
                        index--;
                    }
                }
            }
            return string.Join("", ret);
        }
    }
}