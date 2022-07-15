using System;

namespace MyApp 
{
  
  
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 

    public class Solution
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if(original == null)
            {
                return null;
            }
            if(original.val == target.val)
            {
                return cloned;
            }
            TreeNode? left = GetTargetCopy(original.left, cloned.left, target);
            TreeNode? right = GetTargetCopy(original.right, cloned.right, target);
            return (left != null)?left:((right!=null)?right:null);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new(7);
            treeNode.left = new TreeNode(4);
            treeNode.right = new TreeNode(3);
            treeNode.right.left = new TreeNode(6);
            treeNode.right.right = new TreeNode(19);
            TreeNode treeNode2 = new(7);
            treeNode2.left = new TreeNode(4);
            treeNode2.right = new TreeNode(3);
            treeNode2.right.left = new TreeNode(6);
            treeNode2.right.right = new TreeNode(19);
            Solution solution = new Solution();
            Console.WriteLine(solution.GetTargetCopy(treeNode,treeNode2,new TreeNode(3)).val);
        }
    }
}