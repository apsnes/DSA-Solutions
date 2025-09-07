class Solution:
    def sumZero(self, n: int) -> List[int]:
        res = []
        if n % 2 == 1:
            res.append(0)
        i = 1
        while len(res) < n:
            res.append(i)
            res.append(-i)
            i += 1
        return res
