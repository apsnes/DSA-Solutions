public class Solution
{
    public IList<string> FindAllRecipes(string[] recipes, IList<IList<string>> ingredients, string[] supplies)
    {
        HashSet<string> availableSupplies = new();
        Dictionary<string, int> recipeToIndex = new();
        Dictionary<string, List<string>> dependencyGraph = new();
        foreach(var s in supplies) availableSupplies.Add(s);
        for (int i = 0; i < recipes.Length; i++) recipeToIndex.Add(recipes[i], i);
        int[] inDegree = new int[recipes.Length];
        for (int i = 0; i < recipes.Length; i++)
        {
            foreach (var ingredient in ingredients[i])
            {
                if (!availableSupplies.Contains(ingredient))
                {
                    if (!dependencyGraph.ContainsKey(ingredient)) dependencyGraph[ingredient] = new();
                    dependencyGraph[ingredient].Add(recipes[i]);
                    inDegree[i]++;
                }
            }
        }
        Queue<int> q = new();
        for (int i = 0; i < recipes.Length; i++) if (inDegree[i] == 0) q.Enqueue(i);
        List<string> createdRecipes = new();
        while (q.Count > 0)
        {
            int i = q.Dequeue();
            string recipe = recipes[i];
            createdRecipes.Add(recipe);
            if (!dependencyGraph.ContainsKey(recipe)) continue;
            foreach (var dep in dependencyGraph[recipe])
            {
                if (--inDegree[recipeToIndex[dep]] == 0) q.Enqueue(recipeToIndex[dep]);
            }
        }
        return createdRecipes;
    }
}
