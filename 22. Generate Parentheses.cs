public class Solution
{
    List<string> res = new();
    int n;

    public IList<string> GenerateParenthesis(int n)
    {
        this.n = n;
        AddParenthesis(1, 0, "(");
        return res;
    }

    private void AddParenthesis(int currOpen, int currClosed, string currString)
    {
        if (currOpen == n && currClosed == n) res.Add(currString);
        else if (currOpen == n)
        {
            currString += ")";
            AddParenthesis(currOpen, currClosed + 1, currString);
        }
        else
        {
            currString += ("(");
            AddParenthesis(currOpen + 1, currClosed, currString);
            if (currClosed < currOpen)
            {
                currString = currString.Remove(currString.Length - 1);
                currString += ")";
                AddParenthesis(currOpen, currClosed + 1, currString);
            }       
        }
    }
}
