class FindSumPairs:

    def __init__(self, nums1: List[int], nums2: List[int]):
        self.nums1 = nums1
        self.nums2 = nums2
        self.cnt = Counter(nums2)

    def add(self, index: int, val: int) -> None:
        _nums2, _cnt = self.nums2, self.cnt
        _cnt[_nums2[index]] -= 1
        _nums2[index] += val
        _cnt[_nums2[index]] += 1
 
    def count(self, tot: int) -> int:
        _nums1, _cnt = self.nums1, self.cnt
        res = 0
        for i in _nums1:
            if (rest := tot - i) in _cnt:
                res += _cnt[rest]
        return res
