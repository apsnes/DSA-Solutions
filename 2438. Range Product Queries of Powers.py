class Solution:
    def productQueries(self, n: int, queries: List[List[int]]) -> List[int]:
        mod = (10 ** 9) + 7
        powers = []
        power = 1

        while n:
            if n & 1:
                powers.append(power)
            n >>= 1
            power <<= 1

        res = []
        m = len(queries)

        for i in range(m):
            l, r = queries[i]
            product = powers[l]
            while l < r:
                l += 1
                product *= powers[l]

            res.append(product % mod)

        return res
