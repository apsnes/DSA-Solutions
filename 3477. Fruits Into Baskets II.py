class Solution:
    def numOfUnplacedFruits(self, fruits: List[int], baskets: List[int]) -> int:
        n = len(fruits)
        res = n

        for fruit in range(n):
            for basket in range(n):
                if fruits[fruit] <= baskets[basket]:
                    baskets[basket] = -1
                    res -= 1
                    break

        return res
