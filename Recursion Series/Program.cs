namespace DSA
{
    #region Recursive multiplication
    // Suppose you want to multiply two numbers: a*b. But the multiplication operator is broken on your computer and all loops dont seem
    // to work either...
    // Challenge: given these constraints, how would you implement multiplication?
    //public class Solution
    //{
    //	public int MultiplicationTwoNumbers(int a, int b)
    //	{
    //		if (b == 0)
    //			return 0;
    //		return MultiplicationTwoNumbers(a, b-1) + a;
    //	}
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		Solution solution = new Solution();

    //		int a = int.Parse(Console.ReadLine());
    //		int b = int.Parse(Console.ReadLine());

    //		Console.WriteLine(solution.MultiplicationTwoNumbers(a, b));
    //	}
    //}

    // The previous example showed how to implement	the multiplication function that supported values where a >= 0.
    // Challenge: Update the Mul(a, b) funtion to support values where a or b are less than 0.
    //public class Solution
    //{
    //    public int MultiplicationTwoNumbers(int a, int b)
    //    {
    //        if (b == 0)
    //            return 0;

    //        if (a < 0)
    //            return MultiplicationTwoNumbers(a, b + 1) - a;

    //        return MultiplicationTwoNumbers(a, b - 1) + a;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int a = int.Parse(Console.ReadLine());
    //        int b = int.Parse(Console.ReadLine());

    //        Console.WriteLine(solution.MultiplicationTwoNumbers(a, b));
    //    }
    //}
    #endregion

    #region Loops and Wrapper functions
    // Sum of the odds: Find the sum of all odd numbers in a list {2,3,-4,5,11,6,7}
    //public class Solution
    //{
    //    public int SumOfTheOdds(int i, int[] nums)
    //    {
    //        if (i == nums.Length)
    //            return 0;

    //        int value = 0;

    //        if (nums[i] % 2 != 0)
    //            value = nums[i];

    //        return SumOfTheOdds(i + 1, nums) + value;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] nums = { 2, 5, 4, 3, 7 };

    //        Console.WriteLine(solution.SumOfTheOdds(0, nums));
    //    }
    //}

    // The previous example we loocked at how to find the sum of all the odd numbers in a list, now find the product 
    // of all even numbers in a list
    // Challenge: Implement a function called ProductOfEvenNumber(list) that finds the
    //public class Solution
    //{
    //    public int ProductOfEvenNumbers(int i, int[] nums)
    //    {
    //        if (i == nums.Length)
    //            return 1;

    //        int value = 1;

    //        if (nums[i] % 2 == 0)
    //            value = nums[i];

    //        return ProductOfEvenNumbers(i + 1, nums) * value;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] nums = { 1, 2, 3, 4, 5 };

    //        Console.WriteLine(solution.ProductOfEvenNumbers(0, nums));
    //    }
    //}
    #endregion

    #region Strings & Palindromes
    // Reverse a string using Recursive call
    //public class Solution
    //{
    //    public string reverseString(/*int i,*/string s)
    //    {
    //        //if(i == s.Length) return "";
    //        //return reverseString(i + 1, s) + s[i];

    //        // Another way to reverse
    //        int n = s.Length;

    //        if (n <= 1) return s;

    //        char left = s[0], right = s[n - 1];

    //        string substring = s.Substring(1, n - 2);

    //        return right + reverseString(substring) + left;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        string s = "rotator";
    //        Console.WriteLine(solution.reverseString(/*0,*/ s));
    //    }
    //}

    // Problem 2: Verify palindrome
    //public class Solution
    //{
    //    private string reverseString(string s)
    //    {

    //        int n = s.Length;

    //        if (n <= 1) return s;

    //        char left = s[0], right = s[n - 1];

    //        string substring = s.Substring(1, n - 2);

    //        return right + reverseString(substring) + left;
    //    }

    //    public bool VerifyPalindrome(string s)
    //    {
    //        return s == reverseString(s);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        string s = "rotator";
    //        Console.WriteLine(solution.VerifyPalindrome(s));
    //    }
    //}
    #endregion

    #region Multiple return values 
    // Finding the maximum element in a list
    // Given a list of numbers, find the maximum element in the list and the index of that element using recursion
    // The main idea behind finding the maximum is to try all indices and update the best (max, index) pair we find
    //public class Solution
    //{
    //    public (int, int) FindMax(int i, List<int> list)
    //    {
    //        if (i == list.Count)
    //            return (int.MinValue, -1);

    //        (int bestMax, int bestIndex) = FindMax(i + 1, list);

    //        if(bestMax == null || list[i] > bestMax)
    //        {
    //            bestMax = list[i];
    //            bestIndex = i;
    //        }

    //        return (bestMax, bestIndex);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        List<int> lists = new List<int> { 2, 1, 3, -4, 2 };

    //        (int bestMax, int bestIndex) = solution.FindMax(0, lists);
    //        Console.WriteLine(bestMax + ", " + bestIndex);
    //    }
    //}

    // Matrix max challenge
    // Challenge: Implement a recursive function called FindMatrixMax(matrix) which finds the (row, column) index position of the 
    // largest element in the matrix. You can assume 'matrix' is a 2D array of rectangular proportions.
    //public class Solution
    //{
    //    public (int, int) FindMatrixMax(int row, int col, int[][] matrix)
    //    {
    //        if (row == matrix.Length)
    //            return (-1, -1);

    //        if (col == matrix[row].Length)
    //            return FindMatrixMax(row + 1, 0, matrix);

    //        (int maxRow, int maxCol) = FindMatrixMax(row, col + 1, matrix);

    //        if (maxRow == -1 || matrix[row][col] > matrix[maxRow][maxCol])
    //        {
    //            maxRow = row;
    //            maxCol = col;
    //        }

    //        return (maxRow, maxCol);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[][] matrix = new int[][]
    //        {
    //            new int[] { 1, 4, 5, 2, 3 },
    //            new int[] { 3, -4, 6, 12, 43 },
    //            new int[] { 31, 14, -5, 52, 73 },
    //            new int[] { 11, 24, 55, 32, 13 }
    //        };

    //        (int maxRow, int maxCol) = solution.FindMatrixMax(0, 0, matrix);
    //        Console.WriteLine(maxRow + ", " + maxCol);

    //        Console.WriteLine(matrix[maxRow][maxCol]);
    //    }
    //}
    #endregion

    #region Divide and Conquer: The art of breaking down problems
    // Rethinking finding the maximum
    // Instead of going through the array left to right we can also approach the problem by breaking it down into a 
    // simpler problem.
    // Notice that if we split the array into a left and a right component that finding the maximum of the left and
    // right array equals the maximum of the whole array
    // This process of breaking down the problem into simpler problems is called divide and conquer.
    //public class Solution
    //{
    //    public int FindMaximumElement(int[] arr)
    //    {
    //        if (arr.Length == 0) return int.MinValue;

    //        return FindMax(0, arr.Length - 1, arr);
    //    }

    //    private int FindMax(int i, int j, int[] arr)
    //    {
    //        if (i == j) return arr[i];

    //        int mid = (i + j) / 2;

    //        return Math.Max(FindMax(i, mid, arr), FindMax(mid + 1, j, arr));
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] arr = { 2, 1, 0, -4, 3, 6, 7, 5 };

    //        Console.WriteLine(solution.FindMaximumElement(arr));
    //    }
    //}

    // Challenge: Modify the divide and conquer example to return the minimum value while doing a three way search.
    // Hint: In the two way split example we split the segment in half at a single midpoint. Now we want to split 
    // it in three ways, which means we need 2 mid points instead of a single midpoint.
    public class Solution
    {
        public int FindMimimumElement(int[] arr)
        {
            if (arr.Length == 0) return int.MinValue;

            return FindMin(0, arr.Length - 1, arr);
        }

        private int FindMin(int i, int j, int[] arr)
        {
            // Handle size 1 interval
            if (i == j)
                return arr[i];
            // Handle size 2 interval
            if (j - i == 1)
                return Math.Min(arr[i], arr[i + 1]);
            // Handle size 3 interval
            if (j - i == 2)
                return Math.Min(arr[i], Math.Min(arr[i + 1], arr[i + 2]));

            int third = (j - i) / 3;
            int mid1 = i + third;
            int mid2 = i + 2 * third;

            int min1 = FindMin(i, mid1, arr);
            int min2 = FindMin(mid1 + 1, mid2, arr);
            int min3 = FindMin(mid2 + 1, j, arr);

            return Math.Min(min1, Math.Min(min2, min3));
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] arr = { 2, 9, -3, 4, 2, 0, 8, 3, 5 };

            Console.WriteLine(solution.FindMimimumElement(arr));
        }
    }
    #endregion
}