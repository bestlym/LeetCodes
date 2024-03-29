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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> ret = new List<int>();        
        if(root == null) return ret;        
        Stack<TreeNode> stack = new Stack<TreeNode>();
        
        stack.Push(root);
        
        while(stack.Count > 0){
            TreeNode curr = stack.Pop();
            ret.Add(curr.val);
            
            if(curr.left != null){
                stack.Push(curr.left);
            }
            if(curr.right != null){
                stack.Push(curr.right);
            }            
        }
        ret.Reverse();
        return ret;
    }
}