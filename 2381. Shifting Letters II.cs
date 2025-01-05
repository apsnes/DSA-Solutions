public class Solution
{
    public string ShiftingLetters(string s, int[][] shifts)
    {
        //Create a prefix array to store desired total shifts for each character in the string
        int[] prefix = new int[s.Length + 1];
        foreach (var shift in shifts)
        {
            //forward shift
            if (shift[2] == 1)
            {
                //Set the start index of the shift in our prefix array to be +1, this ensures that every index after it will be incremented
                //in our shift operations
                prefix[shift[0]]++;
                //At the prefix array index following the end index of the shift, - 1 from the current value. This offsets the previously
                //applied shift to the characters that don't require it
                prefix[shift[1] + 1]--;
            }
            //backward shift is the inverse of the above
            else
            {
                prefix[shift[0]]--;
                prefix[shift[1] + 1]++;                
            }
        }
        //Convert s to a char array for easier manipulation
        char[] c = s.ToCharArray();
        //Initiate a variable to store the value of the current shift operation
        int currShift = 0;
        for (int i = 0; i < s.Length; i++)
        {
            //Add the pre calculated value to the current shift amount
            currShift += prefix[i];
            //Apply the shift
            c[i] = Convert.ToChar(((c[i] - 'a' + currShift) % 26 + 26) % 26 + 'a'); 
        }
        //return the manipulated array back as a string
        return new string(c);
    }
}
