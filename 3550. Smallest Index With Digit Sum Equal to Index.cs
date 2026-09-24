// LINQ
public class Solution
{
    public int SmallestIndex(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Sum(x => int.Parse(x.ToString())) == i) return i;
        }
        return -1;
    }
}

// Division
public class Solution
{
    public int SmallestIndex(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            var sum = 0;
            var num = nums[i];
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum == i) return i;
        }
        return -1;
    }
}
