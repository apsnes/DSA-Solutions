// Naive solution - TLE
class Solution {
    public int uniqueXorTriplets(int[] nums) {
        var values = new HashSet<Integer>();
        Arrays.sort(nums);
        for (int i = 0; i < nums.length; i++) {
            for (int j = i; j < nums.length; j++) {
                for (int k = j; k < nums.length; k++) {
                    int currValue = nums[i] ^ nums[j] ^ nums[k];
                    values.add(currValue);
                }
            }
        }
        return values.size();
    }
}

// Optimal - Math
class Solution {
    public int uniqueXorTriplets(int[] nums) {
        if (nums.length <= 2) return nums.length;
        int ans = 1;
        while (ans <= nums.length) {
            ans <<= 1;
        }
        return ans;
    }
}
