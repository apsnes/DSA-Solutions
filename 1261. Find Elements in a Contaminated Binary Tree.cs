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
public class FindElements
{
    HashSet<int> values;
    public FindElements(TreeNode root)
    {
        values = new();
        root.val = 0;
        ConstructValues(root);
    }
    
    public bool Find(int target)
    {
        return values.Contains(target);
    }

    private void ConstructValues(TreeNode node)
    {
        values.Add(node.val);
        if (node.left != null)
        {
            node.left.val = 2 * node.val + 1;
            ConstructValues(node.left);
        }
        if (node.right != null)
        {
            node.right.val = 2 * node.val + 2;
            ConstructValues(node.right);
        }
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */
