public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var s in tokens)
        {
            var isNum = int.TryParse(s, out int num);

            if (isNum)
            {
                stack.Push(num);
            }
            else
            {
                stack.Push(ParseEquation(stack.Pop(), stack.Pop(), s));
            }
        }

        return stack.Pop();
    }

    private int ParseEquation(int num1, int num2, string op)
    {
        return op switch
        {
            "+" => num2 + num1,
            "-" => num2 - num1,
            "*" => num2 * num1,
            "/" => num2 / num1,
            _ => throw new ArgumentException("Invalid operator")
        };
    }
}
