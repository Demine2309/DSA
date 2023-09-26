namespace DSA
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int d)
        {
            data = d;
            next = null;
            prev = null;
        }
    }

    #region Singly Linked List
    public class SinglyLinkedList
    { 
        public Node head;

        public SinglyLinkedList()
        {
            head = null;
        }

        // Insert a new node at front of the list
        public void Push(int newData)
        {
            // Allocate the Node & Put in the data
            Node newNode = new Node(newData);

            // Make next of the new Node as head
            newNode.next = head;

            // Move the head to point to new node
            head = newNode;
        }

        // Inserts a new node after a given previous node
        public void InsertAfter(Node prevNode, int newData)
        {
            // Check if the given node is null
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node can't be null");
                return;
            }

            // Allocate the Node & Put in the data
            Node newNode = new Node(newData);

            // Make next of new node as next of previous node
            newNode.next = prevNode.next;

            // Make next of previous node as new node
            prevNode.next = newNode;
        }

        // Appends a new node at the end
        public void Append(int newData)
        {
            // Allocate the Node & Put in the data. Set next as null
            Node newNode = new Node(newData);

            // If the linked list is empty, then make the new node as head 
            if (head == null)
            {
                head = new Node(newData);
                return;
            }

            // This new node is going to be the last node, so make next of it as null
            newNode.next = null;

            // Else traverse till the last node
            Node last = head;
            while (last.next != null)
            {
                last = last.next;
            }

            // Change the next of last node 
            last.next = newNode;
        }

        // Checks whether the value x is present in linked list
        public bool SearchWithIterativeApproach(Node head, int x)
        {
            Node current = head; // Initialize current node

            while (current != null)
            {
                if (current.data == x)
                    return true; // data found
                current = current.next;
            }

            return false;
        }

        public bool SearchWithRecursiveApproach(Node head, int x)
        {
            // Base case
            if (head == null)
                return false;
            // If key is present in current code, return true
            if (head.data == x)
                return true;

            // Recursive for remainning list
            return SearchWithRecursiveApproach(head.next, x);
        }

        // Returns count of nodes in Linked list
        public int GetCountWithIterativeApproach()
        {
            Node current = head;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }

        public int GetCountWithRecursiveApproach(Node node)
        {
            // Base case
            if (node == null)
                return 0;

            // Count is this node plus rest of the list
            return 1 + GetCountWithRecursiveApproach(node.next);
        }

        // Reverse a linked list
        #region Reverse by Iterative method
        //public void ReverseList()
        //{
        //    Node prev = null;
        //    Node current = head;
        //    Node next = null;

        //    while (current != null)
        //    {
        //        next = current.next;
        //        current.next = prev;
        //        prev = current;
        //        current = next;
        //    }

        //    head = prev;
        //}
        #endregion

        #region Reverse by Recursive method
        public Node Reverse(Node head)
        {
            if(head == null || head.next == null)
                return head;

            // Reverse the rest list and put the first element at the end
            Node rest = Reverse(head.next);
            head.next.next = head;

            // Tricky step
            head.next = null;

            // Fix the head pointer
            return rest;
        }
        #endregion

        // Deletion in Linked list
        #region Iterative method
        public void DeleteElement(Node head, int position)
        {
            Node temp = head;
            Node prev = head;
            for(int i = 0; i < position; i++)
            {
                if (i == 0 && position == 1)
                {
                    head = head.next;
                    temp = null;
                }
                else
                {
                    if(i == position - 1 && temp != null)
                    {
                        prev.next = temp.next;
                        temp = null;
                    }
                    else
                    {
                        prev = temp;

                        // Position was greater than number of nodes in the list
                        if (prev == null)
                            break;
                        temp = temp.next;
                    }
                }
            }
        }
        #endregion

        // Print linked list
        public void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }
            Console.Write("null\n");
        }
    }
    #endregion

    #region Doubly Linked List
    public class DoublyLinkedList
    {
        public Node head;

        public DoublyLinkedList()
        {
            head = null;
        }

        public void AddNote(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }
    }
    #endregion

    #region Circular Linked List
    public class CircularLinkedList
    {
        public Node head;

        public CircularLinkedList()
        {
            head = null;
        }

        public void AddNote(int data)
        {
            Node newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
                newNode.next = head;
                return;
            }

            Node current = head;

            while (current.next != head)
            {
                current = current.next;
            }

            current.next = newNode;
            newNode.next = head;
        }
    }
    #endregion

    class MainClass
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();

            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);

            list.Print();

            list.DeleteElement(list.head, 3);
            list.Print();
        }

        // Check if the value x is contain in linked list 
        static void Check(int x, SinglyLinkedList llist)
        {
            if (llist.SearchWithIterativeApproach(llist.head, x))
                Console.WriteLine("Yes");
            else if (llist.SearchWithRecursiveApproach(llist.head, x))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}