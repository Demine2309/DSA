namespace DSA
{
    public class Solution
    {
        public int[] SelectionSort(int[] nums)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[minIndex])
                    {
                        minIndex = j;
                    }
                }
                Swap(nums, i, minIndex);
            }

            return nums;
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 20, 12, 10, 15, 2 };
            Console.WriteLine("Before sort:");
            foreach(int i in nums)
            {
                Console.Write(i + " ");
            }

            int[] result = solution.SelectionSort(nums);

            Console.WriteLine("\nAfter sort");
            foreach(int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}