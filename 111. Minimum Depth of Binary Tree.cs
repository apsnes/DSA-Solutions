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
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int leftMin = MinDepth(root.left);
        int rightMin = MinDepth(root.right);

        if (leftMin == 0 || rightMin == 0)
        {
            return Math.Max(leftMin, rightMin) + 1;
        }
        
        return Math.Min(leftMin, rightMin) + 1;
    }
}
