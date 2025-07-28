class Solution:
    def countMaxOrSubsets(self, nums: List[int]) -> int:
        max_or = reduce(ior, nums)
        count = 0

        for i in nums:
            max_or |= i
        return self._count_subsets(nums, 0, 0, max_or)

    def _count_subsets(self, nums: List[int], index: int, current_or: int, target_or: int) -> int:
        if index == len(nums):
            return 1 if current_or == target_or else 0
        
        count_without = self._count_subsets(nums, index + 1, current_or, target_or)

        count_with = self._count_subsets(nums, index + 1, current_or | nums[index], target_or)

        return count_without + count_with
