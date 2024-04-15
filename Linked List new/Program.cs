namespace DSA
{
    #region Single Linked List
    //public class ListNode
    //{
    //	public int data;
    //	public ListNode next;

    //	public ListNode(int d)
    //	{
    //		data = d;
    //		next = null;
    //	}
    //}

    //public class SinglyLinkedList
    //{
    //	private ListNode head;

    //	public SinglyLinkedList()
    //	{
    //		head = null;
    //	}

    //	// The ListLength() function takes a linked list as input and counts the number of node in the list
    //	// Time complexity: O(n)
    //	public int ListLength(ListNode head)
    //	{
    //		ListNode current = head;
    //		int count = 0;

    //		while(current != null)
    //		{
    //			count++;
    //			current = current.next;
    //		}

    //		return count;
    //	}

    //	// Singly linked list insertion
    //	// Time complexity: O(n)
    //	public void InsertInLinkedList(int data, int position)
    //	{
    //		ListNode newNode = new ListNode(data);

    //		if (position < 1)
    //		{
    //			Console.WriteLine("Invalid Position!");
    //			return;
    //		}

    //		if (position == 1 || head == null)
    //		{
    //			newNode.next = head;
    //			head = newNode;
    //		}
    //		else
    //		{
    //			ListNode current = head;
    //			for(int i = 1; i < position - 1 && current != null; i++)
    //			{
    //				current = current.next;
    //			}

    //			if(current == null)
    //			{
    //				Console.WriteLine("Position is out of range!");
    //				return;
    //			}

    //			newNode.next = current.next;
    //			current.next = newNode;
    //		}
    //	}

    //	// Singly Linked List deletion
    //	// Time complexity: O(n)
    //	public void DeleteInLinkedList(int position)
    //	{
    //		if(position < 1)
    //		{
    //			Console.WriteLine("Invalid Position!");
    //			return;
    //		}

    //		if(position == 1)
    //		{
    //			if(head == null)
    //			{
    //				Console.WriteLine("List is empty. Nothing to delete!");
    //				return; 
    //			}

    //			head = head.next;
    //		}
    //		else
    //		{
    //			ListNode currentNode = head;
    //			ListNode previousNode = null;
    //			int count = 1;

    //			while (currentNode != null && count < position)
    //			{
    //				previousNode = currentNode;
    //				currentNode = currentNode.next;
    //				count++;
    //			}

    //			if(currentNode == null)
    //			{
    //				Console.WriteLine("Position out of range");
    //				return;
    //			}

    //			previousNode.next = currentNode.next;
    //		}
    //	}

    //	public void Display()
    //	{
    //		ListNode current = head;

    //		while(current != null)
    //		{
    //			Console.Write($" {current.data} ->");
    //			current = current.next;
    //		}

    //		Console.WriteLine("NULL");
    //	}
    //}

    //class MainClass
    //{
    //	static void Main(string[] args)
    //	{
    //		SinglyLinkedList linkedList = new SinglyLinkedList();
    //		linkedList.InsertInLinkedList(23, 1);
    //		linkedList.InsertInLinkedList(9, 2);
    //		linkedList.InsertInLinkedList(2, 3);
    //		linkedList.InsertInLinkedList(22, 4);

    //		Console.WriteLine("Original linked list:");
    //		linkedList.Display();

    //		linkedList.DeleteInLinkedList(2);

    //		Console.WriteLine("Linked list after deleting node:");
    //		linkedList.Display();
    //	}
    //}
    #endregion

    #region Doubly Linked List
    public class ListNode
    {
        public int data;
        public ListNode next;
        public ListNode previous;

        public ListNode(int d)
        {
            data = d;
            next = previous = null;
        }
    }

    public class DoublyLinkedList
    {
        private ListNode head;
        private ListNode tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void Insert(int data, int position)
        {
            if(position < 1)
            {
                Console.WriteLine("Invalid position!");
                return;
            }

            ListNode newNode = new ListNode(data);

            if(head == null || position == 1)
            {
                newNode.next = head;
                
                if(head != null)
                {
                    head.previous = newNode;
                }

                head = newNode;

                if(tail == null)
                {
                    tail = newNode;
                }

                return;
            }

            ListNode currentNode = head;
            int count = 1;

            while(count < position - 1 && currentNode != null)
            {
                currentNode = currentNode.next;
                count++;
            }

            if(currentNode == null)
            {
                Console.WriteLine("Position out of range!");
                return;
            }

            newNode.next = currentNode.next;
            newNode.previous = currentNode;

            if(currentNode.next != null)
            {
                currentNode.next.previous = newNode;
            }

            currentNode.next = newNode; 

            if(newNode.next == null)
            {
                tail = newNode;
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            DoublyLinkedList linkedList = new DoublyLinkedList();
        }
    }
    #endregion
}