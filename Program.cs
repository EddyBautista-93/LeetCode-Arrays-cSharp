using System;

namespace LeetCode_Arrays_cSharp
{
    internal class Program
    {
        // Duplicate Zeros

        // Given a fixed length array arr of integers, duplicate each occurrence of zero, shifting the remaining elements to the right.

        // Note that elements beyond the length of the original array are not written.

        // Do the above modifications to the input array in place, do not return anything from your function.

        // Example 1:

        // Input: [
        // Output: null
        // Explanation: After calling your function, the input array is modified to: [1,0,0,2,3,0,0,4]
        // Example 2:

        // Input: [1,2,3]
        // Output: null
        // Explanation: After calling your function, the input array is modified to: [1,2,3]

        public static void DuplicateZeros(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                if(arr[i] == 0)
                {
                    for (int j = len - 1; j >= i + 1; j--)
                    {
                        arr[j] = arr[j] - 1;
                    }
                    i = i + 1;
                }
            }
        }


        private static void Main(string[] args)
        {
            int[] testArray = { 1, 0, 2, 3, 0, 4, 5, 0};
            DuplicateZeros(testArray);
        }
    }
}