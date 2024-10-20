public class Solution
{
    public bool Eval(List<bool> boolArr, char c)
    {
        bool res = boolArr[0];
        if (c == '&')
        {
            foreach (var b in boolArr)
            {
                res &= b;
            }
        }
        else if (c == '|')
        {
            foreach (var b in boolArr)
            {
                res |= b;
            } 
        }
        else
        {
            res = !res;
        }
        return res;
    }
    public bool ParseBoolExpr(string expression)
    {
        if (expression == "t") return true;
        if (expression == "f") return true;
        Stack<char> stack = new();
        foreach (char e in expression)
        {
            if (e != ')' && e != ',')
            {
                stack.Push(e);
            }
            else if (e == ')')
            {
                List<bool> arr = new();
                while (stack.Peek() == 't' || stack.Peek() == 'f')
                {
                    arr.Add(stack.Pop() == 't' ? true : false);
                }
                stack.Pop();
                stack.Push(Eval(arr, stack.Pop()) == true ? 't' : 'f');
            }
        }
        return stack.Peek() == 't' ? true : false;      
    }
}
