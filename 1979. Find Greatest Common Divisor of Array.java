class Solution {
    public int findGCD(int[] nums) {
        int min = 1001;
        int max = 0;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] < min) min = nums[i];
            if (nums[i] > max) max = nums[i];
        }
        return calculateGcd(min, max);
    }

    private int calculateGcd(int num1, int num2) {
        while (num2 != 0) {
            int temp = num1;
            num1 = num2;
            num2 = temp % num1;
        }
        return num1;
    }
}
