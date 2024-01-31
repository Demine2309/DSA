namespace DSA
{
    public class Solution
    {
        #region Way 1:
        //public int[] InsertionSort(int[] nums)
        //{
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        int key = i;
        //        for (int j = key - 1; j >= 0; j--)
        //        {
        //            if (nums[j] > nums[key])
        //            {
        //                Swap(nums, j, key);
        //                key--;
        //            }
        //        }
        //    }

        //    return nums;
        //}

        //public void Swap(int[] nums, int i, int j)
        //{
        //    int temp = nums[i];
        //    nums[i] = nums[j];
        //    nums[j] = temp;
        //}
        #endregion

        #region Way 2:
        public int[] InsertionSort(int[] nums)
        {
            for(int i = 0;  i < nums.Length; i++)
            {
                int temp = nums[i];
                int j = i;
                while(j>0 && nums[j - 1] > temp)
                {
                    nums[j] = nums[j - 1];
                    j--;
                }

                nums[j] = temp;
            }

            return nums;
        }
        #endregion
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 9, 5, 1, 4, 3 };
            Console.WriteLine("Before sort:");
            foreach(int i in nums)
            {
                Console.Write(i + " ");
            }

            int[] result = solution.InsertionSort(nums);

            Console.WriteLine("\nAfter sort:");
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}