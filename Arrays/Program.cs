namespace DSA
{
    #region Jagged Array
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[][] jaggedArr = new int[][]
    //        {
    //            new int[] { 1,2,3,4},
    //            new int[] { 5, 6,9},
    //            new int[] { 89, 23},
    //            new int[] {0,45,78,53,99}
    //        };

    //        for (int n = 0; n < jaggedArr.Length; n++)
    //        {
    //            Console.Write($"Row({n}): ");

    //            for (int k = 0; k < jaggedArr[n].Length; k++)
    //            {
    //                Console.Write($"{jaggedArr[n][k]} ");
    //            }
    //            Console.WriteLine();
    //        }
    //    }
    //}
    #endregion

    #region Minimum Length
    class Solution
    {
        public int MinimumSubarrayLengthToMatchArrays(int[] A, int[] B)
        {
            int n = A.Length;
            int[] diff = new int[n];

            for (int i = 0; i < n; i++)
            {
                diff[i] = Math.Abs(A[i] - B[i]);
            }

            int totalDiff = diff.Sum();

            int left = 0, minLength = int.MaxValue, curDiff = 0;

            for (int right = 0; right < n; right++)
            {
                curDiff += diff[right];

                while (curDiff >= totalDiff)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    curDiff -= diff[left];
                    left++;
                }
            }

            return minLength;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] A = { 1, 1, 2, 1 };
            int[] B = { 2, 1, 1, 1 };

            int result = solution.MinimumSubarrayLengthToMatchArrays(A, B);

            Console.WriteLine(result);
        }
    }
    #endregion
}