// DFS Solution
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;
        InvertTree(root.left);
        InvertTree(root.right);
        var tempNode = root.left;
        root.left = root.right;
        root.right = tempNode;
        return root;
    }
}

// BFS Solution
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            var currNode = q.Dequeue();
            if (currNode == null) continue;
            var tempNode = currNode.left;
            currNode.left = currNode.right;
            currNode.right = tempNode;
            q.Enqueue(currNode.left);
            q.Enqueue(currNode.right);
        }
        return root;
    }
}
