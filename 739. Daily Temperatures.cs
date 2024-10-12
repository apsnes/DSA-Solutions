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
