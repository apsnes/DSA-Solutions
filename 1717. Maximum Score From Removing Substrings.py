class Solution:
    def maximumGain(self, s: str, x: int, y: int) -> int:
        score = 0
        high_prio = "ab" if x > y else "ba"
        low_prio = "ba" if high_prio == "ab" else "ab"

        high_prio_removed = self.remove_substring(s, high_prio)
        removed_count = (len(s) - len(high_prio_removed)) // 2
        score += removed_count * max(x,y)

        low_prio_removed = self.remove_substring(high_prio_removed, low_prio)
        removed_count = (len(high_prio_removed) - len(low_prio_removed)) // 2

        score += removed_count * min(x,y)

        return score
        
    def remove_substring(self, s: str, target: str) -> str:
        stack = []
        for c in s:
            if c == target[1] and stack and stack[-1] == target[0]:
                stack.pop()
            else:
                stack.append(c)
        return "".join(stack)
