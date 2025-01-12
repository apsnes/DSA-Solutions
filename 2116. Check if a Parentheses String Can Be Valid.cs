public class Solution
{
    public bool CanBeValid(string s, string locked)
    {
        int n = s.Length;
        if (n < 2) return false;
        if (n % 2 != 0) return false;       
        Stack<int> lockedIndexes = new();
        Stack<int> unlockedIndexes = new();
        for (int i = 0; i < n; i++)
        {
            if (locked[i] == '0')
            {
                unlockedIndexes.Push(i);
                continue;
            }
            if (s[i] == ')')
            {
                if (lockedIndexes.Count == 0 && unlockedIndexes.Count == 0) return false;
                if (lockedIndexes.Count > 0) lockedIndexes.Pop();
                else unlockedIndexes.Pop();
            }
            if (s[i] == '(')
            {
                lockedIndexes.Push(i);
            }
        }
        while (lockedIndexes.Count != 0 && unlockedIndexes.Count != 0 && lockedIndexes.Peek() < unlockedIndexes.Peek())
        {
            lockedIndexes.Pop();
            unlockedIndexes.Pop();
        }
        return lockedIndexes.Count == 0;
    }
}
