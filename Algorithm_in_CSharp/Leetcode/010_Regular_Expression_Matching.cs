using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Leetcode
{
    public static class Regular_Expression_Matching
    {
        /// <summary>
        /// Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
        ///
        /// '.' Matches any single character.​​​​
        /// '*' Matches zero or more of the preceding element.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool IsMatch(string s, string p)
        {

            int numRows = s.Length + 1;
            int numCols = p.Length + 1;
            bool[,] table = new bool[numRows, numCols];
            table[0, 0] = true;

            for(int col = 1; col < numCols; col++)
            {
                char c = p[col-1];
                if(col == 1)
                {
                    if(c == '*')
                    {
                        table[0, col] = true;
                    }
                }
                else
                {
                    if(c == '*')
                    {
                        table[0, col] = table[0, col - 2];
                    }
                }
            }

            for(int row = 1; row < numRows; row++)
            {
                char cS = s[row - 1];
                for(int col=1; col < numCols; col++)
                {
                    char cP = p[col - 1];
                    if(cS==cP || cP == '.')
                    {
                        table[row, col] = table[row - 1, col - 1];
                    }
                    else if(cP == '*')
                    {
                        if(col > 1)
                        {
                            if(table[row, col - 2])
                            {
                                table[row, col] = true;
                            }
                            else
                            {
                                //cS
                                char preCP = p[col - 2];
                                if((cS== preCP || preCP == '.') && table[row - 1, col])
                                {
                                    table[row, col] = true;
                                }
                            }
                        }
                    }
                }
            }
            return table[numRows-1, numCols-1];
        }

        public static void testing()
        {
            Console.WriteLine(IsMatch("aa", "a"));
            Console.WriteLine(IsMatch("aa", "a*"));
            Console.WriteLine(IsMatch("ab", ".*"));
            Console.WriteLine(IsMatch("aab", "c*a*b"));
        }
    }
}
