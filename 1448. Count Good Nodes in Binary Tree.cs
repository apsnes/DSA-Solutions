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
    private int _goodNodeCount = 0;

    public int GoodNodes(TreeNode root)
    {
        if (root == null) return 0;
        Dfs(root, int.MinValue);
        return _goodNodeCount;
    }

    private void Dfs(TreeNode root, int maxNum)
    {
        if (root == null) return;
        if (root.val >= maxNum)
        {
            _goodNodeCount++;
            maxNum = root.val;
        }
        Dfs(root.left, maxNum);
        Dfs(root.right, maxNum);
    }
}
