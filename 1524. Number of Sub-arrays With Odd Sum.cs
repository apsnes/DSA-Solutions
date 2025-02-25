public class Solution
{
    public int NumOfSubarrays(int[] arr)
    {
        int n = arr.Length;
        int pre = 0;
        long count = 0;
        int oddCount = 0;
        int evenCount = 1;
        const int mod = 1_000_000_007;
        for (int i = 0; i < n; i++)
        {
            pre += arr[i];
            if (pre % 2 == 0)
            {
                count = (count + oddCount) % mod;
                evenCount++;
            }
            else
            {
                count = (count + evenCount) % mod;
                oddCount++;
            }
        }
        return (int)count;
    }
}
