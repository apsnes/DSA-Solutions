public class Solution
{
    private Dictionary<char, char[]> dict = new()
    {
        { '2', [ 'a', 'b', 'c' ] },
        { '3', [ 'd', 'e', 'f' ] },
        { '4', [ 'g', 'h', 'i' ] },
        { '5', [ 'j', 'k', 'l' ] },
        { '6', [ 'm', 'n', 'o' ] },
        { '7', [ 'p', 'q', 'r', 's' ] },
        { '8', [ 't', 'u', 'v' ] },
        { '9', [ 'w', 'x', 'y', 'z' ] }
    };

    public List<string> LetterCombinations(string digits)
    {
        var res = new List<string>();
        if (digits == "") return res;
        CreateStrings(digits, 0, "", res);
        return res;
    }

    private void CreateStrings(string digits, int currIndex, string currString, List<string> res)
    {
        if (currString.Length == digits.Length)
        {
            res.Add(currString);
            return;
        }

        var currDigit = digits[currIndex];

        foreach (var c in dict[currDigit])
        {
            currString += c;
            CreateStrings(digits, currIndex + 1, currString, res);
            currString = currString[..^1];
        }
    }
}
