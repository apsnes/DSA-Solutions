class Solution:
    def productQueries(self, n: int, queries: List[List[int]]) -> List[int]:
        mod = (10 ** 9) + 7
        powers = []
        power = 1

        while n > 0:
            if n % 2 == 1:
                powers.append(power)
            n //= 2
            power *= 2

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
