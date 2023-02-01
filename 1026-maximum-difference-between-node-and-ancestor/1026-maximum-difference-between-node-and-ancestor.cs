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
    public int MaxAncestorDiff(TreeNode root) {
        return DFS(root, root.val, root.val);
    }
    
    private int DFS(TreeNode root, int mn, int mx)
    {
        if(root == null){
            return mx - mn;
        }
        
        mx = Math.Max(mx, root.val);
        mn = Math.Min(mn, root.val);
        
        return Math.Max(DFS(root.left, mn, mx), DFS(root.right, mn, mx));
    }
}

