namespace DSA
{
    public class Solution
    {
        public int[] InsertionSort(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                int key = i;
                for(int j = key - 1; j >=0; j--)
                {
                    if (nums[j] > nums[key])
                    {
                        Swap(nums, j, key);
                        key--;
                    }
                }
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