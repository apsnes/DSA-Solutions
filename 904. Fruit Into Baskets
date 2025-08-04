# Initial sliding window dictionary solution:
class Solution:
    def totalFruit(self, fruits: List[int]) -> int:
        counts = {}
        left, right = 0, 0
        n = len(fruits)
        max_fruits = 0

        while right < n:
            if fruits[right] in counts:
                counts[fruits[right]] += 1
            elif len(counts) < 2:
                counts[fruits[right]] = 1
            else:
                counts[fruits[left]] -= 1
                if counts[fruits[left]] == 0:
                    del counts[fruits[left]]
                left += 1
                continue
            max_fruits = max(max_fruits, right - left + 1)
            right += 1

        return max_fruits

# Optimized and tidied solution:
class Solution:
    def totalFruit(self, fruits: List[int]) -> int:
        counts = defaultdict(int)
        left, right = 0, 0
        max_fruits = sum(counts.values())
        n = len(fruits)

        while right < n:
            counts[fruits[right]] += 1
            while len(counts) > 2:
                counts[fruits[left]] -= 1
                if counts[fruits[left]] == 0:
                    del counts[fruits[left]]
                left += 1
            max_fruits = max(max_fruits, right - left + 1)
            right += 1

        return max_fruits
