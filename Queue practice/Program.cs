namespace DSA
{
    #region Problem 1: Maximum of all subarrays of size k
    //Given an array arr[] of size N and an integer K.Find the maximum for each and every contiguous subarray of size K.
    public class Solution
    {
        #region My solution
        //public int[] MaxOfSubarrays(int[] arr, int k)
        //{
        //    int n = arr.Length;
        //    int[] result = new int[n - k + 1];

        //    for (int i = 0; i < n - k + 1; i++)
        //    {
        //        int[] temp = new int[k];
        //        int l = i;

        //        for (int j = 0; j < k; j++)
        //        {
        //            temp[j] = arr[l];
        //            l++;
        //        }

        //        Array.Sort(temp);
        //        result[i] = temp[k - 1];
        //    }

        //    return result;
        //}
        #endregion

        #region Optimize it
        //public int[] MaxOfSubarrays(int[] arr, int k)
        //{
        //    int n = arr.Length;
        //    int[] result = new int[n - k + 1];

        //    // Find the maximum element in the first subarray of length k
        //    int maxIndex = 0;
        //    for (int i = 1; i < k; i++)
        //    {
        //        if (arr[i] > arr[maxIndex])
        //        {
        //            maxIndex = i;
        //        }
        //    }
        //    result[0] = arr[maxIndex];

        //    // Find the maximum element in the remaining subarrays
        //    for (int i = k; i < n; i++)
        //    {
        //        // If the previous maximum element is still within the current subarray,
        //        // compare it with the new element and update the maxIndex accordingly.
        //        if (arr[i] > arr[maxIndex])
        //        {
        //            maxIndex = i;
        //        }
        //        // If the previous maximum element is no longer within the current subarray,
        //        // find the maximum element by iterating through the current subarray.
        //        else if (maxIndex < i - k + 1)
        //        {
        //            maxIndex = i - k + 1;
        //            for (int j = i - k + 2; j <= i; j++)
        //            {
        //                if (arr[j] > arr[maxIndex])
        //                {
        //                    maxIndex = j;
        //                }
        //            }
        //        }

        //        result[i - k + 1] = arr[maxIndex];
        //    }

        //    return result;
        //}
        #endregion

        #region Use queue 
        public Queue<int> MaxOfSubarrays(int[] arr, int k)
        {
            int n = arr.Length;

            Queue<int> result = new Queue<int>();
            for (int i = 0; i < n - k + 1; i++)
            {
                int[] temp = new int[k];
                int l = i;

                for (int j = 0; j < k; j++)
                {
                    temp[j] = arr[l];
                    l++;
                }

                Array.Sort(temp);

                result.Enqueue(temp[k - 1]);
            }

            return result;
        }
        #endregion

        public void PrintArray(Queue<int> queue)
        {
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + "  ");
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 8, 5, 10, 7, 9, 4, 15, 12, 90, 13 };
            int k = 3;

            Queue<int> result = solution.MaxOfSubarrays(nums, k);

            solution.PrintArray(result);
        }
    }
    #endregion

}