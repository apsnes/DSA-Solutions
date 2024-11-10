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
    int min = Int32.MaxValue;
    TreeNode prev = null;

    public int GetMinimumDifference(TreeNode root)
    {
        inOrder(root);
        return min;
    }

    private void inOrder(TreeNode root)
    {
        if (root == null) return;
        inOrder(root.left);
        if (prev != null) min = Math.Min(min, root.val - prev.val);
        prev = root;
        inOrder(root.right);
        return;
    }
}
