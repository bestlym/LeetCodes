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
    public int MinDepth(TreeNode root) {
        if(root == null) 
            return 0;

        if(root.left == null && root.right == null)
            return 1;
        
        int min = int.MaxValue;
        
        if(root.left != null){
            min = Math.Min(MinDepth(root.left), min);
        }
        
        if(root.right != null){
            min = Math.Min(MinDepth(root.right), min);
        }
        
        return min + 1;
    }
}