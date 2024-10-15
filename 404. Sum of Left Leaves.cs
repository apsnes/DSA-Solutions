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
    public int SumOfLeftLeaves(TreeNode root)
    {
        return Traverse(root, false);
    }
    private int Traverse(TreeNode root, bool isLeft)
    {
        if (root == null)
        {
            return 0;
        }
        if (root.left == null && root.right == null && isLeft)
        {
            return root.val;
        }
        return Traverse(root.left, true) + Traverse(root.right, false);
    }
}
