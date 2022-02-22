using System;

namespace LoveBabbarDsaArrays
{
    public class Arrays
    {
        public bool IsPalindromicArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isPalindrome = IsPalindrome(arr[i]);
                if (!isPalindrome) return false;
            }
            return true;
        }

        public bool IsPalindrome(int ele)
        {
            string str = ele.ToString();
            int
                i = 0,
                j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j]) return false;
                i++;
                j--;
            }
            return true;
        }

        public int MedianOfArray(int[] arr)
        {
            Array.Sort (arr);
            int length = arr.Length;
            if (length % 2 == 0)
            {
                // Even length
                return (arr[length / 2] + arr[length / 2 - 1]) / 2;
            }
            else
            {
                // Odd Length
                return arr[length / 2];
            }
        }
    }

    public static class ArraysInitializer
    {
        public static void Initialize()
        {
            // IsPalindromic Array
            Console.WriteLine("IsPalindromic Array");
            int[] palindromicArray1 = { 121, 131, 20 };
            int[] palindromicArray2 = { 111, 121, 222, 333, 444 };
            Console
                .WriteLine("IsPalindrome1: " +
                new Arrays().IsPalindromicArray(palindromicArray1));
            Console
                .WriteLine("IsPalindrome2: " +
                new Arrays().IsPalindromicArray(palindromicArray2));

            // MedianOfArray
            Console.WriteLine("Median of array");
            int[] medianOfArray1 = { 90, 100, 78, 89, 67 };
            int[] medianOfArray2 = { 56, 67, 30, 79 };
            Console
                .WriteLine("Median of Array 1: " +
                new Arrays().MedianOfArray(medianOfArray1));
            Console
                .WriteLine("Median of Array 1: " +
                new Arrays().MedianOfArray(medianOfArray2));

            //
        }
    }
}
