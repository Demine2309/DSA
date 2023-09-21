namespace DSA
{
    public class Stack
    {
        private int[] arr;
        private int top;
        private int capacity;

        // Creating a stack

        public Stack(int size)
        {
            arr = new int[size];
            capacity = size;
            top = -1;
        }

        // Add element into stack
        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full!!!");
                return;
            }

            Console.WriteLine("Inserting " + value);
            arr[++top] = value;
        }

        // Remove element from stack
        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack Empty!!!!");
            }
            return arr[top--];
        }

        // Utility function to return the size of the stack
        public int size()
        {
            return top + 1;
        }

        // Check if the stack is full
        public bool IsFull()
        {
            return top == capacity - 1;
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return top == -1;
        }

        public void PrintStack()
        {
            for(int i = 0; i <= top; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);  

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.PrintStack();


            stack.Pop();
            Console.WriteLine("After popping:");
            stack.PrintStack();

            Console.ReadKey();
        }
    }
}