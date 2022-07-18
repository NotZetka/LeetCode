using System;

namespace MyApp
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
        public ListNode MiddleNode(ListNode head)
        {
            ListNode middlenode = head;
            while (head != null && head.next != null)
            {
                middlenode = middlenode.next;
                head = head.next.next;
            }
            return middlenode;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            Solution solution = new Solution();
            Console.WriteLine(solution.MiddleNode(head).val);
        }
    }
}