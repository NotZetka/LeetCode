using System;

namespace _19._Remove_Nth_Node_From_End_of_List
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    //public class Solution
    //{
    //    public ListNode RemoveNthFromEnd(ListNode head, int n)
    //    {
    //        var current = head;
    //        int counter = 0;
    //        while (current != null)
    //        {
    //            counter++;
    //            current = current.next;
    //        }
    //        if (counter == 1) return null;
    //        if(counter == n) return head.next;
    //        current = head;
    //        for (int i = 1; i < counter-n; i++)
    //        {
    //            current = current.next;
    //        }
    //        current.next =current.next.next;
    //        return head;    
    //    }
    //}
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var currentNode = head;
            var fastNode = head;
            for (int i = 0; i < n; i++)
            {
                fastNode = fastNode.next;
            }
            if (fastNode == null) return head.next;
            while (fastNode.next != null)
            {
                currentNode = currentNode.next;
                fastNode = fastNode.next;
            }
            currentNode.next = currentNode.next.next;
            return head;
        }
    }


    
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode head = new(1, new(2, new(3, new(4, new(5)))));
            solution.RemoveNthFromEnd(head, 5);
            head = new(1,new(2));
            solution.RemoveNthFromEnd(head, 1);
            head = new(1);
            solution.RemoveNthFromEnd(head, 1);
        }
    }
}