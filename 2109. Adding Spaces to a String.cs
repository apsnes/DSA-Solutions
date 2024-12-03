public class Solution {
    public string AddSpaces(string s, int[] spaces)
    {
        StringBuilder sb = new();
        int spaceIndex = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (spaces[spaceIndex] == i)
            {
                sb.Append(" ");
                if (spaceIndex < spaces.Length - 1) spaceIndex++;
            }
            sb.Append(s[i]);
        }
        return sb.ToString();
    }
}
