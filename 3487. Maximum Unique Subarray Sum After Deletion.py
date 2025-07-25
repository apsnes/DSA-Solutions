class Solution:
    def maxSum(self, nums: List[int]) -> int:
        numset = set()
        maxnum = nums[0]
        for i in nums:
            maxnum = max(maxnum, i)
            if i > 0:
                numset.add(i) 
        return sum(numset) if len(numset) > 0 else maxnum
