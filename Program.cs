using System;

namespace LeetCode_Arrays_cSharp
{
    internal class Program
    {
        // Max Conesecutive ones 
        // Given a binary array nums, return the maximum number of consecutive 1's in the array.

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int result = 0;
            int count = 0;
            foreach (var num in nums)
            {
                if(num == 1)
                {
                    result = Math.Max(result, count++); // In C#, Max() is a Math class method which is used to returns the larger of the two specified numbers.
                } else
                {
                    count = 0;
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            int[] binaryArrays = { 1, 1, 0, 1, 1, 1 };
            FindMaxConsecutiveOnes(binaryArrays);
        }
    }
}