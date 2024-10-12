public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        Stack<double> stack = new(position.Length);

        Array.Sort(position, speed);

        for (int i = position.Length -1; i >= 0; i--)
        {
            double time = (target * 1.0 - position[i]) / speed[i];
            if (stack.Any())
            {
                double top = stack.Peek();
                if (time <= top)
                {
                    continue;
                }
                else
                {
                    stack.Push(time);
                }
            }
            else
            {
                stack.Push(time);
            }
        }
        return stack.Count();
    }
}
