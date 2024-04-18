namespace DSA
{
    #region Simple Array Implementation
    //public class ArrayStack
    //{
    //	static readonly int MAX = 1000;
    //	public int top;
    //	public int[] stack = new int[MAX];

    //       public ArrayStack()
    //       {
    //           top = -1;
    //       }

    //       // Time complexity: O(1)
    //	public bool IsEmpty()
    //	{
    //		return (top < 0);
    //	}

    //	// Time complexity: O(1)
    //	public bool IsFull()
    //	{
    //		return (top >= MAX - 1);
    //	}

    //	// Time complexity: O(1)
    //	public int Size()
    //	{
    //		return top + 1;
    //	}

    //	// Time complexity: O(1)
    //	public bool Push(int data)
    //	{
    //		if(top >= MAX)
    //		{
    //			Console.WriteLine("Stack is Overflow!");
    //			return false;
    //		}
    //		else
    //		{
    //			stack[top + 1] = data;
    //			top++;
    //			return true;
    //		}
    //	}

    //	// Time complexity: O(1)
    //	public int Pop()
    //	{
    //		if (top < 0)
    //		{
    //			Console.WriteLine("Stack is Underflow!");
    //			return 0;
    //		}
    //		else
    //		{
    //			int value = stack[top];
    //			top--;
    //			return value;
    //		}
    //	}

    //	// Time complexity: O(1)
    //	public void Peek()
    //	{
    //           if (top < 0)
    //           {
    //               Console.WriteLine("Stack is Underflow!");
    //               return;
    //           }
    //		else
    //		{
    //			Console.WriteLine($"The topmost element of Stack is {stack[top]}");
    //		}
    //       }

    //	// Time complexity: O(1)
    //	public void DeleteStack()
    //	{
    //		top = -1;
    //		Console.WriteLine("Stack has been deleted.");
    //	}


    //	// Time complexity: O(n)
    //	public void PrintStack()
    //	{
    //		if (top < 0)
    //		{
    //			Console.WriteLine("Stack Underflow");
    //			return;
    //		}
    //		else
    //		{
    //			Console.WriteLine("Items in the Stack are:");
    //			for (int i = 0; i <= top; i++)
    //			{
    //				Console.Write(stack[i] + " ");
    //			}

    //			Console.WriteLine();
    //		}
    //	}
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		ArrayStack stack = new ArrayStack();

    //		stack.Push(23);
    //		stack.Push(9);
    //		stack.Push(2);
    //		stack.Push(10);
    //		stack.Push(3);

    //		stack.PrintStack();

    //		stack.Pop();
    //		stack.Peek();

    //		stack.PrintStack();

    //		stack.DeleteStack();
    //		stack.PrintStack();
    //	}
    //}
    #endregion

    #region DynamicArrayImplementation
    //public class DynamicArrayStack
    //{
    //    private int[] stack;
    //    private int top;
    //    private int capacity;

    //    public DynamicArrayStack(int initialCapacity)
    //    {
    //        capacity = initialCapacity;
    //        stack = new int[capacity];
    //        top = -1;
    //    }

    //    public bool IsEmpty()
    //    {
    //        return top == -1;
    //    }

    //    public bool IsFull()
    //    {
    //        return top == capacity - 1;
    //    }

    //    public void Push(int data)
    //    {
    //        if (IsFull())
    //        {
    //             Double the array size
    //            capacity *= 2;
    //            int[] newStack = new int[capacity];
    //            Array.Copy(stack, newStack, stack.Length);
    //            stack = newStack;
    //        }

    //        stack[++top] = data;
    //    }

    //    public int Pop()
    //    {
    //        if (IsEmpty())
    //        {
    //            Console.WriteLine("Stack Underflow");
    //            return 0;
    //        }

    //        return stack[top--];
    //    }

    //    public int Peek()
    //    {
    //        if (IsEmpty())
    //        {
    //            Console.WriteLine("Stack Underflow");
    //            return 0;
    //        }

    //        return stack[top];
    //    }

    //    public int Size()
    //    {
    //        return top + 1;
    //    }

    //    public void PrintStack()
    //    {
    //        if (top < 0)
    //        {
    //            Console.WriteLine("Stack Underflow");
    //            return;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Items in the Stack are:");
    //            for (int i = 0; i <= top; i++)
    //            {
    //                Console.Write(stack[i] + " ");
    //            }

    //            Console.WriteLine();
    //        }
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        DynamicArrayStack myStack = new DynamicArrayStack(8);
    //        myStack.Push(10);
    //        myStack.Push(20);
    //        myStack.Push(30);
    //        myStack.Push(40);

    //        Console.WriteLine("Stack size: " + myStack.Size());
    //        Console.WriteLine("Top element: " + myStack.Peek());

    //        myStack.PrintStack();

    //        Console.WriteLine(myStack.Pop());
    //        myStack.PrintStack();
    //    }
    //}
    #endregion

    #region Linked List Implementation
    public class ListNode
    {
        public int data;
        public ListNode next;

        public ListNode(int data)
        {
            this.data = data;
            next = null;
        }
    }

    public class Stack
    {
        private ListNode top;

        public Stack()
        {
            top = null;
        }

        public bool IsEmptyStack()
        {
            return top == null;
        }

        public void Push(int data)
        {
            var newNode = new ListNode(data);
            newNode.next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int poppedData = top.data;
            top = top.next;
            return poppedData;
        }

        public int Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty.");

            return top.data;
        }

        public void DeleteStack()
        {
            top = null;

            Console.WriteLine("Stack has been deleted.");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(3);
            myStack.Push(9);
            myStack.Push(23);
            myStack.Push(13);

            Console.WriteLine(myStack.Pop());

            Console.WriteLine(myStack.Peek());
        }
    }
    #endregion
}