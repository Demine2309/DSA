namespace DSA
{
    #region Problem 1: Implement Stack using Linked List
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