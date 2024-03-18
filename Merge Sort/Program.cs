namespace DSA
{
    public class Solution
    {
        #region Merge Sort
        // Divide the array into two subarrays, sort them and merge them
        public void MergeSort(int[] arr, int start, int end)
        {
            if (start > end)
                return;
            else if (start < end)
            {
                // m is the point where the array is divided into two subarrays
                int mid = (start + end) / 2;

                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);

                // Merge the sorted subarrays
                Merge(arr, start, mid, end);
            }
        }

        // Merge two subarrays L and R int to arr
        private void Merge(int[] arr, int start, int mid, int end)
        {
            // Create L ← A[p..q] and R ← A[q+1..r]
            int n1 = mid - start + 1;
            int n2 = end - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int a = 0; a < n1; a++)
                L[a] = arr[start + a];
            for (int b = 0; b < n2; b++)
                R[b] = arr[mid + 1 + b];

            // Maintain current index of sub-arrays and main array
            int i = 0, j = 0, k = start;

            // Until we reach end of either L or R, pick larger among
            // elements L and M and place them in the correct position at A[p..r]

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // When we run out of elements in either L or M,
            // pick up the remaining elements and put in A[p..r]
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        public void Print(int[] nums)
        {
            foreach (int i in nums)
                Console.Write(i + " ");
        }
        #endregion

        #region Merge Sort in Hackerearth 
        //public void MergeSort(int[] array, int start, int end)
        //{
        //    if(start < end)
        //    {
        //        // Difines the current array in 2 parts
        //        int mid = (start + end) / 2;

        //        // Sort the 1st part of array
        //        MergeSort(array, start, mid);

        //        // Sort the 2nd part of array
        //        MergeSort(array, mid + 1, end);

        //        // Merge the both parts by comparing elements of both the parts
        //        Merge(array, start, mid, end);
        //    }
        //}

        //private void Merge(int[] array, int start, int mid, int end)
        //{
        //    // Stores the starting position of both parts in temporary variables
        //    int p = start, q = mid + 1, k = 0;
        //    int[] A = new int[end - start + 1];

        //    for (int i = start; i <= end; i++)
        //    {
        //        // Check if first part comes to an end or not.
        //        if (p > mid)
        //            A[k++] = array[q++];
        //        // Check if the second part comes to an end or not
        //        else if (q > end)
        //            A[k++] = array[p++];
        //        // Check which part has smaller element 
        //        else if (array[p] < array[q])
        //            A[k++] = array[p++];
        //        else
        //            A[k++] = array[q++];
        //    }

        //    for (int j = 0; j < k; j++)
        //    {
        //        // Now the real array has elements in sorted manner including both parts.
        //        array[start++] = A[j];
        //    }
        //}

        //// Print array
        //public void Print(int[] nums)
        //{
        //    foreach (int i in nums)
        //        Console.Write(i + " ");
        //}
        #endregion
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 23, 5, -2, 21, 3, 15, 304, 0, -34, -6 };
            Console.WriteLine("Before sort:");
            solution.Print(nums);

            solution.MergeSort(nums, 0, nums.Length - 1);
            Console.WriteLine("\nAfter sort:");
            solution.Print(nums);
        }
    }
}

#region Quiz Merge sort
/*
 * 1. Quick Sort is not a stable sorting algorithm in its typical implementation
 * 2. A: You have to sort 1 GB of data with only 100 MB of available main memory. Which sorting technique will be most appropriate? 
 *    Q: Merge sort
 *    Explain: The data can be sorted using external sorting which uses merging technique. This can be done as follow: 1. Divide the data into 10 groups each of size 100
 *             2. Sort each group and write them to disk, 3. Load 10 items from each group into main memory, 4. Output the smallest item from the main memory to disk. Load the
 *             next item from the group whose item was chosen, 5. Loop step #4 until all items are not outputted. The step 3-5 is called as merging technique.
 */
#endregion
