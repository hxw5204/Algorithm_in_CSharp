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
            if(s.Length == 1 || numRows == 1){
                return s;
            }
            int numColumns;
            if(s.Length <= numRows){
                numColumns = 1;
            }else
            {
                int left = s.Length%(numRows*2-2);
                int leftColumn = (left - numRows) <= 0? 1 : (left - numRows) + 1;
                numColumns = (left == 0)? (s.Length/(numRows*2-2)) * (numRows-1) : (s.Length/(numRows*2-2)) * (numRows-1) + leftColumn;
            }
            char[,] pattern = new char[numRows, numColumns];
            setArray(pattern, s, numRows);
            return getString(pattern,s.Length);
        }

        public static void setArray(char[,] pattern, string s, int numRows){
            int i = 0, j = 0;
            bool down = true;
            foreach(char c in s){
                pattern[i,j] = c;
                if(down == true){
                    i++;
                    if(i + 1 == numRows){
                        down = false;
                    }
                }
                else{
                    i--;
                    j++;
                    if(i == 0){
                        down = true;
                    }
                }
            }
        }

        public static string getString(char[,] pattern, int stringLength){
            string ret = "";

            for(int i = 0; i < pattern.GetLength(0); i++){
                for(int j = 0; j < pattern.GetLength(1); j++){
                    if(pattern[i,j] != '\0'){
                        ret += pattern[i,j];
                        stringLength--;
                        if(stringLength == 0){ return ret; }
                    }
                }
            }

            return ret;
        }
    }
}