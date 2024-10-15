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
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> ans = new List<int>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            TreeNode rightSide = null;
            int qLength = q.Count;
            for (int i = 0; i < qLength; i++)
            {
                TreeNode node = q.Dequeue();
                if (node != null)
                {
                    rightSide = node;
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            if (rightSide != null)
            {
                ans.Add(rightSide.val);
            }
        }
        return ans;
    }
}
