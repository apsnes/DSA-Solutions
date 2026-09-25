public class Solution
{
    public int MinSumOfLengths(int[] arr, int target)
    {
        var n = arr.Length;
        var prefix = new int[n];
        var l = 0;
        var sum = 0;
        var min = int.MaxValue;
        var currMin = int.MaxValue;

        for (int r = 0; r < n; r++)
        {
            sum += arr[r];
            while (sum > target)
            {
                sum -= arr[l];
                l++;
            }
            if (sum == target)
            {
                var length = r - l + 1;

                if (l > 0 && prefix[l - 1] < int.MaxValue)
                {
                    min = Math.Min(min, length + prefix[l - 1]);
                }

                currMin = Math.Min(currMin, length);
            }

            prefix[r] = currMin;
        }

        return min == int.MaxValue ? -1 : min;
    }
}
