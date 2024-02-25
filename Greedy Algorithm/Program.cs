namespace DSA
{
    public class Solution
    {
        #region Example: Being a very busy person, you have exactly T time to do some interseting things and you want to do maximum such things
        //public int NumberOfThing(int[] A, int T)
        //{
        //    int currentTime = A[0];
        //    int numberOfThing = 0;

        //    for(int i = 1; i < A.Length; i++)
        //    {
        //        if(currentTime <= T)
        //        {
        //            currentTime += A[i];
        //            numberOfThing++;
        //        }
        //    }

        //    return numberOfThing;
        //}
        #endregion

        #region The scheduling problem
        public double CalculateObjectFunction(int[] P, int[] T, int N)
        {
            double[] S = new double[N]; // Array to store the scores
            double C = 0;               // Completion times
            double F = 0;               // Objective function

            for (int i = 0; i < N; i++)
            {
                S[i] = (double)P[i] / T[i];
            }

            Array.Sort(S);

            for (int i = 0; i < N; ++i)
            {
                int index = Array.IndexOf(S, (double)P[i] / T[i]);
                C += T[index];
                F += P[index] * C;
            }

            return F;
        }
        #endregion
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            #region Example 1
            //Solution solution = new Solution();

            //int[] A = { 5, 3, 4, 2, 1 };
            //Array.Sort(A);

            //int T = 6;

            //Console.WriteLine(solution.NumberOfThing(A, T));
            #endregion

            #region Example 2
            Solution solution = new Solution();

            int[] P = { 3, 1 };
            int[] T = { 5, 2 };
            int N = P.Length;

            double result = solution.CalculateObjectFunction(P, T, N);

            Console.WriteLine(result);
            #endregion
        }
    }
}