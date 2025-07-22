class Solution:
    def maximumUniqueSubarray(self, nums: List[int]) -> int:
        left, right = 0, 0
        res = 0
        current = 0
        seen = set()
        n = len(nums)

        while right < n:
            while nums[right] in seen:
                current -= nums[left]
                seen.remove(nums[left])
                left += 1
            current += nums[right]
            seen.add(nums[right])
            res = max(res, current)
            right += 1

        return res
