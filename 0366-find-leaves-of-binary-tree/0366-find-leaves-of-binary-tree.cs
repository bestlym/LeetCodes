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
    public IList<IList<int>> FindLeaves(TreeNode root) {        
        List<IList<int>> ret = new List<IList<int>>();

        if(root == null)
            return ret;

        
        DFS(root, ret);
        return ret;
    }

    private int DFS(TreeNode root, List<IList<int>> ret)
    {
        if(root == null){
            return 0;
        }

        var depth = 0;
        int left = DFS(root.left, ret);
        int right = DFS(root.right, ret);
        depth = Math.Max(left, right) + 1;
        
        if(ret.Count < depth){
            ret.Add(new List<int>{root.val});
        } else {
            ret[depth-1].Add(root.val);
        }

        return depth;
    }
    
}

