namespace DSA
{
	#region Single Linked List
	public class Node
	{
		public int data;
		public Node next;

		public Node(int d)
		{
			data = d;
			next = null;
		}
	}

	public class SinglyLinkedList
	{
		public Node head;

		// The ListLength() function takes a linked list as input and counts the number of node in the list
		// Time complexity: O(n)
		public int ListLength(Node head)
		{
			Node current = head;
			int count = 0;

			while(current != null)
			{
				count++;
				current = current.next;
			}

			return count;
		}

		// Singly linked list insertion
		// 1. Inserting a Node in Singly Linked List at the beginning

	}
	#endregion
}