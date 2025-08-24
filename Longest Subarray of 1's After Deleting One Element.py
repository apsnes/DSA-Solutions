class Solution:
    def longestSubarray(self, nums: List[int]) -> int:
        zerocount = 0
        res = 0
        n = len(nums)
        l, r = 0, 0
        while r < n:
            current = nums[r]
            if current == 0:
                zerocount += 1
            while zerocount == 2:
                left_val = nums[l]
                if left_val == 0:
                    zerocount -= 1
                l += 1
            res = max (res, r - l)
            r += 1
        return res
