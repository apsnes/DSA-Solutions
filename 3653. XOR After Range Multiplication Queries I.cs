public class Solution
{
    public int XorAfterQueries(int[] nums, int[][] queries)
    {
        for (int i = 0; i < queries.Length; i++)
        {
            var l = queries[i][0];
            var r = queries[i][1];
            var k = queries[i][2];
            var v = queries[i][3];

            while (l <= r)
            {
                nums[l] = (int)(((long)nums[l] * v) % (Math.Pow(10, 9) + 7));
                l += k;
            }
        }

        var xor = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            xor ^= nums[i];
        }

        return xor;
    }
}
