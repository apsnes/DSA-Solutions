public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        IList<int> current = new List<int>();
        Dfs(0, current, 0, target, answer, candidates);
        return answer;
    }

    public void Dfs(int i, IList<int> current, int total, int target, IList<IList<int>> answer, int[] candidates)
    {
        if (total == target)
        {
            answer.Add(current.ToList());
            return;
        }
        if (i >= candidates.Length || total > target)
        {
            return;
        }
        current.Add(candidates[i]);
        Dfs(i, current, total + candidates[i], target, answer, candidates);
        current.Remove(current.Last());
        Dfs(i + 1, current, total, target, answer, candidates);
    }
}
