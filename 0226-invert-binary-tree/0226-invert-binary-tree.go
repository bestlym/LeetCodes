/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func invertTree(root *TreeNode) *TreeNode {
    if(root == nil){
        return nil;
    }
    
    var left *TreeNode = invertTree(root.Left);
    var right *TreeNode = invertTree(root.Right);
    
    root.Left = right;
    root.Right = left;
    
    return root;
}