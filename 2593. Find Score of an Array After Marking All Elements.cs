public class Solution
{
    public long FindScore(int[] numArr)
    {
        long score = 0;
        List<(long num, int index)> nums = new();
        for (int i = 0; i < numArr.Length; i++) { nums.Add((numArr[i], i)); }

        nums.Sort((a, b) => a.num == b.num ? a.index.CompareTo(b.index) : a.num.CompareTo(b.num)); 

        int n = numArr.Length;
        bool[] visited = new bool[n];

        foreach (var (num, index) in nums)
        {
            if (visited[index]) continue;

            score += num;
            visited[index] = true;

            if (index > 0) visited[index - 1] = true;
            if (index < n - 1) visited[index + 1] = true;
        }
        return score;
    }
}
