public class Solution {

    Stack<char> stack = new Stack<char>();

    public int MinLength(string s) {
        foreach (char c in s)
        {
            CheckStack();
            stack.Push(c);
        }
        CheckStack();
        return stack.Count;
    }

    private void CheckStack()
    {
        if (stack.Count > 1)
        {
            char second = stack.Pop();
            char first = stack.Pop();
            StringBuilder sb = new StringBuilder();
            sb.Append(first);
            sb.Append(second);
            string str = sb.ToString();
            if (str != "AB" && str != "CD")
            {
                stack.Push(first);
                stack.Push(second);
            }
        }
    }
}
