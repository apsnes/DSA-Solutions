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
    public IList<int> LargestValues(TreeNode root)
    {
        //Edge case - if root is null, return empty list
        if (root == null) return new List<int>();
        //Initialise result list
        List<int> result = new();
        //Initialise queue for BFS algorithm
        Queue<TreeNode> q = new();
        //Enqueue root
        q.Enqueue(root);
        //Continue algorith while there are still nodes to check
        while (q.Count > 0)
        {
            int currentLength = q.Count;
            int currentMax = int.MinValue;
            //Iterate through current queue to find max at current level
            for (int i = 0; i < currentLength; i++)
            {
                //Dequeue next node
                TreeNode currentNode = q.Dequeue();
                //Check if current value is greater than previous seen max
                currentMax = Math.Max(currentMax, currentNode.val);
                //Enqueue children if not null
                if (currentNode.left != null) q.Enqueue(currentNode.left);
                if (currentNode.right != null) q.Enqueue(currentNode.right);
            }
            //Add levels max to results list
            result.Add(currentMax);
        }
        return result;
    }
}
