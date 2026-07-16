class Solution {
    public long gcdSum(int[] nums) {
        var prefixGcd = new int[nums.length];
        long sum = 0;
        int prefixMax = nums[0];

        prefixGcd[0] = nums[0];
        for (int i = 1; i < nums.length; i++) {
            prefixMax = Math.max(prefixMax, nums[i]);
            prefixGcd[i] = gcd(nums[i], prefixMax);
        }
        Arrays.sort(prefixGcd);

        for (int i = 0, j = prefixGcd.length - 1; i < j; i++, j--) {
            sum += gcd(prefixGcd[i], prefixGcd[j]);
        }

        return sum;
    }

    private int gcd(int num1, int num2) {
        while (num2 != 0) {
            int temp = num1;
            num1 = num2;
            num2 = temp % num2;
        }
        return num1;
    }
}
