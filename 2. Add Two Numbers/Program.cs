
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode();
        ListNode temp = head;
        while (l1 != null || l2 != null)
        {
            int val1 = l1==null ? 0 : l1.val;
            int val2 = l2==null ? 0 : l2.val;
            int sum = val1 + val2 + temp.val;
            temp.val = sum%10;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
            if (sum / 10 == 0 && l1 is null && l2 is null) break;
            temp.next = new(sum / 10);
            temp = temp.next;
        }
        return head;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        ListNode l1 =
            //new ListNode(2,new(4,new(3)));
            new(9, new(9, new(9, new(9))));
        ListNode l2 =
            //new ListNode(5,new(6,new(4)));
            new(9, new(9));
        var result = solution.AddTwoNumbers(l1,l2);
        while(result != null)
        {
            Console.WriteLine(result.val);
            result = result.next;
        }
    }
}