public class Solution
{
    public int MirrorDistance(int n)
    {
        return Math.Abs(n - Reverse(n));
    }

    private int Reverse(int n)
    {
        var c = n.ToString().ToCharArray();
        var newC = new char[c.Length];
        var newIndex = newC.Length - 1;
        for (int oldIndex = 0; oldIndex < c.Length; oldIndex++)
        {
            newC[newIndex] = c[oldIndex];
            newIndex--;
        }
        return int.Parse(string.Join("", newC));
    }
}
