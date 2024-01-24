namespace DSA
{
    #region Tutorial
    //public class Solution
    //{
    //    public int[] SelectionSort(int[] nums)
    //    {
    //        for (int i = 0; i < nums.Length - 1; i++)
    //        {
    //            int minIndex = i;
    //            for (int j = i + 1; j < nums.Length; j++)
    //            {
    //                if (nums[j] < nums[minIndex])
    //                {
    //                    minIndex = j;
    //                }
    //            }
    //            Swap(nums, i, minIndex);
    //        }

    //        return nums;
    //    }

    //    public void Swap(int[] nums, int i, int j)
    //    {
    //        int temp = nums[i];
    //        nums[i] = nums[j];
    //        nums[j] = temp;
    //    }
    //}

    //public class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] nums = { 20, 12, 10, 15, 2 };
    //        Console.WriteLine("Before sort:");
    //        foreach (int i in nums)
    //        {
    //            Console.Write(i + " ");
    //        }

    //        int[] result = solution.SelectionSort(nums);

    //        Console.WriteLine("\nAfter sort");
    //        foreach (int i in result)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }
    //}
    #endregion

    #region Problem
    /*
     * Some people remain old fashioned and John is one of them. He doesn't like the new smart phones with full keypads and still uses the old keypads
     * which require you to tap a key multiple times to type a single letter. For example, if the keyboard has two keys, one with the letters "adef" 
     * and the other one with the letters "zyx", then typing 'a' requires one keystroke, typing 'f' requires four keystrokes, typing 'y' requires two 
     * keystrokes, and so on.
     * 
     * He recently moved to a new country where the language is such that his keypad is not the most efficient. In every language some characters occur
     * more often than others. He wants to create a specific keyboard for this language that uses N different letters. He has a large body of text in 
     * this language, and has already analyzed it to find the frequencies of all N letters of its alphabet.
     * 
     * You are given an array 'frequencies' with N elements. Each element of frequencies is the number of times one of the letters in the new language
     * appears in the text John has. Each element of frequencies will be strictly positive. (I.e., each of the N letters occurs at least once.
     * 
     * You are also given an array keySize. The number of elements of keySize is the number of keys on the keyboard. Each element of keySize gives the 
     * maximal number of letters that maybe put on one of the keys.
     * 
     * Find an assignment of letters to keys that minimizes the number of keystrokes needed to type the entire text. Output that minimum number of 
     * keystrokes. If there is not enough room on the keys and some letters of the alphabet won't fit, Output -1 instead.
     */

    public class Solution
    {

    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();


        }
    }
    #endregion
}