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

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        // Check if both nodes are null, if so, return true
        if (p == null && q == null)
        {
            return true;
        }
        // If one of the nodes is null, return false
        if (q == null || p == null)
        {
            return false;
        }
        // Compare the values of the nodes
        // If they are not equal, return false
        if (p.val != q.val)
        {
            return false;
        }
        // Recursively check the left and right subtrees
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
