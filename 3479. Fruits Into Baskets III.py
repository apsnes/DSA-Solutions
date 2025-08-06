# Square root decomposition solution.
# Idea is to optimize by segregating the baskets input array into sqrt(n) smaller sections. In doing this, we can retain information on the largest basket size within each
# section. When iterating over the fruits input array, we can quickly check if the largest value in a section is sufficient to hold the current fruit. If it is,
# we iterate over that section until we find the first basket that is sufficient. If it is not, we skip the section entirely. 

class Solution:
    def numOfUnplacedFruits(self, fruits: List[int], baskets: List[int]) -> int:
        n = len(fruits)
        m = int(math.sqrt(n))
        section = (n + m - 1) // m
        count = 0
        maxV = [0] * section
        
        for i in range(n):
            maxV[i // m] = max(maxV[i // m], baskets[i])
        
        for fruit in fruits:
            to_set = 1
            for sec in range(section):
                if maxV[sec] < fruit:
                    continue
                maxV[sec] = 0
                found = 0
                for i in range(m):
                    index = sec * m + i
                    if index < n and baskets[index] >= fruit and not found:
                        baskets[index] = 0
                        found = 1
                    if index < n:
                        maxV[sec] = max(maxV[sec], baskets[index])
                to_set = 0
                break
            count += to_set
        return count
