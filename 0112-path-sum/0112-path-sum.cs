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
    int target = 0;
    
    public bool HasPathSum(TreeNode root, int targetSum) {
        target = targetSum;
        return DFS(root, 0);
    }
    
    public bool DFS(TreeNode node, int currSum)
    {
        if(node == null) return false;
        
        if(node.left == null && node.right == null){
            return (currSum + node.val) == target;
        }
        
        currSum += node.val;
        bool left = DFS(node.left, currSum);
        bool right = DFS(node.right, currSum);
        
        return left || right;        
    }
}