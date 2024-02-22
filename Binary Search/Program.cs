namespace DSA
{
    public class Solution
    {
        public int BinarySearch(int[] arr, int low, int high, int key)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
               
                if (arr[mid] < key)
                    low = mid + 1;
                else if (arr[mid] > key)
                    high = mid - 1;
                else
                    return mid;
            }

            return -1;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] arr = { 7, 31, 5, 2, 3, 54, 23, 6, 1, 0, 4, 8 };
           
            Console.WriteLine("Array before sort:");
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();

            Console.WriteLine("Array after sort:");
            Array.Sort(arr);
            foreach (int i in arr) Console.Write(i + " ");
            Console.WriteLine();
            
            int target = 8;
            Console.WriteLine("The position of target...");
            Console.WriteLine(solution.BinarySearch(arr, 0, arr.Length-1,target) + 1);
        }
    }
}