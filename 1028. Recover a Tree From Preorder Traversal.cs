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
    private static int index;
    public TreeNode RecoverFromPreorder(string traversal)
    {
        index = 0;
        return BuildTree(traversal, 0);
    }

    private TreeNode BuildTree(string traversal, int depth)
    {
        if (index >= traversal.Length) return null;
        int dashCount = 0;
        while (index + dashCount < traversal.Length && traversal[index + dashCount] == '-')
        {
            dashCount++;
        }
        if (dashCount != depth) return null;
        index = index + dashCount;
        int value = 0;
        while (index < traversal.Length && char.IsDigit(traversal[index]))
        {
            value = value * 10 + traversal[index++] - '0';
        }
        TreeNode node = new(value);
        node.left = BuildTree(traversal, depth + 1);
        node.right = BuildTree(traversal, depth + 1);
        return node;
    }
}
