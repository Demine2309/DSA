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

    //public class Solution
    //{
    //    private ListNode head;

    //    public Solution()
    //    {
    //        head = null;
    //    }

    //    public int ListLength()
    //    {
    //        ListNode current = head;
    //        int count = 0;

    //        while (current != null)
    //        {
    //            count++;
    //            current = current.Next;
    //        }

    //        return count;
    //    }

    //    public void InsertInLinkedList(int data, int position)
    //    {
    //        ListNode newNode = new ListNode(data);

    //        if (position < 1)
    //        {
    //            Console.WriteLine("Invalid Position!");
    //            return;
    //        }

    //        if (position == 1 || head == null)
    //        {
    //            newNode.Next = head;
    //            head = newNode;
    //        }
    //        else
    //        {
    //            ListNode current = head;

    //            for (int i = 1; i < position - 1 && current != null; i++)
    //            {
    //                current = current.Next;
    //            }

    //            if (current == null)
    //            {
    //                Console.WriteLine("Position is out of range!");
    //                return;
    //            }

    //            newNode.Next = current.Next;
    //            current.Next = newNode;
    //        }
    //    }

    //    public void NthNodeFromTheEndOfList(int n, int length)
    //    {
    //        int desPos = (length - n) + 1;

    //        ListNode currentNode = head;
    //        int count = 1;

    //        while(currentNode != null && count < desPos)
    //        {
    //            currentNode = currentNode.Next;
    //            count++;
    //        }

    //        Console.WriteLine($"{n}th Node fron the end of a list is {currentNode.Data}");
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution myList = new Solution();

    //        myList.InsertInLinkedList(3, 1);
    //        myList.InsertInLinkedList(9, 2);
    //        myList.InsertInLinkedList(13, 3);
    //        myList.InsertInLinkedList(23, 4);
    //        myList.InsertInLinkedList(39, 5);
    //        myList.InsertInLinkedList(44, 6);

    //        Console.WriteLine(myList.ListLength());

    //        myList.NthNodeFromTheEndOfList(3, myList.ListLength()); // Result 23
    //    }
    //}
    #endregion

    #region Problem 6. Check whether the given linked list is either Null-terminated or ends in a circle (cylic)
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

    //public class Solution
    //{
    //    private ListNode head;

    //    public Solution()
    //    {
    //        head = null;
    //    }

    //    public void InsertInLinkedList(int data, int position)
    //    {
    //        ListNode newNode = new ListNode(data);

    //        if (position < 1)
    //        {
    //            Console.WriteLine("Invalid Position!");
    //            return;
    //        }

    //        if (position == 1 || head == null)
    //        {
    //            newNode.Next = head;
    //            head = newNode;
    //        }
    //        else
    //        {
    //            ListNode current = head;

    //            for (int i = 1; i < position - 1 && current != null; i++)
    //            {
    //                current = current.Next;
    //            }

    //            if (current == null)
    //            {
    //                Console.WriteLine("Position is out of range!");
    //                return;
    //            }

    //            newNode.Next = current.Next;
    //            current.Next = newNode;
    //        }
    //    }

    //    public bool IsLinkedListCyclic()
    //    {
    //        if (head == null || head.Next == null)
    //        {
    //            return false;
    //        }

    //        ListNode slowPtr = head;
    //        ListNode fastPtr = head;

    //        while (fastPtr != null && fastPtr.Next != null)
    //        {
    //            slowPtr = slowPtr.Next;
    //            fastPtr = fastPtr.Next.Next;

    //            if (slowPtr == fastPtr)
    //            {
    //                return true;
    //            }
    //        }

    //        return false;
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution myList = new Solution();

    //        myList.InsertInLinkedList(3, 1);
    //        myList.InsertInLinkedList(9, 2);
    //        myList.InsertInLinkedList(13, 3);
    //        myList.InsertInLinkedList(23, 4);
    //        myList.InsertInLinkedList(39, 5);
    //        myList.InsertInLinkedList(44, 6);

    //        bool isCyclic = myList.IsLinkedListCyclic();

    //        if (isCyclic)
    //        {
    //            Console.WriteLine("The linked list is cyclic.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The linked list is null-terminated.");
    //        }
    //    }
    //}
    #endregion

    #region Problem 15. Insert a node in a sorted Linked List
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
        public ListNode head;

        public Solution()
        {
            head = null;
        }

        public void InsertInSortedList(int value)
        {
            ListNode newNode = new ListNode(value);

            if (head == null)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                ListNode prevNode = head;

                while(prevNode.Next != null)
                {
                    if(prevNode.Next.Data < value)
                    {
                        prevNode = prevNode.Next;
                    }
                    else
                    {
                        break;
                    }
                }

                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }
        }

        public void Display()
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write($" {current.Data} ->");
                current = current.Next;
            }

            Console.WriteLine("NULL");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution myList = new Solution();

            ListNode node1 = new ListNode(3);
            ListNode node2 = new ListNode(9);
            ListNode node3 = new ListNode(13);
            ListNode node4 = new ListNode(23);
            ListNode node5 = new ListNode(39);

            myList.head = node1;
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;

            Console.WriteLine("Before insert:");
            myList.Display();

            myList.InsertInSortedList(1);
            
            Console.WriteLine("After insert:");
            myList.Display();

        }
    }
    #endregion
}