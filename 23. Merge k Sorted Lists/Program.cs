using System;
using System.Collections.Generic;

namespace _23._Merge_k_Sorted_Lists
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

    //public class Solution
    //{
    //    public ListNode MergeKLists(ListNode[] lists)
    //    {
    //        bool finished = false;

    //        var result = new ListNode();
    //        var tail = result;
    //        do
    //        {
    //            finished = true;
    //            int? nodeToAdd = null;
    //            int value = int.MaxValue;
    //            for (int i = 0; i < lists.Length; i++)
    //            {
    //                var node = lists[i];
    //                if (node == null) continue;
    //                finished = false;

    //                if (nodeToAdd == null)
    //                {
    //                    nodeToAdd = i;
    //                    value = node.val;
    //                }
    //                else if (value > node.val)
    //                {
    //                    nodeToAdd = i;
    //                    value = node.val;
    //                }
    //            }
    //            if (!finished)
    //            {
    //                tail.next = new ListNode(value);
    //                lists[(int)nodeToAdd] = lists[(int)nodeToAdd].next;
    //                tail = tail.next;
    //            }
    //        } while (!finished);
    //        return result.next;
    //    }
    //}
    //public class Solution
    //{
    //    public ListNode MergeKLists(ListNode[] lists)
    //    {
    //        ListNode result = new ListNode(int.MinValue);
    //        foreach (var curNode in lists)
    //        {
    //            var node = curNode;
    //            while (node != null)
    //            {
    //                var head = result;
    //                while (head.next != null && head.next.val < node.val)
    //                {
    //                    head = head.next;
    //                }
    //                var temp = head.next;
    //                head.next = new(node.val,temp);
    //                node = node.next;
    //            }
    //        }
    //        return result.next;
    //    }
    //}
    //public class Solution
    //{
    //    public ListNode MergeKLists(ListNode[] lists)
    //    {
    //        int l = lists.Length;
    //        if (l == 0) return null;
    //        while (l > 1)
    //        {
    //            for (int i = 0; i < l/2; i++)
    //            {
    //                lists[i] = MergeTwo(lists[i], lists[l-i-1]);
    //            }
    //            l -= l / 2;
    //        }
    //        return lists[0];
    //    }
    //    private ListNode MergeTwo(ListNode list1, ListNode list2)
    //    {
    //        var result = new ListNode();
    //        var head = result;
    //        while(list1!=null|| list2 != null)
    //        {
    //            while(list2 == null && list1 != null)
    //            {
    //                head.next = new(list1.val);
    //                head = head.next;
    //                list1 = list1.next;
    //            }
    //            while(list1 == null && list2 != null)
    //            {
    //                head.next = new(list2.val);
    //                head = head.next;
    //                list2 = list2.next;
    //            }
    //            if(list1 == null && list2 == null) break;
    //            if (list1.val < list2.val)
    //            {
    //                head.next = new(list1.val);
    //                head = head.next;
    //                list1 =list1.next;
    //            }
    //            else
    //            {
    //                head.next = new(list2.val);
    //                head = head.next;
    //                list2 = list2.next;
    //            }
    //        }
    //        return result.next;
    //    }
    //}
    public class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            int l = lists.Length;
            if (l == 0) return null;
            while (l > 1)
            {
                for (int i = 0; i < l/2; i++)
                {
                    lists[i] = MergeTwo(lists[i], lists[l-i-1]);
                }
                l -= l / 2;
            }
            return lists[0];
        }
        private ListNode MergeTwo(ListNode list1, ListNode list2)
        {
            ListNode result;
            if(list1 == null)
            {
                return list2;
            }
            if(list2 == null)
            {
                return list1;
            }
            if(list1.val < list2.val)
            {
                result = list1;
            }
            else
            {
                result = list2;
                var temp = list1;
                list1 = list2;
                list2 = temp;
            }
            while(list2 != null)
            {
                while (list1.next != null && list1.next.val <= list2.val)
                {
                    list1 = list1.next;
                }
                var temp = list1.next;
                list1.next = list2;
                list2 = temp;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            ListNode node1 = new(1, new(4, new(5)));
            ListNode node2 = new(1, new(3, new(4)));
            ListNode node3 = new(2, new(6));
            //ListNode[] list = new ListNode[] { node1, node2, node3 };
            ListNode[] list = new ListNode[] { null, null};
            solution.MergeKLists(list);
        }
    }
}
