class Solution:
    def countHillValley(self, nums: List[int]) -> int:
        res = 0
        left = 0
        n = len(nums)

        for i in range(1, n - 1):
            if nums[i] != nums[i + 1]:
                if (nums[i] > nums[left] and nums[i] > nums[i + 1]) or (nums[i] < nums[left] and nums[i] < nums[i + 1]):
                    res += 1
                left = i
        return res
