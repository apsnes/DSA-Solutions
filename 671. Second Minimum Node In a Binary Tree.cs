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
        int min = 0;
        int secondMin = -1;

    public int FindSecondMinimumValue(TreeNode root)
    {
        min = root.val;
        Dfs(root);
        return secondMin;
    }

    private void Dfs(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        if ((root.val < secondMin || secondMin == -1) && root.val != min)
        {
            secondMin = root.val;
        }
        Dfs(root.left);
        Dfs(root.right);
    }
}
