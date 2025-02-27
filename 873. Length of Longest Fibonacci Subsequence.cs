public class Solution
{
    public int LenLongestFibSubseq(int[] arr)
    {
        Dictionary<(int, int), int> dp = new();
        int maxLength = 0;
        int n = arr.Length;

        for (int i = 2; i < n; i++)
        {
            int start = 0;
            int end = i - 1;

            while (start < end)
            {
                int sum = arr[start] + arr[end];

                if (sum > arr[i]) end--;
                else if (sum < arr[i]) start++;
                else
                {
                    if (!dp.ContainsKey((start, end))) dp[(start, end)] = 0;
                    dp[(end, i)] = dp[(start, end)] + 1;
                    maxLength = Math.Max(maxLength, dp[(end, i)]);
                    end--;
                    start++;
                }
            }
        }
        return maxLength == 0 ? 0 : maxLength + 2;
    }
}
