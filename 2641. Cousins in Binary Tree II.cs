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
    private Dictionary<int,int> dict = new();
    public TreeNode ReplaceValueInTree(TreeNode root)
    {
        Dictionary<int,int> dict = new();
        computeSum(root, 0);
        root.val = 0;
        replaceNodes(root, 0);
        return root;
    }
    private void computeSum(TreeNode node, int depth)
    {
        if (node == null) return;
        if (!dict.ContainsKey(depth))
        {
            dict[depth] = 0;
        }
        dict[depth] += node.val;
        computeSum(node.left, depth + 1);
        computeSum(node.right, depth + 1);
    }
    private void replaceNodes(TreeNode node, int depth)
    {
        int siblingSum = 0;
        if (node.left != null) siblingSum += node.left.val;
        if (node.right != null) siblingSum += node.right.val;
        if (node.left != null)
        {
            node.left.val = dict[depth + 1] - siblingSum;
            replaceNodes(node.left, depth + 1);
        }
        if (node.right != null)
        {
            node.right.val = dict[depth + 1] - siblingSum;
            replaceNodes(node.right, depth + 1);
        }
    }
}
