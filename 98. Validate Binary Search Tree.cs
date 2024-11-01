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
    public bool IsValidBST(TreeNode root)
    {
        return Traverse(root, long.MinValue, long.MaxValue);
    }
    
    private bool Traverse(TreeNode root, long min, long max)
    {
        if (root == null)
        {
            return true;
        }
        return root.val < max && root.val > min && Traverse(root.left, min, root.val) && Traverse(root.right, root.val, max);
    }

}
