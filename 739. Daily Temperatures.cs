public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var n = temperatures.Length;
        var res = new int[n];
        var stack = new Stack<int[]>();

        for (int i = 0; i < n; i++)
        {
            var currTemp = temperatures[i];

            while (stack.Count > 0 && currTemp > stack.Peek()[0])
            {
                var pastIndex = stack.Pop()[1];
                var dayDifference = i - pastIndex;
                res[pastIndex] = dayDifference;
            }

            stack.Push(new int[2] { currTemp, i });
        }

        return res;
    }
}
