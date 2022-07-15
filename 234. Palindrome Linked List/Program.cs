using System;

namespace MyApp // Note: actual namespace depends on the project name.
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
        //1 2 2 1
        public bool IsPalindrome(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            slow = reverse(slow);
            fast = head;

            ListNode reverse(ListNode listNode)
            {
                ListNode prev = null;
                ListNode temp;
                while(listNode != null)
                {
                    temp = listNode.next;
                    listNode.next = prev;
                    prev = listNode;
                    listNode = temp;
                }
                return prev;
            }
            while(slow != null)
            {
                if(slow.val != fast.val)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next;   
            }
            return true;
        }
        public ListNode reverse(ListNode listNode)
        {
            return listNode.next;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Solution s = new Solution();
                ListNode node = new ListNode(1,new(2,new(1)));
                ListNode node2 = new ListNode(1,new(2,new(2,new(1))));
                ListNode node3 = new ListNode(1,new(2));
                //Console.WriteLine(s.IsPalindrome(node));
                Console.WriteLine(s.IsPalindrome(node2));
                //Console.WriteLine(s.IsPalindrome(node3));
            }
        }
    }
}