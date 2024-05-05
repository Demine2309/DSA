namespace DSA
{
    #region Problem 1. Give an algorithm for reversing a queue Q. To access the queue, we are only allowed to use the methods of queue ADT.
    //public class Solution
    //{
    //	public void ReverseQueue(Queue<int> queue)
    //	{
    //		Stack<int> tempStack = new Stack<int>();

    //		while(queue.Count > 0)  
    //		{
    //			tempStack.Push(queue.Dequeue());
    //		}

    //		while(tempStack.Count > 0)
    //		{
    //			queue.Enqueue(tempStack.Pop());
    //		}
    //	}
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		Solution solution = new Solution();

    //		Queue<int> myQueue = new Queue<int>();
    //		myQueue.Enqueue(1);
    //		myQueue.Enqueue(2);
    //		myQueue.Enqueue(3);
    //		myQueue.Enqueue(4);
    //		myQueue.Enqueue(5);

    //		DisplayQueue(myQueue);

    //		solution.ReverseQueue(myQueue);

    //		DisplayQueue(myQueue);
    //	}

    //	static void DisplayQueue(Queue<int> queue)
    //	{
    //		if(queue.Count == 0)
    //		{
    //			Console.WriteLine("Queue is empty!");
    //			return;
    //		}

    //		foreach(int i in queue)
    //		{
    //			Console.Write(i + "  ");
    //		}

    //		Console.WriteLine();
    //	}
    //}
    #endregion

    #region Problem 2. How can you implement a queue using two stacks?
    //public class QueueWith2Stack
    //{
    //    Stack<int> stack1 = new Stack<int>();
    //    Stack<int> stack2 = new Stack<int>();

    //    public void EnQueue(int x)
    //    {
    //        stack1.Push(x);
    //    }

    //    public int DeQueue()
    //    {
    //        if(stack1.Count == 0 && stack2.Count == 0)
    //            throw new Exception("Queue is Empty!");

    //        if(stack2.Count == 0)
    //        {
    //            while(stack1.Count > 0)
    //            {
    //                stack2.Push(stack1.Pop());
    //            }
    //        }

    //        return stack2.Pop();
    //    }

    //    public int Front()
    //    {
    //        if (stack1.Count == 0 && stack2.Count == 0)
    //            throw new Exception("Queue is Empty!");

    //        if (stack2.Count == 0)
    //        {
    //            while (stack1.Count > 0)
    //            {
    //                stack2.Push(stack1.Pop());
    //            }
    //        }

    //        return stack2.Peek();
    //    }

    //    public int Count()
    //    {
    //        return stack1.Count + stack2.Count;
    //    }

    //    public void DisplayQueue()
    //    {
    //        if(stack1.Count == 0 && stack2.Count == 0)
    //        {
    //            Console.WriteLine("Queue is empty!");
    //            return;
    //        }

    //        Stack<int> tempStack = new Stack<int>();
    //        foreach (int item in stack1)
    //        {
    //            tempStack.Push(item);
    //        }

    //        foreach (int item in stack2)
    //        {
    //            Console.Write(item + " ");
    //        }

    //        foreach (int item in tempStack)
    //        {
    //            Console.Write(item + " ");
    //        }

    //        Console.WriteLine();
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        QueueWith2Stack myQueue = new QueueWith2Stack();
    //        myQueue.EnQueue(1);
    //        myQueue.EnQueue(2);
    //        myQueue.EnQueue(3);
    //        myQueue.EnQueue(4);
    //        myQueue.EnQueue(5);

    //        myQueue.DisplayQueue();

    //        myQueue.DeQueue();

    //        myQueue.DisplayQueue();

    //        myQueue.EnQueue(1);

    //        myQueue.DisplayQueue();
    //    }
    //}
    #endregion

    #region Problem 4. Maximum sum in sliding window
    /*
     * - Problem: Given array A[] with sliding window of size w which is moving from the very left of the array 
     *          to the very right. Assume that we can only see the w numbers in the window.Each time the sliding 
     *          window moves rightwards by one position. 
     * - For example: The array is [1 3 -1 -3 5 3 6 7], and w is 3
     */
    public class Solution
    {
        public int[] MaxSumInSlidingWindow(int[] arr, int w)
        {
            int n = arr.Length;
            int[] result = new int[n - w + 1];
            Queue<int> queue = new Queue<int>();

            int sum = 0;
            for (int i = 0; i < w; i++)
            {
                queue.Enqueue(arr[i]);
                sum += arr[i];
            }

            result[0] = sum;
            for (int i = w; i < n; i++)
            {
                sum -= queue.Dequeue() + arr[i];
                queue.Enqueue(arr[i]);
                result[i - w + 1] = sum;
            }

            return result;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] A = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int w = 3;

            int[] result = solution.MaxSumInSlidingWindow(A, w);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
    #endregion
}