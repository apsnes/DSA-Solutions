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
    private Dictionary<int, int> preOrderIndexes;
    private Dictionary<int, int> postOrderIndexes;
    private int n;

    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
    {
        preOrderIndexes = new();
        postOrderIndexes = new();
        n = preorder.Length;
        for (int i = 0; i < n; i++)
        {
            preOrderIndexes.Add(preorder[i], i);
            postOrderIndexes.Add(postorder[i], i);
        }
        return BuildTree(0, n - 1, 0, preorder, postorder);
    }

    private TreeNode BuildTree(int pre1, int pre2, int post1, int[] preorder, int[] postorder)
    {
        if (pre1 > pre2) return null;
        TreeNode node = new TreeNode(preorder[pre1]);
        if (pre1 != pre2)
        {
            int leftVal = preorder[pre1 + 1];
            int mid = postOrderIndexes[leftVal];
            int leftSize = mid - post1 + 1;
            node.left = BuildTree(pre1 + 1, pre1 + leftSize, post1, preorder, postorder);
            node.right = BuildTree(pre1 + leftSize + 1, pre2, mid + 1, preorder, postorder);
        }
        return node;
    }
}
