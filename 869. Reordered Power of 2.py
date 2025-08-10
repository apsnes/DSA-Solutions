# Problem constraints prevent a number larger than 10^9, which limits us to numbers up to and including 2^30. We can compute the sorted string
# of all possible powers of 2 in this range easily. Using 1 << i is a faster way to compute powers of 2 compared with 2 ** i. This works for powers
# of 2 because each binary left shift of a single bit is the next power of 2. Once we have computed all of these possible values, we simply compare
# them with the input value's sorted string. If any match, we return True.

class Solution:
    def reorderedPowerOf2(self, n: int) -> bool:
        def count_digits(x):
            return ''.join(sorted(str(x)))

        target = count_digits(n)

        for i in range(31):
            if count_digits(1 << i) == target:
                return True
        return False
