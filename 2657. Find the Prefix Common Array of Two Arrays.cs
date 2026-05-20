public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int n = A.Length;
        int seenCount = 0;
        int[] ans = new int[n];
        HashSet<int> aSeen = new();
        HashSet<int> bSeen = new();
        for (int i = 0; i < n; i++)
        {
            if (A[i] == B[i])
            {
                seenCount++;
                ans[i] = seenCount;
                continue;
            }
            if (bSeen.Contains(A[i])) seenCount++;
            if (aSeen.Contains(B[i])) seenCount++;
            aSeen.Add(A[i]);
            bSeen.Add(B[i]);
            ans[i] = seenCount;
        }
        return ans;
    }
}

// Single Dictionary
public class Solution
{
    public int[] FindThePrefixCommonArray(int[] a, int[] b)
    {
        var n = a.Length;
        var res = new int[n];
        var currCount = 0;
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            var currA = a[i];
            var currB = b[i];
            if (!dict.ContainsKey(currA)) dict[currA] = 0;
            if (!dict.ContainsKey(currB)) dict[currB] = 0;
            dict[currA]++;
            dict[currB]++;
            if (dict[currA] == 2) currCount++;
            if (currA != currB && dict[currB] == 2) currCount++;
            res[i] = currCount;
        }
        return res;
    }
}
