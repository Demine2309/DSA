namespace DSA
{
    #region Unordered Linear Search
    //public class Solution
    //{
    //    public int UnorderedLinearSearch(int[] arr, int data)
    //    {
    //        for(int i = 0; i < arr.Length; i++)
    //        {
    //            if (arr[i] == data)
    //                return i;
    //        }

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };

    //        Console.WriteLine(solution.UnorderedLinearSearch(arr, 23));
    //    }
    //}

    //// Time Complexity: O(n)
    #endregion

    #region Ordered/Sorted Linear Search
    //public class Solution
    //{
    //    public int OrderedLinearSearch(int[] arr, int data)
    //    {
    //        for(int i = 0; i < arr.Length; i++)
    //        {
    //            if (arr[i] == data)
    //                return i;
    //            else if (arr[i] > data)
    //                return -1;
    //        }

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };

    //        Console.WriteLine(solution.OrderedLinearSearch(arr, 23));
    //    }
    //}

    //// Time Complexity: O(n)
    #endregion

    #region Binary Search
    //public class Solution
    //{
    //    // Iterative Binary Search
    //    public int BinarySearchIterative(int[] arr, int data)
    //    {
    //        int low = 0, high = arr.Length - 1;

    //        while (low <= high)
    //        {
    //            int mid = (low + high) / 2;
    //            if (arr[mid] == data)
    //                return mid;
    //            else if (arr[mid] < data)
    //                low = mid + 1;
    //            else
    //                high = mid - 1;
    //        }

    //        return -1;
    //    }

    //    // Recursive Binary Search
    //    public int BinarySearchRecursive(int[] arr, int low, int high, int data)
    //    {
    //        int mid = (low + high) / 2;

    //        if (low > high)
    //            return -1;

    //        if (arr[mid] == data)
    //            return mid;
    //        else if (arr[mid] < data)
    //            return BinarySearchRecursive(arr, mid + 1, high, data);
    //        else
    //            return BinarySearchRecursive(arr, low, mid - 1, data);

    //        return -1;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };

    //        Array.Sort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }

    //        //Console.WriteLine("\n" + solution.BinarySearchIterative(arr, 56));

    //        Console.WriteLine("\n" + solution.BinarySearchRecursive(arr, 0, arr.Length - 1, 56));
    //    }
    //}

    //// Time complexity: O(logn)
    #endregion

    #region Interpolation Search
    public class Solution
    {
        public int InterpolationSearch(int[] arr, int data)
        {
            int low = 0, high = arr.Length - 1;

            while (low < high)
            {
                int mid = low + (((data - arr[low]) * (high - low)) / (arr[high] - arr[low]));

                if (data == arr[mid])
                    return mid;

                if (data < arr[mid])
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] arr = { 12, 5, 48, 5, 4, 13, 5, 4, 56, 1, 2, 84, 5, 1, 2, 4, 51, 5, 4, 5, 1, 54, 8, 48, 51 };

            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n" + solution.InterpolationSearch(arr, 56));
        }
    }

    // Time complexity: In average case: O(log(logn)), in worst case: O(n)
    #endregion

    #region MyRegion

    #endregion
}