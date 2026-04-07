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
    public List<int> RightSideView(TreeNode root)
    {
        var res = new List<int>();
        if (root == null) return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var levelLength = q.Count;
            TreeNode mostRight = null;

            for (int i = 0; i < levelLength; i++)
            {
                mostRight = q.Dequeue();
                if (mostRight.left != null) q.Enqueue(mostRight.left);
                if (mostRight.right != null) q.Enqueue(mostRight.right);
            }

            if (mostRight != null) res.Add(mostRight.val);
        }
        return res;
    }
}
