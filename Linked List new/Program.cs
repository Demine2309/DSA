namespace DSA
{
	#region Single Linked List
	public class ListNode
	{
		public int data;
		public ListNode next;

		public ListNode(int d)
		{
			data = d;
			next = null;
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

			while(current != null)
			{
				count++;
				current = current.next;
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
				newNode.next = head;
				head = newNode;
			}
			else
			{
				ListNode current = head;
				for(int i = 1; i < position - 1 && current != null; i++)
				{
					current = current.next;
				}

				if(current == null)
				{
					Console.WriteLine("Position is out of range!");
					return;
				}

				newNode.next = current.next;
				current.next = newNode;
			}
		}


	}

	class MainClass
	{
		static void Main(string[] args)
		{

		}
	}
	#endregion
}