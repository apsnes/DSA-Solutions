public class Solution
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration)
    {
        var earliestLandFinish = int.MaxValue;
        for (int i = 0; i < landStartTime.Length; i++)
        {
            earliestLandFinish = Math.Min(earliestLandFinish, landStartTime[i] + landDuration[i]);
        }
        var earliestWaterFinish = int.MaxValue;
        var landResult = int.MaxValue;
        for (int i = 0; i < waterStartTime.Length; i++)
        {
            earliestWaterFinish = Math.Min(earliestWaterFinish, waterStartTime[i] + waterDuration[i]);
            if (waterStartTime[i] >= earliestLandFinish) landResult = Math.Min(landResult, waterStartTime[i] + waterDuration[i]);
            else landResult = Math.Min(landResult, earliestLandFinish + waterDuration[i]);
        }
        var waterResult = int.MaxValue;
        for (int i = 0; i < landStartTime.Length; i++)
        {
            if (landStartTime[i] >= earliestWaterFinish) waterResult = Math.Min(waterResult, landStartTime[i] + landDuration[i]);
            else waterResult = Math.Min(waterResult, earliestWaterFinish + landDuration[i]);
        }
        return Math.Min(landResult, waterResult);
    }
}
