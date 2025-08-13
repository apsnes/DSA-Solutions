# Optimal solution. To be a power of 3, the largest power of 3 available must be divisible by n
class Solution:
    def isPowerOfThree(self, n: int) -> bool:
        power = (3 ** 19)
        return n > 0 and power % n == 0


# Loop solution. As 3 is a prime number, repeated division of n by 3 will eventually result in 1 if n is a power of 3.
class Solution:
    def isPowerOfThree(self, n: int) -> bool:
        if n <= 0:
            return False
        while n % 3 == 0:
            n //= 3
        return n == 1
