##Initial solution##
class Solution:
    def longestSubarray(self, nums: List[int]) -> int:
        k = max(nums)
        res = 0
        current_len = 0
        for i in nums:
            if i == k:
                current_len += 1
                res = max (res, current_len)
            else:
                current_len = 0
        return res


##One pass solution##
class Solution:
    def longestSubarray(self, nums: List[int]) -> int:
        max_val = res = current_len = 0
        for i in nums:
            if i > max_val:
                max_val = i
                current_len = res = 0          
            if i == max_val:
                current_len += 1
                res = max (res, current_len)
            else:
                current_len = 0
        return res
