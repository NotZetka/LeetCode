using System;

namespace _206._Reverse_Linked_List
{
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

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode left = null;
            ListNode temp;
            while (head != null)
            {
                temp = head.next;
                head.next = left;
                left = head;
                head = temp;
            }
            return left;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            Solution solution = new Solution();
            ListNode reversed = solution.ReverseList(head);
            while (reversed != null)
            {
                Console.WriteLine(reversed.val);
                reversed = reversed.next;
            }
        }
    }
}