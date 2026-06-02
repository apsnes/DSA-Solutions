public class Solution
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
    {
        var res = int.MaxValue;
        
        for (int i = 0; i < landStartTime.Length; i++)
        {
            for (int j = 0; j < waterStartTime.Length; j++)
            {
                var currLandEnd = landStartTime[i] + landDuration[i];
                currLandEnd = Math.Max(currLandEnd, waterStartTime[j]) + waterDuration[j];
                var currWaterEnd = waterStartTime[j] + waterDuration[j];
                currWaterEnd = Math.Max(currWaterEnd, landStartTime[i]) + landDuration[i];
                res = Math.Min(res, Math.Min(currLandEnd, currWaterEnd));
            }
        }
        return res;
    }
}
