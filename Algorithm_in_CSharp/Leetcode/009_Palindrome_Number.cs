using System;
public static class IsPalindrome {
    public static bool isPalindrome(int x) {
        if(x < 0 || x > int.MaxValue){ return false; }
        int num = 0;
        int a = x;
        while(a != 0){
            int temp = a % 10; // last digit
            num = num * 10 + temp; // push temp to end of int
            a = a/10; // remove last digit, until 0
        }

        if(x==num){
            return true;
        }else{
            return false;
        }
    }

    public static void testing(){
        Console.WriteLine($"int: {121} result: {isPalindrome(121)}");
        Console.WriteLine($"int: {-121} result: {isPalindrome(-121)}");
        Console.WriteLine($"int: {10} result: {isPalindrome(10)}");
    }
}