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
    public int MaxDepth(TreeNode root)
    {
        // If the root is null, the depth is 0
        if (root == null)
        {
            return 0;
        }
        // If the root is a leaf node, the depth is 1
        // Recursively calculate the depth of the left and right subtrees
        int left = 1 + MaxDepth(root.left);
        int right = 1 + MaxDepth(root.right);
        // Return the maximum of the two depths
        return Math.Max(left, right);
    }
}
