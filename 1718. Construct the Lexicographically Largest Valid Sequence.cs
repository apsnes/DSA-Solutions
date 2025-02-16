public class Solution
{
    public int[] ConstructDistancedSequence(int n)
    {   
        int[] ans = new int[n * 2 - 1];
        findValidSequence(0, ans, new HashSet<int>(), n);
        return ans;
    }

    private bool findValidSequence(int currentIndex, int[] ans, HashSet<int> usedNums, int target)
    {
        if (currentIndex == ans.Length) return true;
        if (ans[currentIndex] != 0) return findValidSequence(currentIndex + 1, ans, usedNums, target);

        for (int i = target; i >= 1; i--)
        {
            if (usedNums.Contains(i)) continue;
            usedNums.Add(i);
            ans[currentIndex] = i;
            if (i == 1)
            {
                if (findValidSequence(currentIndex + 1, ans, usedNums, target)) return true;
            }
            else if (currentIndex + i < ans.Length && ans[currentIndex + i] == 0)
            {
                ans[currentIndex + i] = i;
                if (findValidSequence(currentIndex + 1, ans, usedNums, target)) return true;
                ans[currentIndex + i] = 0;
            }
            usedNums.Remove(i);
            ans[currentIndex] = 0;
        }
        return false;
    }
}
