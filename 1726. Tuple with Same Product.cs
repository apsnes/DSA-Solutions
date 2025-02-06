public class Solution
{
    public int TupleSameProduct(int[] nums)
    {
        int count = 0;
        //for every combination of 4 numbers, there are 8x tuples that can be built from those four numbers
        Dictionary<int, int> productCount = new();
        Dictionary<int, int> pairCount = new();

        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int product = nums[i] * nums[j];
                if (!pairCount.ContainsKey(product)) pairCount[product] = 0;
                if (!productCount.ContainsKey(product)) productCount[product] = 0;
                pairCount[product] += productCount[product];
                productCount[product]++;
            }
        }
        int res = 0;
        foreach (var val in pairCount.Values)
        {
            res += 8 * val;
        }
        return res;
    }
}
