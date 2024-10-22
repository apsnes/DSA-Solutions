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
    public long KthLargestLevelSum(TreeNode root, int k)
    {
        if (root == null)
        {
            return -1;
        }
        PriorityQueue<long, long> pq = new();
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            int size = queue.Count;
            long sum = 0;

            for (int i = 0; i < size; i++)
            {
                TreeNode currentNode = queue.Dequeue();
                sum += currentNode.val;

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            if (pq.Count < k)
            {
                pq.Enqueue(sum, sum);
            }
            else if (sum > pq.Peek())
            {
                pq.Dequeue();
                pq.Enqueue(sum, sum);
            }
        }
        return pq.Count == k ? pq.Peek() : -1;
    }
}
