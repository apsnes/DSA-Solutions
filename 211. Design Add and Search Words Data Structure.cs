public class TrieNode
{
    public TrieNode?[] Child;
    public bool WordEnd;

    public TrieNode()
    {
        Child = new TrieNode?[26];
        WordEnd = false;
    }
}

public class WordDictionary
{
    TrieNode root;

    public WordDictionary()
    {
        root = new TrieNode();
    }
    
    public void AddWord(string word)
    {
        TrieNode current = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (current.Child[index] == null)
            {
                current.Child[index] = new TrieNode();
            }
            current = current.Child[index];
        }
        current.WordEnd = true;
    }
    
    public bool Search(string word)
    {
        return SearchWord(root, word, 0);
    }

    private bool SearchWord(TrieNode current, string word, int index)
    {
        if (index == word.Length)
        {
            return current.WordEnd;
        }
        char c = word[index];
        if (c == '.')
        {
            for (int i = 0; i < 26; i++)
            {
                if (current.Child[i] != null && SearchWord(current.Child[i]!, word, index + 1))
                {
                    return true;
                }
            }
            return false;
        }
        else
        {
            int charIndex = c - 'a';
            if (current.Child[charIndex] == null)
            {
                return false;
            }
            return SearchWord(current.Child[charIndex]!, word, index + 1);
        }
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
