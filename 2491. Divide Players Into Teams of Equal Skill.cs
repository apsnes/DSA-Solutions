public class Solution {
    public long DividePlayers(int[] skill)
    {
        int n = skill.Length;
        Array.Sort(skill);
        IList<int[]> dict = new List<int[]>();

        for (int i = 0, j = n - 1; i < n / 2; i++, j--)
        {   
            int[] pair = {skill[i], skill[j]};
            dict.Add(pair);
        }
        int target = dict[0][0] + dict[0][1];
        Console.WriteLine(target);
        long ans = 0;
        foreach (int[] arr in dict)
        {
            int curr = arr[0] + arr[1];
            if (curr != target)
            {
                return -1;
            }
            ans += arr[0] * arr[1];
        }
        return ans;
    }
}
