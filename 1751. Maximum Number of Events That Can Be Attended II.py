class Solution:
    def maxValue(self, events: List[List[int]], k: int) -> int:
        events.sort()
        n = len(events)
        next_indicies = []
        starts = [e[0] for e in events]
        for i in range(n):
            next_indicies.append(bisect_left(starts, events[i][1] + 1))
        
        @lru_cache(None)
        def dp(current_index, count):
            if current_index == n or count == 0:
                return 0
            
            return max(events[current_index][2] + dp(next_indicies[current_index], count - 1), dp(current_index + 1, count))
        
        return dp(0, k)
        
        
