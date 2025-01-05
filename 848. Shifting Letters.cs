public class Solution
{
    public string ShiftingLetters(string s, int[] shifts)
    {
        int n = s.Length;
        //Initiate a prefix sum array
        long[] prefix = new long[n];
        //Create a variable to store the value of the current shift
        long currentShift = 0;
        //Iterate through the shifts from n - 1 to 0 totalling up the shifts made on each index. The reason we start from the end is because
        //each shift is applied to all indexes before it
        for (int i = n - 1; i >= 0; i--)
        {
            currentShift += shifts[i];
            //Store the curerntShift for i in the prefix array
            prefix[i] = currentShift;
        }
        //Convert to char array for easier manipulation
        char[] c = s.ToCharArray();
        //Iterate through the prefix array and apply the pre computed conversion
        for (int i = 0; i < n; i++)
        {
            c[i] = ShiftCharacter(c[i], prefix[i]);
        }
        return new string(c);
    }
    public char ShiftCharacter(char c, long shift)
    {
        //To shift a char, map each character to integers 0-25 with - 'a'. We then add the shift value to the mapped number and mod it by 26 to
        //prevent it from going out of bounds. We then add 'a' to convert it back to unicode and finally convert the integer value back to
        //a char
        return Convert.ToChar((c - 'a' + shift) % 26 + 'a');
    }
}
