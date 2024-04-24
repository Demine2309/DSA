namespace DSA
{
    #region Fibonacci Series
    public class Solution
    {
        private Dictionary<int, int> memo = new Dictionary<int, int>();

        public int FibonacciSeriesBU(int n)
        {
            if(n <= 1) return n;

            memo[0] = 1;
            memo[1] = 1;

            for (int i = 2; i < n; i++)
                memo[i] = memo[i - 1] + memo[i - 2];

            return memo[n - 1];
        }

        public int FibonacciSeriesTD(int n)
        {
            if (n <= 1) return n;

            if (memo.ContainsKey(n)) return memo[n];

            memo[n] = FibonacciSeriesTD(n - 1) + FibonacciSeriesTD(n - 2);

            return memo[n - 1];
        }

        // Further improving
        public int FibonacciImprove(int n)
        {
            int a = 0, b = 1, sum = 0;
            for(int i = 1; i < n; i++)
            {
                sum = a + b;
                a = b; b = sum;
            }

            return sum;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.FibonacciSeriesBU(5));

            Console.WriteLine(solution.FibonacciSeriesTD(5));

            Console.WriteLine(solution.FibonacciImprove(5));
        }
    }
    #endregion
}