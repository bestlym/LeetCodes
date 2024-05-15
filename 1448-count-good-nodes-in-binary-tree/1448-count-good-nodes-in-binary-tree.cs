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
    private int ret = 0;
    
    public int GoodNodes(TreeNode root) {
        DFS(root, int.MinValue);
        return ret;
    }
    
    public void DFS(TreeNode node, int maxVal)
    {
        if(node.val >= maxVal) ret++;
        
        if(node.left != null) {
            DFS(node.left, Math.Max(node.val, maxVal));
        }
        
        if(node.right != null){
            DFS(node.right, Math.Max(node.val, maxVal));
        }
    }
}