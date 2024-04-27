using System.Security;

namespace DSA
{
    #region Single Linked List
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

    public class SinglyLinkedList
    {
        private ListNode head;

        public SinglyLinkedList()
        {
            head = null;
        }

        // The ListLength() function takes a linked list as input and counts the number of node in the list
        // Time complexity: O(n)
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

        // Singly linked list insertion
        // Time complexity: O(n)
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

        // Singly Linked List deletion
        // Time complexity: O(n)
        public void DeleteInLinkedList(int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position!");
                return;
            }

            if (position == 1)
            {
                if (head == null)
                {
                    Console.WriteLine("List is empty. Nothing to delete!");
                    return;
                }

                head = head.Next;
            }
            else
            {
                ListNode currentNode = head;
                ListNode previousNode = null;
                int count = 1;

                while (currentNode != null && count < position)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                    count++;
                }

                if (currentNode == null)
                {
                    Console.WriteLine("Position out of range");
                    return;
                }

                previousNode.Next = currentNode.Next;
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
            SinglyLinkedList linkedList = new SinglyLinkedList();
            linkedList.InsertInLinkedList(23, 1);
            linkedList.InsertInLinkedList(9, 2);
            linkedList.InsertInLinkedList(2, 3);
            linkedList.InsertInLinkedList(22, 4);

            linkedList.InsertInLinkedList(33, 2);

            Console.WriteLine("Original linked list:");
            linkedList.Display();

            linkedList.DeleteInLinkedList(2);

            Console.WriteLine("Linked list after deleting node:");
            linkedList.Display();
        }
    }
    #endregion

    #region Doubly Linked List
    //public class ListNode
    //{
    //    public int data;
    //    public ListNode next;
    //    public ListNode previous;

    //    public ListNode(int d)
    //    {
    //        data = d;
    //        next = previous = null;
    //    }
    //}

    //public class DoublyLinkedList
    //{
    //    private ListNode head;
    //    private ListNode tail;

    //    public DoublyLinkedList()
    //    {
    //        head = null;
    //        tail = null;
    //    }

    //    // Doubly Linked List Insertion
    //    // Time complexity: O(n)
    //    public void Insert(int data, int position)
    //    {
    //        if (position < 1)
    //        {
    //            Console.WriteLine("Invalid position!");
    //            return;
    //        }

    //        ListNode newNode = new ListNode(data);

    //        if (head == null || position == 1)
    //        {
    //            newNode.next = head;

    //            if (head != null)
    //            {
    //                head.previous = newNode;
    //            }

    //            head = newNode;

    //            if (tail == null)
    //            {
    //                tail = newNode;
    //            }

    //            return;
    //        }

    //        ListNode currentNode = head;
    //        int count = 1;

    //        while (count < position - 1 && currentNode != null)
    //        {
    //            currentNode = currentNode.next;
    //            count++;
    //        }

    //        if (currentNode == null)
    //        {
    //            Console.WriteLine("Position out of range!");
    //            return;
    //        }

    //        newNode.next = currentNode.next;
    //        newNode.previous = currentNode;

    //        if (currentNode.next != null)
    //        {
    //            currentNode.next.previous = newNode;
    //        }

    //        currentNode.next = newNode;

    //        if (newNode.next == null)
    //        {
    //            tail = newNode;
    //        }
    //    }

    //    // Doubly Linked List deletion
    //    // Time complexity: O(n)
    //    public void Delete(int position)
    //    {
    //        if (position < 1)
    //        {
    //            Console.WriteLine("Invalid position!");
    //            return;
    //        }

    //        if (head == null)
    //        {
    //            Console.WriteLine("List is empty. Nothing to delete!");
    //            return;
    //        }

    //        if (position == 1)
    //        {
    //            head = head.next;

    //            if (head != null)
    //            {
    //                head.previous = null;
    //            }
    //            else
    //            {
    //                tail = null;
    //            }
    //            return;
    //        }

    //        ListNode current = head;
    //        int count = 1;

    //        while (count < position && current != null)
    //        {
    //            current = current.next;
    //            count++;
    //        }

    //        if (current == null)
    //        {
    //            Console.WriteLine("Position is out of range!");
    //            return;
    //        }

    //        // Adjust the links to skip  the node to be deleted
    //        if (current.previous != null)
    //        {
    //            current.previous.next = current.next;
    //        }
    //        if (current.next != null)
    //        {
    //            current.next.previous = current.previous;
    //        }

    //        // Update tail if the last node is deleted
    //        if (current == tail)
    //        {
    //            tail = current.previous;
    //        }
    //    }

    //    public void Display()
    //    {
    //        ListNode current = head;
    //        Console.Write("NULL <-");
    //        while (current != null)
    //        {
    //            Console.Write($" {current.data}");
    //            if (current.next != null)
    //            {
    //                Console.Write(" <=>");
    //            }
    //            current = current.next;
    //        }
    //        Console.WriteLine(" -> NULL");
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        DoublyLinkedList linkedList = new DoublyLinkedList();

    //        linkedList.Insert(23, 1);
    //        linkedList.Insert(32, 2);
    //        linkedList.Insert(09, 3);
    //        linkedList.Insert(90, 4);

    //        linkedList.Display();

    //        linkedList.Delete(2);
    //        linkedList.Display();
    //    }
    //}
    #endregion

    #region Implement stack using Linked List
    //public class ListNode
    //{
    //    public int data;
    //    public ListNode next;

    //    public ListNode(int data)
    //    {
    //        this.data = data;
    //        next = null;
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
    //        newNode.next = top;
    //        top = newNode;
    //    }

    //    public int Pop()
    //    {
    //        if(top == null)
    //        {
    //            throw new InvalidOperationException("Stack is empty.");
    //        }

    //        int poppedData = top.data;
    //        top = top.next;
    //        return poppedData;
    //    }

    //    public int Peek()
    //    {
    //        if (top == null)
    //            throw new InvalidOperationException("Stack is empty.");

    //        return top.data;
    //    }

    //    public void DeleteStack()
    //    {
    //        top = null;

    //        Console.WriteLine("Stack has been deleted.");
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

    //        Console.WriteLine(myStack.Pop());

    //        Console.WriteLine(myStack.Peek());
    //    }
    //}
    #endregion
}