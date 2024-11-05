/*# Intuition
If the string is of even length, can we iterate through in blocks of two and check if the block of two is valid?

# Approach
Create a simple loop to check each pair of characters. We start at index 1 and check if s[i] == s[i - 1] each time to ensure the index is never out of bounds. We increment i by 2 each loop so that we are only ever checking blocks of two. Have a running total of changes required and return this as the answer.

# Complexity
- Time complexity:
$$O(n)$$

- Space complexity:
$$O(n)$$*/

public class Solution {
    public int MinChanges(string s)
    {
        int changes = 0;
        for (int i = 1; i < s.Length; i += 2)
        {
            if (s[i] == s[i - 1])
            {
                continue;
            }
            else
            {
                changes++;
            }
        }
        return changes;
    }
}
