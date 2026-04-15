class Solution:
    def closestTarget(self, words: List[str], target: str, startIndex: int) -> int:
        dist = 0
        n = len(words)
        left = startIndex
        right = startIndex
        while True:
            if dist > n: break
            if words[left] == target or words[right] == target: return dist
            left = (left - 1) % n
            right = (right + 1) % n
            dist += 1
        return -1
