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
    //HashSet to store values that exist in the tree
    HashSet<int> values;
    
    public FindElements(TreeNode root)
    {
        values = new();
        //Set root val to 0
        root.val = 0;
        //Call dfs algorithm
        ConstructValues(root);
    }
    
    public bool Find(int target)
    {
        //Simply return whether or not the value exists in our hashset
        return values.Contains(target);
    }

    private void ConstructValues(TreeNode node)
    {
        //Add current node val to hashset of values that exist
        values.Add(node.val);
        //if left child is not null, set value and recursively call dfs
        if (node.left != null)
        {
            node.left.val = 2 * node.val + 1;
            ConstructValues(node.left);
        }
        //As above for right child
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
