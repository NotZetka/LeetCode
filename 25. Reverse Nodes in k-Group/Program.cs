using System;

namespace _25._Reverse_Nodes_in_k_Group
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
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (k <= 1) { return head; }
            ListNode result = null;
            ListNode resultTail = null;
            ListNode save;
            ListNode previous;
            int counter;
            while (head != null)
            {
                save = head;
                counter = 0;

                previous = head;
                while (counter < k && head!=null)
                {
                    previous = head;
                    counter++;
                    head = head.next;
                }
                if (counter == k)
                {
                    previous.next = null;
                    if(result == null)
                    {
                        result = Reverse(save);
                        resultTail = result;
                    }
                    else
                    {
                        resultTail.next = Reverse(save);
                    }
                    while (resultTail.next != null)
                    {
                        resultTail = resultTail.next;
                    }
                }
                else
                {
                    if(result == null)
                    {
                        result = save;
                    }
                    else
                    {
                        resultTail.next = save;
                    }
                }
            }
            return result;
        }
        public ListNode Reverse(ListNode head)
        {
            ListNode result = null;
            do
            {
                var temp = head.next;
                head.next = result;
                result = head;
                head = temp;
            }while(head.next != null);
            head.next = result;
            return head;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode head = new(1, new(2, new(3,new(4,new(5,new(6,new(7)))))));
            var result = solution.ReverseKGroup(head,3);
            Console.WriteLine(result.val);
        }
    }
}
