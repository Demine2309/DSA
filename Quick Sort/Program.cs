namespace DSA
{
    public class Solution
    {
        #region Quicksort in Programz
        //public int[] QuickSort(int[] array, int leftmostIndex, int rightmostIndex)
        //{
        //    if (leftmostIndex < rightmostIndex)
        //    {
        //        // find pivot element such that
        //        // elements smaller than pivot are on the left
        //        // elements greater than pivot are on the right
        //        int pivotIndex = Partition(array, leftmostIndex, rightmostIndex);

        //        // recursive call on the left of pivot
        //        QuickSort(array, leftmostIndex, pivotIndex - 1);

        //        // recursive call on the right of pivot
        //        QuickSort(array, pivotIndex + 1, rightmostIndex);
        //    }

        //    return array;
        //}

        //// Method to find the partition position
        //private int Partition(int[] array, int leftmostIndex, int rightmostIndex)
        //{
        //    // Choose the rightmost element as pivot
        //    int pivot = array[rightmostIndex];

        //    // Pointer for greater element
        //    int pointer = leftmostIndex - 1;

        //    // Traverse through all elements
        //    // compare each element with pivot
        //    for (int i = leftmostIndex; i < rightmostIndex; i++)
        //    {
        //        // if element smaller than pivot is found
        //        // swap it with the greatr element pointed by i
        //        if (array[i] <= pivot)
        //        {
        //            pointer++;

        //            // swapping element at pointer with element at j
        //            Swap(array, pointer, i);
        //        }
        //    }

        //    // swap the pivot element with the greater element specified by pointer
        //    Swap(array, pointer + 1, rightmostIndex);

        //    // return the position from where partition is done
        //    return pointer + 1;
        //}

        //private void Swap(int[] array, int i, int j)
        //{
        //    int temp = array[i];
        //    array[i] = array[j];
        //    array[j] = temp;
        //}

        //public void PrintArray(int[] array)
        //{
        //    foreach (int i in array)
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        #endregion

        #region Quicksort in Hackerearth
        Random rand = new Random();

        private int RandomPartition(int[] A, int start, int end)
        {
            int random = rand.Next(start, end);
            Swap(A, random, start);

            return Partition(A, start, end);
        }

        // Take the first element to make the pivot
        private int Partition(int[] A, int start, int end)
        {
            int i = start + 1;
            int pivot = A[start];

            for (int j = start + 1; j <= end; j++)
            {
                if (A[j] < pivot)
                {
                    Swap(A, i, j);
                    i++;
                }
            }

            Swap(A, start, i - 1);

            return i - 1;
        }

        public void QuickSort(int[] A, int start, int end)
        {
            if (start < end)
            {
                //int pivPos = Partition(A, start, end);

                // Let’s see the randomized version of the partition function :
                int pivPos = RandomPartition(A, start, end);

                QuickSort(A, start, pivPos - 1);
                QuickSort(A, pivPos + 1, end);
            }
        }

        private void Swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        #endregion


    }

    class MainClass
    {
        static void Main(string[] args)
        {
            #region Test above algorithm
            Solution solution = new Solution();

            int[] nums = { 9, 7, 8, -11, 14, 0, 3, 2, 1 };
            Console.WriteLine("Before sort:");
            solution.PrintArray(nums);

            solution.QuickSort(nums, 0, nums.Length - 1);
            Console.WriteLine("\nAfter sort:");
            solution.PrintArray(nums);
            #endregion
        }
    }
}
