/*This is essentially just a trick question. The constraints of the question dictate that n <= 100 yet the question asks to simulate it for 10^9 days.
Each day, one int is added because n % (n - 1) == 1. After running the simulation and adding n - 1 each day, we would end up with n - 1 ints, so we can just skip
the algorithm and return n - 1 for all other n except 1. */

public class Solution {
    public int DistinctIntegers(int n)
    {
        return n == 1 ? 1 : n - 1;
    }
}
