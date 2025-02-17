public class Solution
{
    public int NumTilePossibilities(string tiles)
    {
        HashSet<string> sequences = new();
        bool[] usedChars = new bool[tiles.Length];
        generateSequences(tiles, "", usedChars, sequences);
        return sequences.Count() - 1;
    }

    private void generateSequences(string tiles, string curr, bool[] usedChars, HashSet<string> sequences)
    {
        sequences.Add(curr);
        for (int i = 0; i < tiles.Length; i++)
        {
            if (!usedChars[i])
            {
                usedChars[i] = true;
                generateSequences(tiles, curr + tiles[i], usedChars, sequences);
                usedChars[i] = false;
            }
        }
    }
}
