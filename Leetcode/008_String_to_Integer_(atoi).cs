using System;
using System.Text.RegularExpressions;

public static class MyAtoi {
    public static int myAtoi(string s) {
        int index = 0;
        int sign = 1;
        if(s == "+1"){
            Console.WriteLine("mark");
        }
        while(index<s.Length && s[index] == ' '){
            index++;
        }

        if(index==s.Length){return 0;}

        if(s[index] == '+'){
            index++;
        }
        else if(s[index] == '-'){
            sign = -1;
            index++;
        }

        int res = 0;
        while(index<s.Length){
            if(!char.IsNumber(s[index])){
                break;
            }
            int number = s[index] - '0';
            if(sign > 0 && (res > int.MaxValue/10 || res *10 > (int.MaxValue - number)*sign)){
                return int.MaxValue;
            }
            else if(sign < 0 && (res < int.MinValue || res * 10 >= (int.MinValue - number) * sign)){
                return int.MinValue;
            }
            res = res*10 + number;
        }
        return res*sign;
    }


    public static void testing(){
        string s1 = "42";
        string s2 = "   -42";
        string s3 = "4193 with words";
        string s4 = "";
        string s5 = " ";
        string s6 = "20000000000000000000000000000";
        string s7 = "-2147483648";
        string s11 = "2147483648";
        string s8 = "--21343423";
        string s9 = "+1";
        string s10 = "  00000000000000000012345678";
        
        Console.WriteLine($"string: {s1}, return: {myAtoi(s1)}");
        Console.WriteLine($"string: {s2}, return: {myAtoi(s2)}");
        Console.WriteLine($"string: {s3}, return: {myAtoi(s3)}");
        Console.WriteLine($"string: {s4}, return: {myAtoi(s4)}");
        Console.WriteLine($"string: {s5}, return: {myAtoi(s5)}");
        Console.WriteLine($"string: {s6}, return: {myAtoi(s6)}");
        Console.WriteLine($"string: {s7}, return: {myAtoi(s7)}");
        Console.WriteLine($"string: {s8}, return: {myAtoi(s8)}");
        Console.WriteLine($"string: {s9}, return: {myAtoi(s9)}");
        Console.WriteLine($"string: {s10}, return: {myAtoi(s10)}");
        Console.WriteLine($"string: {s11}, return: {myAtoi(s11)}");
    }
}