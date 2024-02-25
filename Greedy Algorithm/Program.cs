namespace DSA
{
    public class Solution
    {
        #region Example: Being a very busy person, you have exactly T time to do some interseting things and you want to do maximum such things
        public int NumberOfThing(int[] A, int T)
        {
            int currentTime = A[0];
            int numberOfThing = 0;

            for(int i = 1; i < A.Length; i++)
            {
                if(currentTime <= T)
                {
                    currentTime += A[i];
                    numberOfThing++;
                }
            }

            return numberOfThing;
        }
        #endregion
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] A = { 5, 3, 4, 2, 1 };
            Array.Sort(A);

            int T = 6;

            Console.WriteLine(solution.NumberOfThing(A, T));
        }
    }
}