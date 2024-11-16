public class Solution {
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        if (k > n) k = k % n;
        int startIndex = n - k;
        List<int> ans = new List<int>(nums);
        foreach (int num in nums) ans.Add(num);
        for (int i = startIndex, j = 0; i < startIndex + n; i++, j++)
        {
            nums[j] = ans[i];
        }
    }
}
