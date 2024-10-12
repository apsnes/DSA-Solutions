public class Solution {
    public string SimplifyPath(string path) {
        StringBuilder sb = new StringBuilder();
        Stack<string> stack = new();
        string[] parts = path.Split('/');

        foreach (var part in parts)
        {
            if (part == "" || part == ".")
            {
                continue;
            }
            else if (part == "..")
            {
                if(stack.Any())
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(part);
            }
        }
        while (stack.Any())
        {
            sb.Insert(0, "/" + stack.Pop());
        }       
        return sb.Length == 0 ? "/" : sb.ToString();
    }
}
