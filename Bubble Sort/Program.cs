namespace DSA
{
    #region Bubble Sort tutorial
    public class Solution
    {
        #region Basic Bubble sort algorithm
        //public int[] BubbleSort(int[] nums)
        //{
        //    int step = nums.Length - 1;
        //    while (step > 0)
        //    {
        //        for (int i = 0; i < step; i++)
        //        {
        //            if (nums[i] > nums[i + 1])
        //            {
        //                Swap(nums, i, i + 1);
        //            }
        //        }
        //        step--;
        //    }

        //    return nums;
        //}
        #endregion

        #region Another way
        public int[] BubbleSort(int[] nums)
        {
            int n = nums.Length;
            while (n > 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        Swap(nums, i, i + 1);
                    }
                }

                n--;
            }

            return nums;
        }
        #endregion

        #region Optimize this Algorithm
        //public int[] BubbleSort(int[] nums)
        //{

        //    for (int i = 0; i < nums.Length - 1; i++)
        //    {
        //        bool swapped = false;
        //        for (int j = 0; j < nums.Length - i - 1; j++)
        //        {
        //            if (nums[j] > nums[j + 1])
        //            {
        //                Swap(nums, j, j + 1);
        //                swapped = true;
        //            }
        //        }
        //        if (!swapped)
        //            break;
        //    }

        //    return nums;
        //}
        #endregion

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] nums = { -2, 45, 0, 11, -9, -29, 12, 45, 2, 41, 3455 };
            Console.WriteLine("Before sort:");
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }

            int[] result = solution.BubbleSort(nums);

            Console.WriteLine("\nAfter sort:");
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }

        }
    }
    #endregion

    #region Problem 1. Ants on a circle
    //public class Solution
    //{
    //    public List<int> CalculateFinalPositions(int N, List<(int position, int direction)> M, int T)
    //    {
    //        // Simulate the movement of M for T seconds
    //        for (int i = 0; i < T; i++)
    //        {
    //            for (int j = 0; j < M.Count; j++)
    //            {
    //                // Update the position of each ant based on its direction
    //                M[j] = (M[j].position + M[j].direction, M[j].direction);
    //            }


    //            // Check for collisions and change direction if needed
    //            for (int a = 0; a < M.Count; a++)
    //            {
    //                for (int b = a + 1; b < M.Count; b++)
    //                {
    //                    if (M[a].position == M[b].position)
    //                    {
    //                        M[a] = (M[a].position, -M[a].position);
    //                        M[b] = (M[b].position, -M[b].position);
    //                    }
    //                }
    //            }
    //        }

    //        // Extract the final positions of M
    //        List<int> finalPosition = new List<int>();
    //        foreach (var m in M)
    //        {
    //            finalPosition.Add(m.position);
    //        }

    //        return finalPosition;
    //    }

    //    public void BubbleSort(List<int> list)
    //    {
    //        int step = list.Count - 1;
    //        while (step > 0)
    //        {
    //            for (int i = 0; i < step; i++)
    //            {
    //                if (list[i] > list[i + 1])
    //                {
    //                    Swap(list, i, i + 1);
    //                }
    //            }
    //            step--;
    //        }
    //    }

    //    private void Swap(List<int> list, int i, int j)
    //    {
    //        int temp = list[i];
    //        list[i] = list[j];
    //        list[j] = temp;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        int[] input = new int[3];
    //        Console.WriteLine("Import value of N, M and T...");
    //        // Import value of N, M and T
    //        for (int i = 0;i<input.Length;i++)
    //        {
    //            input[i] = int.Parse(Console.ReadLine());
    //        }

    //        int N = input[0];
    //        int M = input[1];
    //        int T = input[2];

    //        List<(int position, int direction)> ants = new List<(int, int)>();

    //        for (int i = 0; i < M; i++)
    //        {
    //            int[] antInput = new int[2];
    //            Console.WriteLine($"Import position and direction of the {i + 1} ant...");
    //            for(int ant = 0; ant < antInput.Length; ant++)
    //            {

    //                antInput[ant] = int.Parse(Console.ReadLine());
    //            }
    //            int position = antInput[0];
    //            int direction = antInput[1];
    //            ants.Add((position, direction));
    //        }

    //        List<int> finalPositions = solution.CalculateFinalPositions(N, ants, T);

    //        // Sort final positions manually with Bubble sort
    //        //for (int i = 0; i < finalPositions.Count - 1; i++)
    //        //{
    //        //    for (int j = i + 1; j < finalPositions.Count; j++)
    //        //    {
    //        //        if (finalPositions[i] > finalPositions[j])
    //        //        {
    //        //            int temp = finalPositions[i];
    //        //            finalPositions[i] = finalPositions[j];
    //        //            finalPositions[j] = temp;
    //        //        }
    //        //    }
    //        //}
    //        solution.BubbleSort(finalPositions);    

    //        Console.WriteLine(string.Join(" ", finalPositions));
    //    }
    //}
    #endregion
}