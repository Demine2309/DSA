namespace DSA
{
    #region Problem 1: Discuss Towers of Hanoi puzzle
    //public class Solution
    //{
    //	public void TowerOfHanoi(int n, char fromPeg, char toPeg, char auxPeg) // A: fromPeg, B: topPeg, C: auxPeg
    //	{
    //		if (n == 1)
    //		{
    //			Console.WriteLine($"Move disk 1 from peg {fromPeg} to peg {toPeg}");
    //			return;
    //		}

    //		// Move top n - 1 disks from A to B, using C as auxiliary
    //		TowerOfHanoi(n - 1, fromPeg, auxPeg, toPeg);

    //		// Move remaining disks from A to C
    //		Console.WriteLine($"Move disk {n} from peg {fromPeg} to peg {toPeg}");

    //		// Move n-1 disks from B to C using A as auxiliary
    //		TowerOfHanoi(n - 1, auxPeg, toPeg, fromPeg);
    //	}
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		Solution solution = new Solution();

    //		int n = 4; // The number of disks

    //		Console.WriteLine("Start...");

    //		solution.TowerOfHanoi(n, 'A', 'B', 'C');

    //		Console.WriteLine("End!");
    //	}
    //}
    #endregion

    #region Problem 2: Given an array, check whether the array is in sorted order with recursion
    //public class Solution
    //{
    //	public bool CheckArrayIsSorted(int[] arr, int n)
    //	{
    //		if(n == 1)
    //			return true;

    //		if (arr[n - 1] < arr[n - 2])
    //			return false;

    //		return CheckArrayIsSorted(arr, n - 1);
    //	}
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		Solution solution = new Solution();

    //		int[] arr = { 2, 4, 25, 8, 12, 15, 23 };

    //		Console.WriteLine(solution.CheckArrayIsSorted(arr, arr.Length));
    //	}
    //}

    //// Time complexity: O(n)
    #endregion

    #region Problem 3: Generate all the strings of n bits. Assume A[0...n-1] is an array of size n
    //public class Solution
    //{
    //    public void GenerateBitStrings(int[] arr, int n)
    //    {
    //        if (n < 1)
    //            PrintArray(arr);
    //        else
    //        {
    //            arr[n - 1] = 0;
    //            GenerateBitStrings(arr, n - 1);
    //            arr[n - 1] = 1;
    //            GenerateBitStrings(arr, n - 1);
    //        }
    //    }

    //    private void PrintArray(int[] arr)
    //    {
    //        for (int i = arr.Length - 1; i >= 0; i--)
    //        {
    //            Console.Write(arr[i]);
    //        }

    //        Console.WriteLine();
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int n = 3;
    //        int[] arr = new int[n];

    //        solution.GenerateBitStrings(arr, n);
    //    }
    //}
    #endregion

    #region Problem 4: Generate all the strings of length n drawn from 0...k-1
    public class Solution
    {
        public void GenerateAllStrings(int[] arr, int n, int k)
        {
            if (n < 1)
                PrintArray(arr);
            else
            {
                for (int i = 0; i < k; i++)
                {
                    arr[n - 1] = i;
                    GenerateAllStrings(arr, n - 1, k);
                }
            }
        }

        private void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i);
            }

            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 3;
            int k = 9;

            int[] arr = new int[n];

            solution.GenerateAllStrings(arr, n, k);
        }
    }
    #endregion

    #region Problem 5: Finding the length of connected cells of 1s (regions) in an matrix of 0s and 1s
    /*
     * Given a matrix, each of which may be 1 or 0. The filled cells that are connected form a region. 
     * Two cells are said to be connected if they are adjacent to each other horizontally, vertically 
     * or diagonally. There may be several regions in the matrix. How do you find the largest region
     * (in terms of number of cells) in the matrix?
     */


    #endregion
}