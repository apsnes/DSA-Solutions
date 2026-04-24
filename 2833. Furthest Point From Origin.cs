public class Solution
{
    public int FurthestDistanceFromOrigin(string moves)
    {
        var leftDist = 0;
        var rightDist = 0;

        for (int i = 0; i < moves.Length; i++)
        {
            if (moves[i] == 'L')
            {
                leftDist++;
                rightDist--;
            }
            else if (moves[i] == 'R')
            {
                leftDist --;
                rightDist++;
            }
            else
            {
                leftDist++;
                rightDist++;
            }
        }
        return Math.Max(leftDist, rightDist);
    }
}
