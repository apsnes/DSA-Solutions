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
    private int[] depth = new int[100001];
    private int[] levelArr = new int[100001];
    private int[] max1 = new int[100001];
    private int[] max2 = new int[100001];

    public int getHeight(TreeNode root, int level)
    {
        if (root == null)
        {
            return 0;
        }
        levelArr[root.val] = level;
        depth[root.val] = 1 + Math.Max(getHeight(root.left, level + 1), getHeight(root.right, level + 1));
        if (max1[level] < depth[root.val])
        {
            max2[level] = max1[level];
            max1[level] = depth[root.val];
        }
        else if(max2[level] < depth[root.val])
        {
            max2[level] = depth[root.val];
        }
        return depth[root.val];
    }

    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        getHeight(root, 0);
        {
            for (int i = 0; i < queries.Length; i++)
            {
                int current = queries[i];
                int level = levelArr[current];
                queries[i] = (max1[level] == depth[current] ? max2[level] : max1[level]) + level - 1;
            }
        }
        return queries;
    }
}
