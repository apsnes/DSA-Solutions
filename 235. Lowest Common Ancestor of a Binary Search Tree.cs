// Naive solution

public class Solution
{
    TreeNode leftNode;
    TreeNode rightNode;

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        leftNode = p.val < q.val ? p : q;
        rightNode = p.val > q.val ? p : q;
        return FindLCA(root);
    }

    private TreeNode FindLCA(TreeNode root)
    {
        var isLeft = root.val == leftNode.val ? true : SearchForTarget(root.left, leftNode);
        var isRight = root.val == rightNode.val ? true : SearchForTarget(root.right, rightNode);
        if (isLeft && isRight) return root;
        if (isLeft) return FindLCA(root.left);
        return FindLCA(root.right);
    }

    private bool SearchForTarget(TreeNode root, TreeNode target)
    {
        if (root == null) return false;
        if (root.val == target.val) return true;
        return SearchForTarget(root.left, target) || SearchForTarget(root.right, target);
    }
}

// Simple solution
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode currentNode = root;
        while (true)
        {
            if (p.val > currentNode.val && q.val > currentNode.val)
            {
                currentNode = currentNode.right;
            }
            else if(p.val < currentNode.val && q.val < currentNode.val)
            {
                currentNode = currentNode.left;              
            }
            else
            {
                return currentNode;
            }
        }
        return currentNode;
    }
}
