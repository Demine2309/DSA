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
    public class Solution
    {
        public int ProductOfEvenNumbers(int i, int[] nums)
        {
            if (i == nums.Length)
                return 1;

            int value = 1;

            if (nums[i] % 2 == 0)
                value = nums[i];

            return ProductOfEvenNumbers(i + 1, nums) * value;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { 1, 2, 3, 4, 5 };

            Console.WriteLine(solution.ProductOfEvenNumbers(0, nums));
        }
    }
    #endregion
}