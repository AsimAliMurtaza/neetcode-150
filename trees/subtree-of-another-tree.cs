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
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        // Check if subRoot is null, if so, return true
        if (subRoot == null)
        {
            return true;
        }
        // If root is null, then subRoot cannot be a subtree
        if (root == null)
        {
            return false;
        }
        // Check if the current root matches subRoot
        if (sameTree(root, subRoot)) return true;
        // Recursively check the left and right subtrees
        // for a match with subRoot
        return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    public bool sameTree(TreeNode root1, TreeNode root2)
    {
        // If both nodes are null, they are the same
        if (root1 == null && root2 == null) return true;
        // If one is null and the other is not, they are not the same
        if (root1 == null || root2 == null) return false;
        // Check if the values are the same and recursively check left and right children
        return root1.val == root2.val &&
               sameTree(root1.left, root2.left) &&
               sameTree(root1.right, root2.right);
    }
}
