using System.Collections.Generic;

namespace DSA
{
    // Defination common of ListNode in this case
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    #region Problem 1: Find the middle of a Given linked list
    //public class Solution
    //{
    //    public int FindTheMiddleOfLinkedList(ListNode head)
    //    {
    //        int middle = (GetCount(head) / 2) + 1;
    //        int result = 0;

    //        for (int i = 1; i < middle; i++)
    //        {
    //            head = head.next;
    //            result = head.val;
    //        }

    //        return result;
    //    }

    //    public int GetCount(ListNode node)
    //    {
    //        if (node == null) return 0;

    //        return 1 + GetCount(node.next);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution();

    //        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))));

    //        int result = solution.FindTheMiddleOfLinkedList(listNode);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Problem 2: Write a function that counts the number of times a given int occurs in a linked list
    //public class Solution
    //{
    //    public int Problem2(ListNode head, int n)
    //    {
    //        int m = GetCount(head);
    //        int count = 0;

    //        if (head == null) return 0;

    //        for(int i = 0; i < m; i++)
    //        {
    //            if(head.val == n)
    //            {
    //                count++;
    //            }

    //            head = head.next;
    //        }

    //        return count;
    //    }

    //    private int GetCount(ListNode head)
    //    {
    //        if(head == null) return 0;

    //        return 1 + GetCount(head.next);
    //    }
    //}

    //class MainClass
    //{
    //    static void Main(string[] args)
    //    {
    //        Solution solution = new Solution(); 

    //        ListNode listNode = new ListNode(1, new ListNode(2));
    //        int givenNum = 1;

    //        int result = solution.Problem2(listNode, givenNum);

    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Problem 3: Detect loop or cyrcle in a linked list

    #endregion
}