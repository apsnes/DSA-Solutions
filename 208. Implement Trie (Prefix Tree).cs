public class TrieNode
{
    public Dictionary<char, TrieNode> Children = new();
    public bool IsEnd = false;
}

public class Trie
{
    private TrieNode root = new();

    public Trie()
    {       
    }
    
    public void Insert(string word)
    {
        var curr = root;
        for (int i = 0; i < word.Length; i++)
        {
            var c = word[i];
            if (!curr.Children.ContainsKey(c)) curr.Children[c] = new();
            curr = curr.Children[c];
            if (i == word.Length - 1) curr.IsEnd = true;
        }
    }
    
    public bool Search(string word)
    {
        var curr = root;
        for (int i = 0; i < word.Length; i++)
        {
            var c = word[i];
            if (!curr.Children.ContainsKey(c)) return false;
            if (i == word.Length - 1 && curr.Children[c].IsEnd == true) return true;
            curr = curr.Children[c];
        }
        return false;
    }
    
    public bool StartsWith(string prefix)
    {
        var curr = root;
        for (int i = 0; i < prefix.Length; i++)
        {
            var c = prefix[i];
            if (!curr.Children.ContainsKey(c)) return false;
            if (i == prefix.Length - 1) return true;
            curr = curr.Children[c];
        }
        return false;
    }
}
