public class Solution {
    char[] vowels = [ 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
    public bool IsValid(string word)
    {
        if (word.Any(c => !char.IsLetterOrDigit(c))) return false;
        if (!word.Any(c => isVowel(c))) return false;
        if (!word.Any (c => isConsonant(c))) return false;
        if (word.Length < 3) return false;
        return true;
    }
    private bool isVowel(char c)
    {
        if (char.IsLetter(c) && vowels.Contains(c)) return true;
        return false;
    }
    private bool isConsonant(char c)
    {
        if (char.IsLetter(c) && !vowels.Contains(c)) return true;
        return false;
    }
}
