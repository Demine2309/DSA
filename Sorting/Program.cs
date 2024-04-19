namespace DSA
{
    #region Bubble Sort
    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };

    //		//BubbleSort(arr);
    //		BubbleSortImproved(arr);

    //		foreach(int i in arr)
    //			Console.Write(i + " ");
    //	}

    //	static void BubbleSort(int[] arr)
    //	{
    //		for(int pass = arr.Length-1; pass >= 0; pass--)
    //		{
    //			for(int i = 0; i < pass; i++)
    //			{
    //				if (arr[i] > arr[i+1])
    //				{
    //					int temp = arr[i];
    //					arr[i] = arr[i+1];
    //					arr[i+1] = temp;
    //				}
    //			}
    //		}
    //	}

    //	static void BubbleSortImproved(int[] arr)
    //	{
    //		int pass, i, temp, swapped =1;

    //		for(pass = arr.Length - 1; pass >= 0 && swapped == 1; pass--)
    //		{
    //			swapped = 0;
    //			for(i =0; i < pass; i++)
    //			{
    //				if (arr[i] > arr[i + 1])
    //				{
    //					temp = arr[i];
    //					arr[i] = arr[i + 1];
    //					arr[i+1] = temp;
    //					swapped = 1;
    //				}
    //			}
    //		}
    //	}
    //}

    //// Time complexity: Best case: O(n), worst case and average case: O(n^2)
    #endregion

    #region Selection Sort
    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 12, 5, 3, 6, 8, 213, 45, 2, 0, 23 };

    //        SelectionSort(arr);

    //        foreach (int i in arr)
    //        {
    //            Console.Write(i + " ");
    //        }
    //    }

    //    static void SelectionSort(int[] arr)
    //    {
    //        for(int i = 0; i < arr.Length - 1; i++)
    //        {
    //            int min = i;

    //            for(int j = i + 1; j < arr.Length; j++)
    //            {
    //                if (arr[j] < arr[min])
    //                {
    //                    min = j;
    //                }
    //            }

    //            int temp = arr[min];
    //            arr[min] = arr[i];
    //            arr[i] = temp;
    //        }
    //    }
    //}

    //// Time complexity: in all case is O(n^2)
    #endregion

    #region Insertion Sort

    #endregion
}