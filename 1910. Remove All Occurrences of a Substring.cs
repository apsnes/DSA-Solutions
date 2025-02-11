public class Solution
{
    public string RemoveOccurrences(string s, string part)
    {
        int size = part.Length;
        Stack<char> stack = new();
        for (int i = 0; i < s.Length; i++)
        {
            stack.Push(s[i]);
            if (stack.Count >= size)
            {
                string reversed = new(stack.Take(size).Reverse().ToArray());
                if (reversed == part)
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        stack.Pop();
                    }
                }
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}
