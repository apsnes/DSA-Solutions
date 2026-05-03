public class WordDictionary
{
    public TrieNode root;

    public WordDictionary()
    {
        root = new('\0');
    }
    
    public void AddWord(string word)
    {
        if (word == string.Empty) return;
        var currNode = root;
        foreach (var c in word)
        {
            if (currNode.next.Any(x => x.val == c))
            {
                currNode = currNode.next.First(x => x.val == c);
            }
            else
            {
                var newNode = new TrieNode(c);
                currNode.next.Add(newNode);
                currNode = newNode;
            }
        }
        currNode.isEnd = true;
    }
    
    public bool Search(string word)
    {
        return Dfs(root, word);
    }

    private bool Dfs(TrieNode currNode, string word)
    {
        if (word.Length == 0)
        {
            if (currNode.isEnd) return true;
            else return false;
        }
        if (word[0] != '.')
        {
            if (!currNode.next.Any(x => x.val == word[0])) return false;
            return Dfs(currNode.next.First(x => x.val == word[0]), word[1..]);
        }
        else
        {
            foreach (var node in currNode.next)
            {
                if (Dfs(node, word[1..])) return true;
            }
            return false;
        }
    }
}

public class TrieNode(char value)
{
    public List<TrieNode> next = new();
    public char val = value;
    public bool isEnd = false;
} 
