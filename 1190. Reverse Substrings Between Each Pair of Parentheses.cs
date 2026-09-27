public class Solution
{
    public string ReverseParentheses(string s)
    {
        var stack = new Stack<char>();
        var n = s.Length;
        
        foreach (var c in s)
        {
            if (c == ')')
            {
                var tempList = new List<char>();

                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    tempList.Add(stack.Pop());
                }

                stack.Pop();

                foreach (var ch in tempList)
                {
                    stack.Push(ch);
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        var stackArr = stack.ToArray();
        Array.Reverse(stackArr);
        return new string(stackArr);
    }
}
