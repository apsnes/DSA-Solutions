public class Solution
{
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        int m = nums2.Length;
        //If both arrays are odd length, all XORs cancel each other out and we end up returning 0.
        //If only one array is even length, the other array is cancelled out, as each value in that array will be XOR'd an even number
        //of times and thus cancelled out.
        int res = 0;
        if (m % 2 == 1)
        {
            foreach (int num in nums1)
            {
                res ^= num;
            }
        }
        if (n % 2 == 1)
        {
            foreach (int num in nums2)
            {
                res ^= num;
            }
        }
        return res;
    }
}
