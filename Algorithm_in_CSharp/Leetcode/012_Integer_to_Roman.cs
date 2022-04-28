using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_CSharp.Leetcode
{
    public static class Integer_to_Roman
    {
        public static string IntToRoman(int num)
        {
            string ret = "";
            while(num > 0)
            {
                if(num - 1000 >= 0)
                {
                    ret += "M";
                    num -= 1000;
                }
                else if(num - 900 >= 0)
                {
                    ret += "CM";
                    num -= 900;
                }
                else if ( num - 500 >= 0)
                {
                    ret += "D";
                    num -= 500;
                }
                else if (num - 400 >= 0)
                {
                    ret += "CD";
                    num -= 400;
                }
                else if (num - 100 >= 0)
                {
                    ret += "C";
                    num -= 100;
                }
                else if (num - 90 >= 0)
                {
                    ret += "XC";
                    num -= 90;
                }
                else if (num - 50 >= 0)
                {
                    ret += "L";
                    num -= 50;
                }
                else if (num - 40 >= 0)
                {
                    ret += "XL";
                    num -= 40;
                }
                else if (num - 10 >= 0)
                {
                    ret += "X";
                    num -= 10;
                }
                else if (num - 9 >= 0)
                {
                    ret += "IX";
                    num -= 9;
                }
                else if (num - 5 >= 0)
                {
                    ret += "V";
                    num -= 5;
                }
                else if (num - 4 >= 0)
                {
                    ret += "IV";
                    num -= 4;
                }
                else if (num - 1 >= 0)
                {
                    ret += "I";
                    num -= 1;
                }
            }


            return ret;
        }

        public static void testing()
        {
            Console.WriteLine(IntToRoman(3));
            Console.WriteLine(IntToRoman(58));
            Console.WriteLine(IntToRoman(1994));
            Console.WriteLine(IntToRoman(3724));
        }
    }
}

