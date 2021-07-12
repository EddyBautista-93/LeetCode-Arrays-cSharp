using System;

namespace LeetCode_Arrays_cSharp
{
    internal class Program
    {
        //  Given an integer array nums sorted in non-decreasing
        //  order, return an array of the squares of each number 
        //  sorted in non-decreasing order.

        // Example:

        // Input: nums = [-4,-1,0,3,10]
        // Output: [0,1,9,16,100]
        // Explanation: After squaring, the array becomes [16,1,0,9,100].
        // After sorting, it becomes [0,1,9,16,100].
        // Example 2:

        // Input: nums = [-7,-3,2,3,11]
        // Output: [4,9,9,49,121]

        public static int[] SortedSquares(int[] nums)
        {
            int n = nums.Length;

            // First convert each array
            // elements into its square
            for (int i = 0; i < n; i++)
                nums[i] = nums[i] * nums[i];

            // Sort an array using
            // "inbuild sort function"
            // in Arrays class.
            Console.WriteLine(Array.Sort(nums));
            return null;
        }

        private static void Main(string[] args)
        {
            int[] testArray = { -4, -1, 0, 3, 10 };
            SortedSquares(testArray);
        }
    }
}