# Initial solution
class Solution:
    def largestGoodInteger(self, num: str) -> str:
        res = ""
        n = len(num)
        l, r = 0, 2
        while r < n:
            if num[l] == num[l + 1] == num[r]:
                sub = num[l:r + 1]
                if len(res) == 0:
                    res = str(sub)
                elif int(sub) > int(res):
                    res = str(sub)
            r += 1
            l += 1
        return res

#Optimised
class Solution:
    def largestGoodInteger(self, num: str) -> str:
        max_digit = '\0'
        n = len(num)
        for i in range(n - 2):
            if num[i] == num[i + 1] == num[i + 2]:
                max_digit = max(max_digit, num[i])

        return '' if max_digit == '\0' else max_digit * 3
