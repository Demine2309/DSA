namespace DSA
{
    #region Problem 1: Implement Stack using Linked List
    //public class ListNode
    //{
    //    public int Data;
    //    public ListNode Next;

    //    public ListNode(int data)
    //    {
    //        Data = data;
    //        Next = null;
    //    }
    //}

    //public class Stack
    //{
    //    private ListNode top;

    //    public Stack()
    //    {
    //        top = null;
    //    }

    //    public bool IsEmptyStack()
    //    {
    //        return top == null;
    //    }

    //    public void Push(int data)
    //    {
    //        var newNode = new ListNode(data);
    //        newNode.Next = top;
    //        top = newNode;
    //    }

    //    public int Pop()
    //    {
    //        if (top == null)
    //        {
    //            throw new InvalidOperationException("Stack is empty.");
    //        }

    //        int poppedData = top.Data;
    //        top = top.Next;
    //        return poppedData;
    //    }

    //    public int Peek()
    //    {
    //        if (top == null)
    //            throw new InvalidOperationException("Stack is empty.");

    //        return top.Data;
    //    }

    //    public void DeleteStack()
    //    {
    //        top = null;

    //        Console.WriteLine("Stack has been deleted.");
    //    }

    //    public void DisplayStack()
    //    {
    //        ListNode current = top;

    //        while (current != null)
    //        {
    //            Console.Write($"{current.Data}   ");
    //            current = current.Next;
    //        }

    //        Console.WriteLine();
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Stack myStack = new Stack();
    //        myStack.Push(3);
    //        myStack.Push(9);
    //        myStack.Push(23);
    //        myStack.Push(13);

    //        myStack.DisplayStack();

    //        Console.WriteLine(myStack.Pop());

    //        myStack.DisplayStack();

    //        Console.WriteLine(myStack.Peek());
    //    }
    //}
    #endregion

    #region Problem 2: Find Nth node from the end of a linked list
    public class ListNode
    {
        public int Data;
        public ListNode Next;

        public ListNode(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Solution
    {
        private ListNode head;

        public Solution()
        {
            head = null;
        }

        public int ListLength(ListNode head)
        {
            ListNode current = head;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public void InsertInLinkedList(int data, int position)
        {
            ListNode newNode = new ListNode(data);

            if (position < 1)
            {
                Console.WriteLine("Invalid Position!");
                return;
            }

            if (position == 1 || head == null)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                ListNode current = head;

                for (int i = 1; i < position - 1 && current != null; i++)
                {
                    current = current.Next;
                }

                if (current == null)
                {
                    Console.WriteLine("Position is out of range!");
                    return;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void NthNodeFromTheEndOfList(int n)
        {

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution myList = new Solution();

            myList.InsertInLinkedList(3, 1);
            myList.InsertInLinkedList(9, 2);
            myList.InsertInLinkedList(13, 3);
            myList.InsertInLinkedList(23, 4);
            myList.InsertInLinkedList(39, 5);
            myList.InsertInLinkedList(44, 6);

            myList.NthNodeFromTheEndOfList(3); // Result 23
        }
    }
    #endregion
}