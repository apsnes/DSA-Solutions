public class Solution
{
    public int CountCollisions(string directions)
    {
        int res = directions.Length;
        int n = directions.Length;

        if (directions.StartsWith("L"))
        {
            int i = 0;
            while (i < n && directions[i] == 'L')
            {
                res--;
                i++;
            }
        }
        if (directions.EndsWith("R"))
        {
            int i = n - 1;
            while (i >= 0 && directions[i] == 'R')
            {
                res--;
                i--;
            }
        }
        foreach (char c in directions)
        {
            if (c == 'S') res--;
        }

        return res;
    }
}
