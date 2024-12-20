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
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        //Begin recursive solution with first children at level 0
        DFS(root.left, root.right, 0);
        return root;
    }
    public void DFS(TreeNode left, TreeNode right, int level)
    {
        //base case - we're at the leafnodes, return - no children to swap
        if (left == null || right == null) return;

        //Odd level swaps happen at even levels - the parents swap the children
        if (level % 2 == 0)
        {
            int temp = left.val;
            left.val = right.val;
            right.val = temp;
        }
        //Call DFS on all further levels of the tree
        DFS(left.left, right.right, level + 1);
        DFS(left.right, right.left, level + 1);
    }
}
