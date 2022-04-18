using System;
namespace Algorithm_in_CSharp.C01
{
    public static class EvenTimesOddTimes
    {
        public static void getOddTimesNum1(int[] arr) {
            int eor = 0;
            foreach(int cur in arr){
                eor ^= cur;
            }
            Console.WriteLine(eor);
        }

        public static void getOddTimesNum2(int[] arr) {
            int eor = 0, onlyOne = 0;
            foreach(int curNum in arr){
                eor ^= curNum;
            }
            // eor = a ^ b
            // eor != 0
            // eor has 1 in one of its position
            int rightOne = eor & (~eor + 1); // get the rightmost 1
            Console.WriteLine(eor);

            foreach (int cur in arr){
                if((cur & rightOne) == 0){
                    onlyOne ^= cur;
                }
            }
            Console.WriteLine($"{onlyOne} {eor ^ onlyOne}");
        }
    }
}