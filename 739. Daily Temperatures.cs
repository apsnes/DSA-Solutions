// Initial
public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var n = temperatures.Length;
        var res = new int[n];

        for (int i = 0; i < n - 1; i++)
        {
            var currNum = temperatures[i];
            var stack = new Stack<int>();
            var futureIndex = i + 1;
            stack.Push(temperatures[futureIndex]);
            var numOfDays = 1;

            while (stack.Count > 0)
            {
                var currPop = stack.Pop();
                if (currPop > currNum)
                {
                    res[i] = numOfDays;
                    break;
                }
                futureIndex++;
                if (futureIndex < n) stack.Push(temperatures[futureIndex]);
                numOfDays++;
            }
        }

        return res;
    }
}

// Optimized
public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] output = new int[temperatures.Length];
        int currIndex = 0;
        Stack<int[]> stack = new();

        for (int i = 0; i < temperatures.Length; i++)
        {
            int t = temperatures[i];
            while (stack.Count > 0 && t > stack.Peek()[0])
            {
                int[] popped = stack.Pop();
                output[popped[1]] = (i - popped[1]);
            }
            int[] toAdd = new int[2];
            toAdd[0] = t; toAdd[1] = i;
            stack.Push(toAdd);
        }
        return output;
    }
}
