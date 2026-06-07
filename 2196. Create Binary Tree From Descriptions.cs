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
    public TreeNode CreateBinaryTree(int[][] descriptions)
    {
        var relationships = new Dictionary<int, List<int[]>>();
        var parents = new HashSet<int>();
        var children = new HashSet<int>();

        for (int i = 0; i < descriptions.Length; i++)
        {
            var parent = descriptions[i][0];
            var child = descriptions[i][1];
            var isLeft = descriptions[i][2];

            parents.Add(parent);
            parents.Add(child);
            children.Add(child);

            if (!relationships.ContainsKey(parent)) relationships[parent] = new List<int[]>();
            relationships[parent].Add(new int[] {child, isLeft});
        }
        
        int root = parents.Where(x => !children.Contains(x)).First();
        return BuildTree(relationships, root);
    }

    private TreeNode BuildTree(Dictionary<int, List<int[]>> relationships, int nodeVal)
    {
       var newNode = new TreeNode(nodeVal);
       if (relationships.ContainsKey(nodeVal))
       {
            var children = relationships[nodeVal];
            foreach (var child in children)
            {
                if (child[1] == 1) newNode.left = BuildTree(relationships, child[0]);
                else newNode.right = BuildTree(relationships, child[0]);
            }
       }
       return newNode;
    }
}
