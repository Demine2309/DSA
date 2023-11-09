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
    //class Solution
    //{
    //    #region My way:
    //    //public List<int> SubarraySum(int[] arr, int n, int s)
    //    //{
    //    //    List<int> result = new List<int>();

    //    //    int startIndex = 0;
    //    //    int endIndex = 0;
    //    //    bool isResult = false;

    //    //    for (int i = 0; i < n; i++)
    //    //    {
    //    //        startIndex = i + 1;
    //    //        int sum = 0;

    //    //        if (arr[i] == s)
    //    //        {
    //    //            result.Add(startIndex);
    //    //            isResult = true;
    //    //            break;
    //    //        }

    //    //        for (int j = i; j < n; j++)
    //    //        {
    //    //            sum += arr[j];
    //    //            if (sum == s)
    //    //            {
    //    //                endIndex = j + 1;
    //    //                isResult = true;
    //    //                result.Add(startIndex);
    //    //                result.Add(endIndex);
    //    //                break;
    //    //            }
    //    //        }

    //    //        if (isResult == true)
    //    //            break;
    //    //    }

    //    //    if (isResult == false)
    //    //    {
    //    //        result.Add(-1);
    //    //    }

    //    //    return result;
    //    //}

    //    //public void PrintList(List<int> list)
    //    //{
    //    //    foreach (int i in list)
    //    //    {
    //    //        Console.Write(i + " ");
    //    //    }
    //    //}
    //    #endregion

    //    #region Optimized version
    //    public List<int> SubarraySum(int[] arr, int n, int s)
    //    {
    //        List<int> result = new List<int>();

    //        int sum = 0;
    //        int startIndex = 0;

    //        for(int endIndex = 0; endIndex < n; endIndex++)
    //        {
    //            sum += arr[endIndex];

    //            while(sum > s)
    //            {
    //                sum -= arr[startIndex];
    //                startIndex++;
    //            }

    //            if(sum == s)
    //            {
    //                result.Add(startIndex + 1);
    //                result.Add(endIndex + 1);
    //                return result;
    //            }
    //        }

    //        result.Add(-1);
    //        return result;
    //    }

    //    public void PrintList(List<int> list)
    //    {
    //        foreach(int i in list)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }
    //    #endregion
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 1, 2, 3, 7, 5 };
    //        int s = 12;

    //        List<int> result = solution.SubarraySum(arr, arr.Length, s);
    //        solution.PrintList(result);
    //    }
    //}
    #endregion

    #region Multi-dimensional
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[,] arr = new int[3, 5]
    //        {
    //            { 5, 12, 17, 9, 3 },
    //            { 13, 4, 8, 14, 1 },
    //            { 9, 6, 3, 7, 21 }
    //        };

    //        for(int i = 0; i< 3; i++)
    //        {
    //            for(int j = 0; j< 5; j++)
    //            {
    //                Console.Write(arr[i, j] + " ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}
    #endregion

    #region Jagged Array    
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];

            //Initializing each row with different column size
            //Uisng one dimensional array
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[4];
            arr[3] = new int[5];

            Console.WriteLine("Printing the Default Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                //arr[i].Length: Returns the Length of Each Row
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int num = 10;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    num++;
                    arr[i][j] = num;
                }
            }

            Console.WriteLine("\n\nPrinting the Values of Jagged Array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                foreach (int x in arr[i])
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine() ;
            }

            Console.ReadKey();
        }
    }
    #endregion
}