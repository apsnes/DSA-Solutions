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
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

// Clearer DFS solution
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;
        return SearchDepth(1, root);
    }

    private int SearchDepth(int currDepth, TreeNode currNode)
    {
        var maxDepth = currDepth;

        if (currNode.left != null)
        {
            maxDepth = Math.Max(maxDepth, SearchDepth(currDepth + 1, currNode.left));
        }
        if(currNode.right != null)
        {
            maxDepth = Math.Max(maxDepth, SearchDepth(currDepth + 1, currNode.right));
        }
        return maxDepth;
    }
}
