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
    public bool EvaluateTree(TreeNode root)
    {
        return DFS(root);
    }

    public bool DFS(TreeNode root)
    {
        if (root.left != null && root.right != null)
        {
            if (root.val == 2)
            {
                return (DFS(root.left) || DFS(root.right));
            }
            else if (root.val == 3)
            {
                return (DFS(root.left) && DFS(root.right));
            }
        }
        if (root.val == 0) return false;
        return true;
    }
}
