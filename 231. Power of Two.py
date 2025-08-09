# A power of 2 only has a single bit set to 1. If n has a single bit set to 1, then n - 1 will have all preceeding bits set to 1. E.g. 8 = 00001000, 7 = 00000111. We can tell if any n is a power of 2 if we calcuate the bitwise & of: n & n - 1. If n is a power of 2, exactly 0 of the bits will be matching.

class Solution:
    def isPowerOfTwo(self, n: int) -> bool:
        return True if n & (n - 1) == 0 and n != 0 else False
