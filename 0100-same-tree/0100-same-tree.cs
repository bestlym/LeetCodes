/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Stack<(TreeNode, TreeNode)> stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));
        
        while(stack.Count > 0)
        {
            (p, q) = stack.Pop();
            if(p == null && q == null) continue;
            
            if(p == null || q == null) return false;
            
            if(p.val != q.val) return false;
            
            stack.Push((p.left, q.left));
            stack.Push((p.right, q.right));            
        }        
        return true;        
    }
}