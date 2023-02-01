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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> ret = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();        
        TreeNode curr = root;        
        
        while(stack.Count > 0 || curr != null)
        {
            while(curr != null){
                stack.Push(curr);
                curr = curr.left;
            }
            
            curr = stack.Pop();
            ret.Add(curr.val);
            curr = curr.right;            
        }
        return ret;
    }
}