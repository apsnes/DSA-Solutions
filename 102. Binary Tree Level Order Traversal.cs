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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        Queue<TreeNode> q = new();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int l = q.Count;
            IList<int> currLevel = new List<int>();
            for (int i = 0; i < l; i++)
            {
                TreeNode currNode = q.Dequeue();
                if (currNode != null)
                {
                    currLevel.Add(currNode.val);
                    q.Enqueue(currNode.left);
                    q.Enqueue(currNode.right);
                }
            }
            if (currLevel.Count > 0)
            {
                ans.Add(currLevel);
            }
        }
        return ans;
    }
}
