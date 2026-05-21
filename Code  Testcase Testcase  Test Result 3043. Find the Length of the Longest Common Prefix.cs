// Trie Solution
public class Solution
{
    private TrieNode root = new();

    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        var max = 0;

        foreach (var num in arr1)
        {
            var numString = num.ToString();
            var currNode = root;
            for (int i = 0; i < numString.Length; i++)
            {
                var c = numString[i];
                if (currNode.Children.Any(x => x.Value == c))
                {
                    currNode = currNode.Children.First(x => x.Value == c);
                }
                else
                {
                    var childNode = new TrieNode() { Value = c };
                    if (i == numString.Length - 1) childNode.IsEnd = true;
                    currNode.Children.Add(childNode);
                    currNode = childNode;
                }
            }
        }

        foreach (var num in arr2)
        {
            max = Math.Max(max, Search(num.ToString(), 0, root));
        }

        return max;
    }

    public int Search(string num, int currIndex, TrieNode currNode)
    {
        if (currIndex == num.Length) return currIndex;
        var digit = num[currIndex];
        if (currNode.Children.Any(x => x.Value == digit))
        {
            return Search(num, currIndex + 1, currNode.Children.First(x => x.Value == digit));
        }
        return currIndex;
    }
}

public class TrieNode
{
    public char Value;
    public List<TrieNode> Children = new();
    public bool IsEnd = false;
}
