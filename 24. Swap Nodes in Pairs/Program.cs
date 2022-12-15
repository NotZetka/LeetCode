using System;

namespace _24._Swap_Nodes_in_Pairs
{

 
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
       }
  }
 
    public class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            if(head == null || head.next == null)
            {
                return head;
            }
            var node = head;
            head = head.next;
            var temp = node;
            node = node.next;
            temp.next = node.next;
            node.next = temp;
            var previous = node.next;
            while(previous.next != null && previous.next.next != null)
            {
                node = previous.next;
                temp = node.next;
                node.next = temp.next;
                temp.next = node;
                previous.next = temp;
                previous = previous.next.next;
            }
            return head;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode head = new(1, new(2, new(3, new(4))));
            var result = solution.SwapPairs(head);
            while (result != null)
            {
                Console.WriteLine(result.val);
            }
        }
    }
}
