class Solution:
    def minimumCost(self, nums: List[int]) -> int:
        res = nums[0]
        sorted_list = sorted(nums[1:])
        return res + sorted_list[0] + sorted_list[1]
