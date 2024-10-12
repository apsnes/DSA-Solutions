public class Solution {
    public int MinAddToMakeValid(string s)
    {
        int open = 0;
        int close = 0;
        int ans = 0;

        Stack<char> stack = new();

        char[] chars = s.ToCharArray();

        foreach (char c in chars)
        {
            if (stack.Count != 0)
            {
                char top = stack.Peek();
                if (top == '(' && c == ')')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count;
    }
}
