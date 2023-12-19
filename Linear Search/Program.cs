namespace DSA
{
    public class Solution
    {
        public int LinearSearch(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] arr = { 10, 50, 30, 70, 80, 20, 90, 40 };
            int key = 30;

            int result = solution.LinearSearch(arr, key);

            if (result == -1)
                Console.WriteLine("No match found");
            else
                Console.WriteLine($"The location of the key is located in the location: {result + 1}");
        }
    }
}