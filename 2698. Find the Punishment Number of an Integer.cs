public class Solution
{
    public int PunishmentNumber(int n)
    {
        int ans = 0;
        for (int i = 1; i <= n; i++)
        {
            if (isPartitionValid(i, i * i))
            {
                ans += i * i;
            }
        }
        return ans;
    }

    private bool isPartitionValid(int targetNum, int currentNum)
    {
        if (targetNum == currentNum) return true;
        if (targetNum < 0 || currentNum < targetNum) return false;

        return  isPartitionValid(targetNum - (currentNum % 10), currentNum / 10) ||
                isPartitionValid(targetNum - (currentNum % 100), currentNum / 100) ||
                isPartitionValid(targetNum - (currentNum % 1000), currentNum / 1000);
    }
}
