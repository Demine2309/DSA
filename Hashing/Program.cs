namespace DSA
{
    #region First Repeat
    public class Solution
    {
        public char FirstRepeatedChar(string str)
        {
            int[] charFrequency = new int[58];

            for (int i = 65; i < 123; i++)
                charFrequency[i - 65] = 0;

            foreach (char s in str)
                charFrequency[s - 65]++;

            foreach (char s in str)
            {
                if (charFrequency[s - 65] > 0)
                    return s;
            }

            return '\0';
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string str = "woooooooooow";
            char result = solution.FirstRepeatedChar(str);

            if (result != '\0')
            {
                Console.WriteLine($"The first repeated character in \"{str}\" is: {result}");
            }
            else
            {
                Console.WriteLine($"No repeated characters found in \"{str}\".");
            }
        }
    }
    #endregion
}