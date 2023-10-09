namespace DSA
{
    #region Jagged Array
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[][] jaggedArr = new int[][]
    //        {
    //            new int[] { 1,2,3,4},
    //            new int[] { 5, 6,9},
    //            new int[] { 89, 23},
    //            new int[] {0,45,78,53,99}
    //        };

    //        for (int n = 0; n < jaggedArr.Length; n++)
    //        {
    //            Console.Write($"Row({n}): ");

    //            for (int k = 0; k < jaggedArr[n].Length; k++)
    //            {
    //                Console.Write($"{jaggedArr[n][k]} ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}
    #endregion

    #region Minimum Length
    //class Solution
    //{
    //    public int MinimumSubarrayLengthToMatchArrays(int[] A, int[] B)
    //    {
    //        int n = A.Length;
    //        int[] diff = new int[n];

    //        for (int i = 0; i < n; i++)
    //        {
    //            diff[i] = Math.Abs(A[i] - B[i]);
    //        }

    //        int totalDiff = diff.Sum();

    //        int left = 0, minLength = int.MaxValue, curDiff = 0;

    //        for (int right = 0; right < n; right++)
    //        {
    //            curDiff += diff[right];

    //            while (curDiff >= totalDiff)
    //            {
    //                minLength = Math.Min(minLength, right - left + 1);
    //                curDiff -= diff[left];
    //                left++;
    //            }
    //        }

    //        return minLength;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] A = { 1, 1, 2, 1 };
    //        int[] B = { 2, 1, 1, 1 };

    //        int result = solution.MinimumSubarrayLengthToMatchArrays(A, B);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Array Class
    //// C# program to creating an array of the string as coffee name, store coffee name in the store, and prints each value.
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Declares an 1-D array of string
    //        string[] store;

    //        store = new string[]
    //        {
    //            "Americano, ",
    //            "Cafe au lait, ",
    //            "Epresso, ",
    //            "Cappuccino, ",
    //            "Long Black, ",
    //            "Macchiato."
    //        };

    //        Console.WriteLine("Different types of coffee:");
    //        Console.WriteLine();
    //        foreach (string s in store)
    //        {
    //            Console.WriteLine(s);
    //        }

    //        Console.WriteLine($"\nLength of the array: {store.Length}");
    //        Console.WriteLine($"\nRank of the array: {store.Rank}");

    //        Array.Reverse( store );
    //        Console.WriteLine("Different types of coffee:");
    //        Console.WriteLine();
    //        foreach (string s in store)
    //        {
    //            Console.WriteLine(s);
    //        }
    //    }
    //}
    #endregion

    #region Kadane's Algorithm
    //class Solution
    //{
    //    public long MaxSubarraySum(int[] arr, int n) 
    //    {
    //        long result = arr[0];    

    //        for(int i = 0; i < n; i++)
    //        {
    //            int currentSum = 0;

    //            for(int j = i; j < n; j++)
    //            {
    //                currentSum = currentSum + arr[j];

    //                if(currentSum > result)
    //                {
    //                    result = currentSum;
    //                }
    //            }
    //        }
    //        return result;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { -1, -2, -3, 0, -5, 6, -7 };

    //        long result = solution.MaxSubarraySum(arr, arr.Length);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Subarray with given Sum
    class Solution
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


        }
    }
    #endregion
}