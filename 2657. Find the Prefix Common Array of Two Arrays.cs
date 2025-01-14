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
