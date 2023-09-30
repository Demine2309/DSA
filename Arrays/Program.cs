namespace DSA
{
    #region Jagged Array
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[][]
            {
                new int[] { 1,2,3,4},
                new int[] { 5, 6,9},
                new int[] { 89, 23},
                new int[] {0,45,78,53,99}
            };

            for (int n = 0; n < jaggedArr.Length; n++)
            {
                Console.Write($"Row({n}): ");

                for (int k = 0; k < jaggedArr[n].Length; k++)
                {
                    Console.Write($"{jaggedArr[n][k]} ");
                }
                Console.WriteLine();
            }
        }
    }
    #endregion
}