#initial attempt - time limit exceeded:

class Solution:
    def maxFreeTime(self, eventTime: int, k: int, startTime: List[int], endTime: List[int]) -> int:
        left, right = 0, k
        maxValue = -1
        n = len(startTime)
        breaks = []
        for i in range(n):
            if i == 0:
                breaks.append(startTime[i])
            else:
                breaks.append(startTime[i] - endTime[i-1])

        breaks.append(eventTime - endTime[-1])
        
        if right >= len(breaks):
            maxValue = sum(breaks)

        while right < len(breaks):
            maxValue = max(maxValue, sum(breaks[left:right + 1]))
            left += 1
            right += 1
        
        return maxValue

#Optimised approach:

class Solution:
    def maxFreeTime(self, eventTime: int, k: int, startTime: List[int], endTime: List[int]) -> int:
        n = len(startTime)
        breaks = []
        breaks.append(startTime[0])

        for i in range(1, n):
            breaks.append(startTime[i] - endTime[i-1])
        
        breaks.append(eventTime - endTime[-1])
        
        window = sum(breaks[:k+1])
        maxValue = window

        for i in range(k+1, len(breaks)):
            window = window - breaks[i - (k+1)] + breaks[i]
            maxValue = max(maxValue, window)
        
        return maxValue
